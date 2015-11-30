Imports penjadwalan.Classes

Namespace Form
    Public Class FrmWaktuTidakBersedia

        'waktu_tidak_bersedia:kode,kode_dosen,kode_jam,kode_hari
        Private ReadOnly _dbConnect As New ClassDbConnect()


        Private Sub CreateDbGridColumn()
            'Nama hari
            Dim dgvHari = New DataGridViewTextBoxColumn With {.HeaderText = "Hari", .Name = "dgvHari", .ReadOnly = True}
            dtGridView.Columns.Add(dgvHari)

            'Nama Range Jam
            Dim dgvJam = New DataGridViewTextBoxColumn With {.HeaderText = "Jam", .Name = "dgvJam", .ReadOnly = True}
            dtGridView.Columns.Add(dgvJam)

            Dim dgvTidakBersedia = New DataGridViewCheckBoxColumn With {.HeaderText = "Tidak Bersedia", .Name = "dgvTidakBersedia", .ReadOnly = False}
            dtGridView.Columns.Add(dgvTidakBersedia)

            'Nama hari
            Dim dgvHariKode = New DataGridViewTextBoxColumn With {.HeaderText = "Hari", .Name = "dgvHariKode", .ReadOnly = True, .Visible = False}
            dtGridView.Columns.Add(dgvHariKode)

            'Nama Range Jam
            Dim dgvJamKode = New DataGridViewTextBoxColumn With {.HeaderText = "Jam", .Name = "dgvJamKode", .ReadOnly = True, .Visible = False}
            dtGridView.Columns.Add(dgvJamKode)
        End Sub
        Private Sub FrmWaktuTidakBersedia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CreateDbGridColumn()

            'load dosen
            Dim dosen_dt = _dbConnect.GetRecord("SELECT * FROM dosen " & "ORDER BY nama")
            cmbDosen.DataSource = dosen_dt
            cmbDosen.DisplayMember = "nama"
            cmbDosen.ValueMember = "kode"

            LoadData(GetCmbKodeDosen())


        End Sub

        Private Sub LoadData(ByVal kode_dosen As Integer)
            dtGridView.Rows.Clear()

            'load hari
            Dim dtHari = _dbConnect.GetRecord(String.Format("SELECT nama,kode " & "FROM hari " & "WHERE aktif = '{0}'" & "ORDER BY kode", "True"))
            'load jam
            Dim dtJam = _dbConnect.GetRecord("SELECT range_jam,kode " & "FROM jam")

            Dim dt = _dbConnect.GetRecord(String.Format("SELECT kode_hari,kode_jam " & "FROM waktu_tidak_bersedia " & "WHERE kode_dosen = {0}", kode_dosen))

            For i = 0 To dtHari.Rows.Count - 1
                For j As Integer = 0 To dtJam.Rows.Count - 1
                    dtGridView.Rows.Add(dtHari.Rows(i)(0).ToString(), dtJam.Rows(j)(0).ToString(), "False", dtHari.Rows(i)(1).ToString(), dtJam.Rows(j)(1).ToString())

                    For k As Integer = 0 To dt.Rows.Count - 1
                        If dtHari.Rows(i)(1).ToString() = dt.Rows(k)(0).ToString() AndAlso dtJam.Rows(j)(1).ToString() = dt.Rows(k)(1).ToString() Then
                            dtGridView(2, dtGridView.Rows.Count - 1).Value = "True"
                        End If
                    Next k
                Next j
            Next i
        End Sub

        Private Function GetCmbKodeDosen() As Integer
            Dim rowDosen = CType(cmbDosen.DataSource, DataTable).Rows(cmbDosen.SelectedIndex)
            Dim kodeDosen = CInt(Fix(rowDosen("kode")))
            Return kodeDosen
        End Function

        Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
            Dim kodeDosen = GetCmbKodeDosen()

            _dbConnect.ExecuteNonQuery(String.Format("DELETE FROM waktu_tidak_bersedia " & "WHERE kode_dosen = {0}", kodeDosen))
            For i = 0 To dtGridView.Rows.Count - 1
                'dtGridView[5, dtGridView.SelectedRows[0].Index].Value.ToString();
                If dtGridView(2, i).Value.ToString() = "True" Then
                    'MessageBox.Show("YA");
                    _dbConnect.ExecuteNonQuery(String.Format("INSERT INTO waktu_tidak_bersedia(kode_dosen,kode_hari, kode_jam) " & "VALUES ({0},{1},{2})", kodeDosen, dtGridView(3, i).Value, dtGridView(4, i).Value))
                End If
            Next i
            MessageBox.Show("Data telah tersimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Sub

        Private Sub cmbDosen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDosen.SelectedIndexChanged
            LoadData(GetCmbKodeDosen())

        End Sub

        Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
            Close()
        End Sub
    End Class
End Namespace