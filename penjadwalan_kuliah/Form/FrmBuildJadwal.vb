#Const SAVE_AS_XL = True

Option Infer On

Imports System.IO
Imports System.Globalization
Imports penjadwalan.penjadwalan.Class
Imports penjadwalan.Classes
Imports IniParser
Imports Microsoft.Office.Interop

Namespace Form
    Public Class FrmBuildJadwal
        Private maxIterasi As Integer
        Private populasi As Integer
        Private genetik As ClassGenetik
        Private kode_jumat As Integer
        Private kode_dhuhur As Integer
        Private range_jumat() As Integer

        Private ReadOnly _dbConnect As New ClassDbConnect()
        Private Shared ReadOnly parser As New FileIniDataParser()
        Private ReadOnly data As IniData = parser.LoadFile("config.ini")

        'solution
        Private jadwal_kuliah(,) As Integer

        Private Sub FrmBuildJadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            'load config
            txtJumlahPopulasi.Text = data("genetik")("populasi")
            numCrossover.Text = data("genetik")("crossover")
            numMutasi.Text = data("genetik")("mutasi")
            txtIterasi.Text = data("genetik")("max_iterasi")

            kode_jumat = Integer.Parse(data("genetik")("kode_jumat"))
            kode_dhuhur = Integer.Parse(data("genetik")("kode_dhuhur"))
            range_jumat = data("genetik")("range_jumat").Split("-"c).ToIntArray()
        End Sub

        Private Sub label9_Click(sender As Object, e As EventArgs) Handles label9.Click
            MessageBox.Show("Kenapa? " & vbLf & "Karena prinsip yang digunakan adalah pernikahan Monogami" & vbLf & "jadi satu istri (mungkin) lebih baik :)")

        End Sub

        Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
            Close()
        End Sub

        Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
            Const GANJIL As Integer = 1
            Const GENAP As Integer = 0


            Dim jenis_semester As Integer = If(cmbSemester.Text = "GANJIL", GANJIL, GENAP)
            Dim tahun_akademik As String = cmbTahunAkademik.Text
            populasi = Integer.Parse(txtJumlahPopulasi.Text)

            If populasi Mod 2 <> 0 Then
                MessageBox.Show("Populasi harus kelipatan 2")
                Return
            End If

            Dim crossOver As Single = Single.Parse(numCrossover.Text)
            Dim mutasi As Single = Single.Parse(numMutasi.Text)
            maxIterasi = Integer.Parse(txtIterasi.Text)


            genetik = New ClassGenetik(jenis_semester, tahun_akademik, populasi, crossOver, mutasi, kode_jumat, range_jumat, kode_dhuhur)

            genetik.AmbilData()
            genetik.Inisialisasi()


            If Not worker.IsBusy Then
                worker.RunWorkerAsync()
                btnProses.Enabled = False
                DisableAllParamComponent(True)
                btnStop.Enabled = True
            End If

        End Sub

        Private Sub DisableAllParamComponent(ByVal disabled As Boolean)
            txtIterasi.Enabled = Not disabled
            numMutasi.Enabled = txtIterasi.Enabled
            numCrossover.Enabled = numMutasi.Enabled
            txtJumlahPopulasi.Enabled = numCrossover.Enabled
            cmbTahunAkademik.Enabled = txtJumlahPopulasi.Enabled
            cmbSemester.Enabled = cmbTahunAkademik.Enabled
        End Sub

        Private Sub Export2Excel()
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = CType(xlWorkBook.Worksheets.Item("sheet1"), Microsoft.Office.Interop.Excel.Worksheet)

            'export header
            For i = 1 To dtGridView.Columns.Count
                xlWorkSheet.Cells(1, i) = dtGridView.Columns(i - 1).HeaderText
            Next i

            'export data
            For i = 1 To dtGridView.RowCount
                For j = 1 To dtGridView.Columns.Count
                    xlWorkSheet.Cells(i + 1, j) = dtGridView.Rows(i - 1).Cells(j - 1).Value
                Next j
            Next i

            'set font Khmer OS System to data range
            Dim myRange As Excel.Range = xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(dtGridView.RowCount + 1, dtGridView.Columns.Count))
            Dim x As Excel.Font = myRange.Font
            x.Name = "Arial"
            x.Size = 10

            'set bold font to column header
            myRange = xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, dtGridView.Columns.Count))
            x = myRange.Font
            x.Bold = True
            'autofit all columns
            myRange.EntireColumn.AutoFit()

            xlApp.DisplayAlerts = False
#If (SAVE_AS_XL) Then
            xlWorkBook.SaveAs(Path.GetDirectoryName(Application.ExecutablePath) & "\" & "report", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
#Else
            xlWorkBook.SaveAs(Path.GetDirectoryName(Application.ExecutablePath) & vbCr & "report", Excel.XlFileFormat.xlHtml, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
#End If

            xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()

            releaseObject(xlWorkSheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)
        End Sub

        Private Shared Sub releaseObject(ByVal obj As Object)
            Try
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            Catch ex As Exception
                obj = Nothing
                MessageBox.Show("Exception Occured while releasing object " & ex.ToString())
            Finally
                GC.Collect()
            End Try
        End Sub

        Private Sub worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles worker.DoWork
            Dim stopwatch As New Stopwatch()
            stopwatch.Start()

            'loop here
            For i As Integer = 0 To maxIterasi - 1
                If worker.CancellationPending Then
                    e.Cancel = True
                    Exit For
                End If

                Dim fitness() As Single = genetik.HitungFitness()
                genetik.Seleksi(fitness)
                genetik.StartCrossOver()

                Dim fitnessAfterMutation() As Single = genetik.Mutasi()

                For j = 0 To fitnessAfterMutation.Length - 1
                    If ClassHelper.AlmostEquals(fitnessAfterMutation(j), 1.0, 0) Then
                        jadwal_kuliah = genetik.GetIndividu(j)
                        UpdateUI(i, maxIterasi, fitnessAfterMutation, True)

                        stopwatch.Stop()
                        Dim ts As TimeSpan = stopwatch.Elapsed


                        MessageBox.Show(String.Format("Solusi ditemukan" & vbLf & "Waktu yang diperlukan: " & "{0:00} Jam, {1:00} Menit," & vbLf & "{2:00} Detik dan {3:00} Milidetik" & vbLf & "Report disimpan di report.xls", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds \ 10), "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Export2Excel()
                        genetik.WriteLog2Disk()
                        Return
                    End If
                Next j
                'genetik.WriteLog2Disk();
                UpdateUI(i, maxIterasi, fitnessAfterMutation, False)
            Next i
            'end loop here

            MessageBox.Show("Solusi TIDAK ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'save last log
            genetik.WriteLog2Disk()

        End Sub

        Private Delegate Sub UpdateUIDelegate(ByVal i As Integer, ByVal max As Integer, ByVal fitnessAfterMutation() As Single, ByVal found As Boolean)
        Private Sub UpdateUI(ByVal i As Integer, ByVal max As Integer, ByVal fitnessAfterMutation() As Single, ByVal found As Boolean)
            If lblPosition.InvokeRequired Then
                lv.Invoke(New UpdateUIDelegate(AddressOf UpdateUI), i, max, fitnessAfterMutation, found)
            Else
                progressBar.Value = CInt(Fix((i + 1.0F) * 100 \ max))
                lblPosition.Text = String.Format("Generasi ke {0}", (i + 1).ToString(CultureInfo.InvariantCulture))


                'if(i == 0) lv.Items.Clear();
                Dim Rata2Fitness As Single = 0

                Dim lvItems(populasi - 1) As ListViewItem
                For j As Integer = 0 To populasi - 1
                    Dim lvItem = New ListViewItem((j + 1).ToString(CultureInfo.InvariantCulture))
                    lvItem.SubItems.Add(fitnessAfterMutation(j).ToString(CultureInfo.InvariantCulture))
                    lvItems(j) = lvItem
                    Rata2Fitness += fitnessAfterMutation(j)
                Next j

                'lv.BeginUpdate();
                lv.Items.Clear()
                lv.Items.AddRange(lvItems)
                'lv.EndUpdate();

                lblRata2Fitness.Text = String.Format("Rata-rata Fitness: {0}", (Rata2Fitness / populasi).ToString(CultureInfo.InvariantCulture))


                If found Then
                    btnProses.Enabled = True
                    DisableAllParamComponent(False)
                    btnStop.Enabled = False

                    _dbConnect.ExecuteNonQuery("TRUNCATE TABLE jadwal_kuliah")

                    For k = 0 To jadwal_kuliah.GetLength(0) - 1
                        Dim q = String.Format("INSERT INTO jadwal_kuliah(kode_pengampu,kode_jam,kode_hari,kode_ruang) " & "VALUES({0},{1},{2},{3})", jadwal_kuliah(k, 0), jadwal_kuliah(k, 1), jadwal_kuliah(k, 2), jadwal_kuliah(k, 3))

                        _dbConnect.ExecuteNonQuery(q)

                    Next k
                    '}

                    'tampilkan
                    Const query As String = "SELECT  e.nama as Hari," & "          Concat_WS('-',  concat('(', g.kode), concat( (SELECT kode" & "                                  FROM jam " & "                                  WHERE kode = (SELECT jm.kode " & "                                                FROM jam jm  " & "                                                WHERE MID(jm.range_jam,1,5) = MID(g.range_jam,1,5)) + (c.sks - 1)),')')) as SESI, " & " 		  Concat_WS('-', MID(g.range_jam,1,5)," & "                (SELECT MID(range_jam,7,5) " & "                 FROM jam " & "                 WHERE kode = (SELECT jm.kode " & "                               FROM jam jm " & "                               WHERE MID(jm.range_jam,1,5) = MID(g.range_jam,1,5)) + (c.sks - 1))) as Jam_Kuliah, " & "        c.nama as `Nama MK`," & "        c.sks as SKS," & "        c.semester as Smstr," & "        b.kelas as Kelas," & "        d.nama as Dosen," & "        f.nama as Ruang " & "FROM jadwal_kuliah a " & "LEFT JOIN pengampu b " & "ON a.kode_pengampu = b.kode " & "LEFT JOIN mata_kuliah c " & "ON b.kode_mk = c.kode " & "LEFT JOIN dosen d " & "ON b.kode_dosen = d.kode " & "LEFT JOIN hari e " & "ON a.kode_hari = e.kode " & "LEFT JOIN ruang f " & "ON a.kode_ruang = f.kode " & "LEFT JOIN jam g " & "ON a.kode_jam = g.kode " & "order by e.nama desc,Jam_Kuliah asc;"

                    Dim dt = _dbConnect.GetRecord(query)
                    dtGridView.DataSource = dt
                End If
            End If

            If i = max - 1 Then
                btnProses.Enabled = True
                DisableAllParamComponent(False)
                btnStop.Enabled = False
            End If
        End Sub

        Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
            If Not worker.WorkerSupportsCancellation Then
                Return
            End If
            worker.CancelAsync()
            btnProses.Enabled = True
            DisableAllParamComponent(False)
            btnStop.Enabled = False

        End Sub

        Private Sub FrmBuildJadwal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not worker.IsBusy Then
                Return
            End If
            MessageBox.Show("Matikan dulu proses yang sedang berjalan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True

        End Sub
    End Class
End Namespace