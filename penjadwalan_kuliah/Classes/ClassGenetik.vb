
'#define SHOW_LOG
Imports System.Globalization
Imports System.IO
Imports System.Windows.Forms
Imports penjadwalan.Classes


Namespace penjadwalan.Class

    Friend Class ClassGenetik
        'TODO:NEED INTENSIVE ATTENTIONS
#Region "Variables"
        ReadOnly _dbConnect As New ClassDbConnect()

        '
        Private Const PRAKTIKUM As String = "PRAKTIKUM"
        Private Const TEORI As String = "TEORI"
        Private Const LABORATORIUM As String = "LABORATORIUM"


        Private ReadOnly _jenisSemester As Integer
        Private ReadOnly _tahunAkademik As String
        Private ReadOnly _populasi As Integer
        Private ReadOnly _crossOver As Single
        Private ReadOnly _mutasi As Single

        Private _mataKuliah As Integer()
        Private _individu As Integer(,,)
        Private _sks As Integer()
        'sks terikat pada tabel pengampu
        Private _dosen As Integer()
        'dosen terikat pada tabel pengampu
        Private _jam As Integer()
        Private _hari As Integer()
        Private _iDosen As Integer()

        'waktu keinginan dosen
        Private _waktuDosen As String(,)

        Private _jenisMk As String()
        'reguler or praktikum
        Private _ruangLaboratorium As Integer()
        Private _ruangReguler As Integer()

        Private logAmbilData As String
        Private logInisialisasi As String

        Private _log As String
        Private _induk As Integer()


        'jumat
        Private ReadOnly _kodeJumat As Integer
        Private ReadOnly _rangeJumat As Integer()

        Private ReadOnly _kodeDhuhur As Integer
#End Region

#Region "Constructor"
        Public Sub New(jenisSemester As Integer, tahunAkademik As String, populasi As Integer, crossOver As Single, mutasi As Single, kodeJumat As Integer, _
            rangeJumat As Integer(), kodeDhuhur As Integer)
            Me._jenisSemester = jenisSemester
            Me._tahunAkademik = tahunAkademik
            Me._populasi = populasi
            Me._crossOver = crossOver
            Me._mutasi = mutasi
            Me._kodeJumat = kodeJumat
            Me._rangeJumat = rangeJumat
            Me._kodeDhuhur = kodeDhuhur
        End Sub
#End Region

#Region "Ambil data"
        Public Sub AmbilData()
            'Fill  Array of mata kuliah and SKS Variables

#If (SHOW_LOG) Then
			logAmbilData += String.Format(vbCr & "===========================[{0}] => Ambil Data...." & vbLf, DateTime.Now.ToString("HH:mm:ss.fff tt"))
#End If
            Dim dtMK_Pengampu = _dbConnect.GetRecord(String.Format(
                                                     "SELECT a.kode," +
                                                     "       b.sks," +
                                                     "       a.kode_dosen," +
                                                     "       b.jenis " +
                                                     "FROM pengampu a " +
                                                     "LEFT JOIN mata_kuliah b " +
                                                     "ON a.kode_mk = b.kode " +
                                                     "WHERE b.semester%2 = {0} AND a.tahun_akademik = '{1}'", _jenisSemester, _tahunAkademik))
            _mataKuliah = New Integer(dtMK_Pengampu.Rows.Count - 1) {}
            _sks = New Integer(dtMK_Pengampu.Rows.Count - 1) {}
            _dosen = New Integer(dtMK_Pengampu.Rows.Count - 1) {}
            _jenisMk = New String(dtMK_Pengampu.Rows.Count - 1) {}

            For i = 0 To dtMK_Pengampu.Rows.Count - 1
                _mataKuliah(i) = CInt(dtMK_Pengampu.Rows(i)(0))
                _sks(i) = CInt(dtMK_Pengampu.Rows(i)(1))
                _dosen(i) = CInt(dtMK_Pengampu.Rows(i)(2))
                'reguler or praktikum
                _jenisMk(i) = dtMK_Pengampu.Rows(i)(3).ToString()
            Next

            'Fill Array of Jam Variables 
            Dim dtJam = _dbConnect.GetRecord("SELECT kode " +
                                             "FROM jam")
            _jam = New Integer(dtJam.Rows.Count - 1) {}
            For i = 0 To dtJam.Rows.Count - 1
                _jam(i) = CInt(dtJam.Rows(i)(0))
            Next

            'Fill Array of Hari Variables 
            Dim dtHari = _dbConnect.GetRecord("SELECT kode " +
                                              "FROM hari " +
                                              "WHERE aktif = 'True'")
            _hari = New Integer(dtHari.Rows.Count - 1) {}
            For i = 0 To dtHari.Rows.Count - 1
                _hari(i) = CInt(dtHari.Rows(i)(0))
            Next

            Dim dtRuangReguler = _dbConnect.GetRecord(String.Format(
                                                      "SELECT kode " +
                                                      "FROM ruang " +
                                                      "WHERE jenis = '{0}'", TEORI))
            _ruangReguler = New Integer(dtRuangReguler.Rows.Count - 1) {}
            For i As Integer = 0 To dtRuangReguler.Rows.Count - 1
                _ruangReguler(i) = CInt(dtRuangReguler.Rows(i)(0))
            Next

            Dim dtRuangLaboratorium = _dbConnect.GetRecord(String.Format(
                                                           "SELECT kode " +
                                                           "FROM ruang " +
                                                           "WHERE jenis = '{0}'", LABORATORIUM))
            _ruangLaboratorium = New Integer(dtRuangLaboratorium.Rows.Count - 1) {}
            For i As Integer = 0 To dtRuangLaboratorium.Rows.Count - 1
                _ruangLaboratorium(i) = CInt(dtRuangLaboratorium.Rows(i)(0))
            Next

            Dim dtWaktuDosen = _dbConnect.GetRecord("SELECT kode_dosen,CONCAT_WS(':',kode_hari,kode_jam) " +
                                                    "FROM waktu_tidak_bersedia")
            _waktuDosen = New String(dtWaktuDosen.Rows.Count - 1, 1) {}
            _iDosen = New Integer(dtWaktuDosen.Rows.Count - 1) {}

            For i = 0 To dtWaktuDosen.Rows.Count - 1
                _iDosen(i) = CInt(dtWaktuDosen.Rows(i)(0))
                _waktuDosen(i, 0) = dtWaktuDosen.Rows(i)(0).ToString()
                'kode dosen
                'CONCAT_WS(':',kode_hari,kode_jam)
                _waktuDosen(i, 1) = dtWaktuDosen.Rows(i)(1).ToString()
            Next

#If (SHOW_LOG) Then
			logAmbilData += String.Format("Jumlah MataKuliah: {0}" & vbLf + "Jumlah Jam: {1}" & vbLf + "Jumlah Hari: {2}" & vbLf + "Jumlah Ruang: {3}" & vbLf, dtMK_Pengampu.Rows.Count, dtJam.Rows.Count, dtHari.Rows.Count, dtRuangReguler.Rows.Count + dtRuangLaboratorium.Rows.Count)
#End If
        End Sub
#End Region

#Region "WriteLog2Disk"

        Public Sub WriteLog2Disk()
            Dim filepath = String.Format("{0}\log.txt", Path.GetDirectoryName(Application.ExecutablePath))
            If True Then
                File.WriteAllText(filepath, Convert.ToString(logAmbilData & logInisialisasi) & _log)
            End If
        End Sub

#End Region

#Region "Inisialisasi"
        Public Sub Inisialisasi()
            Dim random = New Random()
            _individu = New Integer(_populasi - 1, _mataKuliah.Length - 1, 3) {}

#If (SHOW_LOG) Then
			logInisialisasi += String.Format(vbCr & "===========================[{0}] => Ambil Nilai Parameter...." & vbLf, DateTime.Now.ToString("HH:mm:ss.fff tt"))
			logInisialisasi += String.Format("Populasi: {0}" & vbLf + "Crossover: {1}" & vbLf + "Mutasi: {2}", populasi, crossOver, mutasi)

#End If

            For i = 0 To _populasi - 1
#If (SHOW_LOG) Then
				logInisialisasi += String.Format(vbCr & vbLf & vbLf & "[{0}] => Individu Ke-{1} #MK,JAM,HARI,RUANG", DateTime.Now.ToString("HH:mm:ss.fff tt"), (i + 1))
#End If

                For j = 0 To _mataKuliah.Length - 1
                    '  Perulangan untuk pembangkitan jadwal 
                    _individu(i, j, 0) = j
                    ' Penentuan matakuliah dan kelas 
                    If _sks(j) = 1 Then
                        ' Penentuan jam secara acak ketika 1 sks 
                        _individu(i, j, 1) = random.[Next](_jam.Length)
                    End If
                    If _sks(j) = 2 Then
                        ' Penentuan jam secara acak ketika 2 sks 
                        _individu(i, j, 1) = random.[Next](_jam.Length - 1)
                    End If
                    If _sks(j) = 3 Then
                        ' Penentuan jam secara acak ketika 3 sks 
                        _individu(i, j, 1) = random.[Next](_jam.Length - 2)
                    End If
                    If _sks(j) = 4 Then
                        ' Penentuan jam secara acak ketika 4 sks 
                        _individu(i, j, 1) = random.[Next](_jam.Length - 3)
                    End If
                    'System.Threading.Thread.Sleep(1);
                    _individu(i, j, 2) = random.[Next](_hari.Length)
                    ' Penentuan hari secara acak 
                    'TODO: jika kuliah reguler => ruang reguler
                    'TODO: jika kuliah praktikum => ruang lab 
                    'individu[i, j, 3] = random.Next(ruang.Length); // Penentuan ruang secara acak 
                    If _jenisMk(j) = TEORI Then
                        _individu(i, j, 3) = _ruangReguler(random.[Next](_ruangReguler.Length))
                    Else
                        _individu(i, j, 3) = _ruangLaboratorium(random.[Next](_ruangLaboratorium.Length))
                    End If

#If (SHOW_LOG) Then
#End If

                    'logInisialisasi += vbCr & vbLf & "Kromosom " + (j + 1) + " = " + _mataKuliah(_individu(i, j, 0)) + "," + _jam(_individu(i, j, 1)) + "," + _hari(_individu(i, j, 2)) + "," + _individu(i, j, 3)
                Next
            Next
        End Sub
#End Region

        Private Function CekFitness(indv As Integer) As Single
            'float[,] penalty = new float[populasi, 6];
            Dim penalty1 As Single = 0, penalty2 As Single = 0, penalty3 As Single = 0, penalty4 As Single = 0, penalty5 As Single = 0


            For i = 0 To _mataKuliah.Length - 1
                For j = 0 To _mataKuliah.Length - 1
                    '1.bentrok ruang dan waktu dan 3.bentrok dosen
                    'ketika pemasaran matakuliah sama, maka langsung ke perulangan berikutnya
                    If i = j Then
                        Continue For
                    End If

                    '#Region "Bentrok Ruang dan Waktu"
                    'Ketika jam,hari dan ruangnya sama, maka penalty + satu 
                    If (_individu(indv, i, 1) = _individu(indv, j, 1)) AndAlso (_individu(indv, i, 2) = _individu(indv, j, 2)) AndAlso (_individu(indv, i, 3) = _individu(indv, j, 3)) Then
#If (SHOW_LOG) Then
						log += String.Format(vbLf & "HardConstraint[1#A] => Individu ke-{0} ", (indv + 1))
						log += String.Format("Kromosom {0} [{1},{2},{3},{4}] == Kromosom {5} [{6},{7},{8},{9}]", (i + 1), mata_kuliah(individu(indv, i, 0)), jam(individu(indv, i, 1)), hari(individu(indv, i, 2)), individu(indv, i, 3), _
							(j + 1), mata_kuliah(individu(indv, j, 0)), jam(individu(indv, j, 1)), hari(individu(indv, j, 2)), individu(indv, j, 3))
#End If
                        penalty1 += 1
                    End If

                    'Ketika sks lebih dari 1, 
                    'hari dan ruang sama, dan 
                    'jam kedua sama dengan jam pertama matakuliah yang lain, maka penalty + 1
                    If _sks(i) >= 2 Then
                        If (_individu(indv, i, 1) + 1 = _individu(indv, j, 1)) AndAlso (_individu(indv, i, 2) = _individu(indv, j, 2)) AndAlso (_individu(indv, i, 3) = _individu(indv, j, 3)) Then
#If (SHOW_LOG) Then
							log += String.Format(vbLf & "HardConstraint[1#B] => Individu ke-{0} ", (indv + 1))
							log += String.Format("Kromosom {0} [{1},{2},{3},{4}][SKS={10}] == Kromosom {5} [{6},{7},{8},{9}][SKS={11}]", (i + 1), mata_kuliah(individu(indv, i, 0)), jam(individu(indv, i, 1)), hari(individu(indv, i, 2)), individu(indv, i, 3), _
								(j + 1), mata_kuliah(individu(indv, j, 0)), jam(individu(indv, j, 1)), hari(individu(indv, j, 2)), individu(indv, j, 3), sks(1), _
								sks(j))
#End If

                            penalty1 += 1
                        End If
                    End If

                    'Ketika sks lebih dari 2, 
                    'hari dan ruang sama dan 
                    'jam ketiga sama dengan jam pertama matakuliah yang lain, maka penalty + 1
                    If _sks(i) >= 3 Then
                        If (_individu(indv, i, 1) + 2 = _individu(indv, j, 1)) AndAlso (_individu(indv, i, 2) = _individu(indv, j, 2)) AndAlso (_individu(indv, i, 3) = _individu(indv, j, 3)) Then
#If (SHOW_LOG) Then
							log += String.Format(vbLf & "HardConstraint[1#C] => Individu ke-{0} ", (indv + 1))
							log += String.Format("Kromosom {0} [{1},{2},{3},{4}][SKS={10}] == Kromosom {5} [{6},{7},{8},{9}][SKS={11}]", (i + 1), mata_kuliah(individu(indv, i, 0)), jam(individu(indv, i, 1)), hari(individu(indv, i, 2)), individu(indv, i, 3), _
								(j + 1), mata_kuliah(individu(indv, j, 0)), jam(individu(indv, j, 1)), hari(individu(indv, j, 2)), individu(indv, j, 3), sks(1), _
								sks(j))
#End If
                            penalty1 += 1
                        End If
                    End If

                    'Ketika sks lebih dari 3, 
                    'hari dan ruang sama dan 
                    'jam keempat sama dengan jam pertama matakuliah yang lain, maka penalty + 1
                    If _sks(i) >= 4 Then
                        If (_individu(indv, i, 1) + 3 = _individu(indv, j, 1)) AndAlso (_individu(indv, i, 2) = _individu(indv, j, 2)) AndAlso (_individu(indv, i, 3) = _individu(indv, j, 3)) Then
#If (SHOW_LOG) Then
							log += String.Format(vbLf & "HardConstraint[1#D] => Individu ke-{0} ", (indv + 1))
							log += String.Format("Kromosom {0} [{1},{2},{3},{4}][SKS={10}] == Kromosom {5} [{6},{7},{8},{9}][SKS={11}]", (i + 1), mata_kuliah(individu(indv, i, 0)), jam(individu(indv, i, 1)), hari(individu(indv, i, 2)), individu(indv, i, 3), _
								(j + 1), mata_kuliah(individu(indv, j, 0)), jam(individu(indv, j, 1)), hari(individu(indv, j, 2)), individu(indv, j, 3), sks(1), _
								sks(j))
#End If
                            penalty1 += 1
                        End If
                    End If

                    '#End Region
                    '______________________BENTROK DOSEN

                    '#Region "Bentrok Dosen"

                    'ketika jam sama
                    'dan hari sama
                    'dan dosennya sama
                    If _individu(indv, i, 1) = _individu(indv, j, 1) AndAlso _individu(indv, i, 2) = _individu(indv, j, 2) AndAlso _dosen(i) = _dosen(j) Then
                        'maka...
#If (SHOW_LOG) Then
						log += String.Format(vbLf & "HardConstraint[3#A] => Individu ke-{0} ", (indv + 1))
						log += String.Format("Kromosom {0} [{1},{2},{3},{4}][SKS={10}][DOSEN={12}] == Kromosom {5} [{6},{7},{8},{9}][SKS={11}][DOSEN={13}]", (i + 1), mata_kuliah(individu(indv, i, 0)), jam(individu(indv, i, 1)), hari(individu(indv, i, 2)), individu(indv, i, 3), _
							(j + 1), mata_kuliah(individu(indv, j, 0)), jam(individu(indv, j, 1)), hari(individu(indv, j, 2)), individu(indv, j, 3), sks(1), _
							sks(j), dosen(i), dosen(j))
#End If
                        penalty3 += 1
                    End If

                    'jika lebih dari 1 SKS
                    If _sks(i) >= 2 Then
                        'jam ke-2 == dengan jam ke-1 mk yang lain
                        'dan hari sama
                        'dan dosen sama
                        If (_individu(indv, i, 1) + 1) = (_individu(indv, j, 1)) AndAlso (_individu(indv, i, 2)) = (_individu(indv, j, 2)) AndAlso _dosen(i) = _dosen(j) Then
                            'maka...
#If (SHOW_LOG) Then
							log += String.Format(vbLf & "HardConstraint[3#B] => Individu ke-{0} ", (indv + 1))
							log += String.Format("Kromosom {0} [{1},{2},{3},{4}][SKS={10}][DOSEN={12}] == Kromosom {5} [{6},{7},{8},{9}][SKS={11}][DOSEN={13}]", (i + 1), mata_kuliah(individu(indv, i, 0)), jam(individu(indv, i, 1)), hari(individu(indv, i, 2)), individu(indv, i, 3), _
								(j + 1), mata_kuliah(individu(indv, j, 0)), jam(individu(indv, j, 1)), hari(individu(indv, j, 2)), individu(indv, j, 3), sks(1), _
								sks(j), dosen(i), dosen(j))
#End If
                            penalty3 += 1
                        End If
                    End If

                    'jika lebih dari 2 SKS
                    If _sks(i) >= 3 Then
                        'jam ke-3 == dengan jam ke-1 mk yang lain
                        'dan hari sama
                        'dan dosen sama
                        If (_individu(indv, i, 1) + 2) = (_individu(indv, j, 1)) AndAlso (_individu(indv, i, 2)) = (_individu(indv, j, 2)) AndAlso _dosen(i) = _dosen(j) Then
                            'maka...
#If (SHOW_LOG) Then
							log += String.Format(vbLf & "HardConstraint[3#C] => Individu ke-{0} ", (indv + 1))
							log += String.Format("Kromosom {0} [{1},{2},{3},{4}][SKS={10}][DOSEN={12}] == Kromosom {5} [{6},{7},{8},{9}][SKS={11}][DOSEN={13}]", (i + 1), mata_kuliah(individu(indv, i, 0)), jam(individu(indv, i, 1)), hari(individu(indv, i, 2)), individu(indv, i, 3), _
								(j + 1), mata_kuliah(individu(indv, j, 0)), jam(individu(indv, j, 1)), hari(individu(indv, j, 2)), individu(indv, j, 3), sks(1), _
								sks(j), dosen(i), dosen(j))
#End If
                            penalty3 += 1
                        End If
                    End If

                    'jika lebih dari 3 SKS
                    If _sks(i) >= 4 Then
                        'jam ke-4 == dengan jam ke-1 mk yang lain
                        'dan hari sama
                        'dan dosen sama
                        If (_individu(indv, i, 1) + 3) = (_individu(indv, j, 1)) AndAlso (_individu(indv, i, 2)) = (_individu(indv, j, 2)) AndAlso _dosen(i) = _dosen(j) Then
                            'maka...
#If (SHOW_LOG) Then
							log += String.Format(vbLf & "HardConstraint[3#D] => Individu ke-{0} ", (indv + 1))
							log += String.Format("Kromosom {0} [{1},{2},{3},{4}][SKS={10}][DOSEN={12}] == Kromosom {5} [{6},{7},{8},{9}][SKS={11}][DOSEN={13}]", (i + 1), mata_kuliah(individu(indv, i, 0)), jam(individu(indv, i, 1)), hari(individu(indv, i, 2)), individu(indv, i, 3), _
								(j + 1), mata_kuliah(individu(indv, j, 0)), jam(individu(indv, j, 1)), hari(individu(indv, j, 2)), individu(indv, j, 3), sks(1), _
								sks(j), dosen(i), dosen(j))
#End If
                            penalty3 += 1
                        End If
                        '#End Region
                    End If
                Next
                'end 1.bentrok ruang dan waktu dan 3.bentrok dosen
                '#Region "Bentrok sholat Jumat"
                If _individu(indv, i, 2) + 1 = (_kodeJumat) Then
                    '2.bentrok sholat jumat
                    'int x = individu[indv, i, 2];
                    If _sks(i) = (1) Then
                        If _individu(indv, i, 1) = (_rangeJumat(0) - 1) OrElse _individu(indv, i, 1) = (_rangeJumat(1) - 1) OrElse _individu(indv, i, 1) = (_rangeJumat(2) - 1) Then
#If (SHOW_LOG) Then
							log += String.Format(vbLf & "HardConstraint[2#SKS = 1] => Individu ke-{0} ", (indv + 1))
							log += String.Format("Kromosom {0} [{1},{2},{3},{4}]", (i + 1), mata_kuliah(individu(indv, i, 0)), jam(individu(indv, i, 1)), hari(individu(indv, i, 2)), individu(indv, i, 3))
#End If
                            penalty2 += 1
                        End If
                    End If

                    If _sks(i) = (2) Then
                        If _individu(indv, i, 1) = (_rangeJumat(0) - 2) OrElse _individu(indv, i, 1) = (_rangeJumat(0) - 1) OrElse _individu(indv, i, 1) = (_rangeJumat(1) - 1) OrElse _individu(indv, i, 1) = (_rangeJumat(2) - 1) Then
#If (SHOW_LOG) Then
							log += String.Format(vbLf & "HardConstraint[2#SKS = 2] => Individu ke-{0} ", (indv + 1))
							log += String.Format("Kromosom {0} [{1},{2},{3},{4}]", (i + 1), mata_kuliah(individu(indv, i, 0)), jam(individu(indv, i, 1)), hari(individu(indv, i, 2)), individu(indv, i, 3))
#End If
                            penalty2 += 1
                        End If
                    End If

                    If _sks(i) = (3) Then
                        If _individu(indv, i, 1) = (_rangeJumat(0) - 3) OrElse _individu(indv, i, 1) = (_rangeJumat(0) - 2) OrElse _individu(indv, i, 1) = (_rangeJumat(0) - 1) OrElse _individu(indv, i, 1) = (_rangeJumat(1) - 1) OrElse _individu(indv, i, 1) = (_rangeJumat(2) - 1) Then
#If (SHOW_LOG) Then
							log += String.Format(vbLf & "HardConstraint[2#SKS = 3] => Individu ke-{0} ", (indv + 1))
							log += String.Format("Kromosom {0} [{1},{2},{3},{4}]", (i + 1), mata_kuliah(individu(indv, i, 0)), jam(individu(indv, i, 1)), hari(individu(indv, i, 2)), individu(indv, i, 3))
#End If
                            penalty2 += 1
                        End If
                    End If

                    If _sks(i) = (4) Then
                        If _individu(indv, i, 1) = (_rangeJumat(0) - 4) OrElse _individu(indv, i, 1) = (_rangeJumat(0) - 3) OrElse _individu(indv, i, 1) = (_rangeJumat(0) - 2) OrElse _individu(indv, i, 1) = (_rangeJumat(0) - 1) OrElse _individu(indv, i, 1) = (_rangeJumat(1) - 1) OrElse _individu(indv, i, 1) = (_rangeJumat(2) - 1) Then
#If (SHOW_LOG) Then
							log += String.Format(vbLf & "HardConstraint[2#SKS = 4] => Individu ke-{0} ", (indv + 1))
							log += String.Format("Kromosom {0} [{1},{2},{3},{4}]", (i + 1), mata_kuliah(individu(indv, i, 0)), jam(individu(indv, i, 1)), hari(individu(indv, i, 2)), individu(indv, i, 3))
#End If
                            penalty2 += 1
                        End If
                    End If
                End If
                '#End Region

                '#Region "Bentrok dengan Waktu Keinginan Dosen"


                'Boolean penaltyForKeinginanDosen = false;
                For j As Integer = 0 To _iDosen.Length - 1
                    If _dosen(i) = _iDosen(j) Then
                        Dim hariJam As String() = _waktuDosen(j, 1).Split(":"c)

                        If _jam(_individu(indv, i, 1)).ToString(CultureInfo.InvariantCulture) = hariJam(1) AndAlso _hari(_individu(indv, i, 2)).ToString(CultureInfo.InvariantCulture) = hariJam(0) Then
                            'penaltyForKeinginanDosen = true;
#If (SHOW_LOG) Then
							log += String.Format(vbLf & "HardConstraint[4] => Individu ke {0} Kromosom {1}[{2},{3},{4},{5}][Dosen = {6}]", (indv + 1), (i + 1), mata_kuliah(individu(indv, i, 0)), jam(individu(indv, i, 1)), hari(individu(indv, i, 2)), _
								individu(indv, i, 3), iDosen(j))
#End If

                            penalty4 += 1
                        End If
                    End If
                Next

                '#End Region

                '#Region "Bentrok waktu dhuhur"
                If _individu(indv, i, 1) = (_kodeDhuhur - 1) Then
#If (SHOW_LOG) Then
					log += String.Format(vbLf & "HardConstraint[5] => Individu ke {0} Kromosom {1}[{2},{3},{4},{5}][Dosen = {6}]", (indv + 1), (i + 1), mata_kuliah(individu(indv, i, 0)), jam(individu(indv, i, 1)), hari(individu(indv, i, 2)), _
						individu(indv, i, 3), dosen(i))
#End If
                    penalty5 += 1


                    '#End Region
                End If
            Next

#If (SHOW_LOG) Then
			log += String.Format(vbLf & "Penalty Individu ke-{0} : {1} " & vbLf, (indv + 1), penalty1 + penalty2 + penalty3 + penalty4 + penalty5)
#End If


            Dim fitness As Single = 1 / (1 + (penalty1 + penalty2 + penalty3 + penalty4 + penalty5))

            Return fitness
        End Function

#Region "Hitung Fitness"

        Public Function HitungFitness() As Single()
            'hard constraint
            '1.bentrok ruang dan waktu
            '2.bentrok sholat jumat
            '3.bentrok dosen
            '4.bentrok keinginan waktu dosen 
            '5.bentrok waktu dhuhur 
            '=>6.praktikum harus pada ruang lab {telah ditetapkan dari awal perandoman
            '    bahwa jika praktikum harus ada pada LAB dan mata kuliah reguler harus 
            '    pada kelas reguler


            'soft constraint //TODO

            _log = Nothing

            Dim fitness As Single() = New Single(_populasi - 1) {}

#If (SHOW_LOG) Then
			log += vbLf & vbLf & "=========================== HITUNG FITNESS"
			log += vbLf & "Rule:" & vbLf + "Hard Constraint:" & vbLf + "[1] => Bentrok ruang dan Waktu" & vbLf + "[1#A] => jam,hari dan ruangnya sama" & vbLf + "[1#B] => sks lebih dari 1 + hari dan ruang sama + jam kedua sama dengan jam pertama matakuliah yang lain" & vbLf + "[1#C] => sks lebih dari 2 + hari dan ruang sama + jam ketiga sama dengan jam pertama matakuliah yang lain" & vbLf + "[1#D] => sks lebih dari 3 + hari dan ruang sama + jam keempat sama dengan jam pertama matakuliah yang lain" & vbLf + "[2] => Bentrok sholat jumat" & vbLf + "[2#SKS = 1] => sks = 1" & vbLf + "[2#SKS = 2] => sks = 2" & vbLf + "[2#SKS = 3] => sks = 3" & vbLf + "[2#SKS = 4] => sks = 4" & vbLf + "[3] => Bentrok Dosen" & vbLf + "[3#SKS = 1] => sks = 1" & vbLf + "[3#SKS = 2] => sks = 2" & vbLf + "[3#SKS = 3] => sks = 3" & vbLf + "[3#SKS = 4] => sks = 4" & vbLf + "[4] => bentrok keinginan waktu dosen" & vbLf
#End If

            For indv = 0 To _populasi - 1
                'Cek Fitness
                fitness(indv) = CekFitness(indv)
#If (SHOW_LOG) Then
#End If
                _log += String.Format("Fitness Individu ke-{0} : {1} " & vbLf, (indv + 1), fitness(indv))
            Next

            '~~~~~buble sort~~~~~~
            Dim sort As String() = New String(_populasi - 1) {}
            'fill the data
            '

#If (SHOW_LOG) Then
			log += vbLf & "Review Penalty dan Fitness: (Best Fitness => Worst Fitness)"
#End If

            For i As Integer = 0 To _populasi - 1
                sort(i) = String.Format(vbLf & "Individu {0} :Fitness {1}", (i + 1), fitness(i))
            Next

            Try
                Dim swapped As Boolean = True
                While swapped
                    swapped = False
                    For i As Integer = 0 To _populasi - 2
                        Dim strI As String() = sort(i).Split("."c)
                        Dim fitI As Single = Single.Parse(String.Format("0.{0}", strI(1)))

                        Dim strJ As String() = sort(i + 1).Split("."c)
                        Dim fitJ As Single = Single.Parse(String.Format("0.{0}", strJ(1)))

                        If fitI < fitJ Then
                            Dim sTmp As String = sort(i)
                            sort(i) = sort(i + 1)
                            sort(i + 1) = sTmp
                            swapped = True
                        End If
                    Next
                End While
            Catch generatedExceptionName As Exception
                MessageBox.Show("Kemungkinan data tidak ada untuk Tahun Akademik dan Semester yang terpilih!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Throw
            End Try

#If (SHOW_LOG) Then
			For i As var = 0 To populasi - 1
				log += sort(i)
			Next
#End If
            Return fitness
        End Function

#End Region

#Region "Seleksi"
        Public Sub Seleksi(fitness As Single())
            Dim jumlah = 0
            Dim rank As Integer() = New Integer(_populasi - 1) {}
            _induk = New Integer(_populasi - 1) {}

#If (SHOW_LOG) Then
			log += vbLf & vbLf
#End If

            For i = 0 To _populasi - 1
                'proses ranking berdasarkan nilai fitness
                rank(i) = 1
                For j = 0 To _populasi - 1
                    'ketika nilai fitness jadwal sekarang lebih dari nilai fitness jadwal yang lain,
                    'ranking + 1;
                    'if (i == j) continue;
                    If fitness(i) > fitness(j) Then
                        rank(i) += 1
                    End If
                Next
#If (SHOW_LOG) Then
				log += String.Format("Ranking individu {0} = {1}" & vbLf, (i + 1), rank(i))
#End If
                jumlah += rank(i)
            Next
#If (SHOW_LOG) Then
			log += String.Format("[jumlah:{0}] ", jumlah)
#End If
            Dim random = New Random()

#If (SHOW_LOG) Then
			log += vbCr & vbLf & vbLf & "Proses Seleksi:" & vbCr & vbLf + "Induk terpilih: "
#End If

            For i = 0 To _induk.Length - 1
                'proses seleksi berdasarkan ranking yang telah dibuat
                'int nexRandom = random.Next(1, jumlah);
                'random = new Random(nexRandom);
                Dim target = random.[Next](jumlah)
                Dim cek = 0
                For j = 0 To rank.Length - 1
                    cek += rank(j)
                    If cek >= target Then
                        _induk(i) = j
#If (SHOW_LOG) Then
						log += String.Format("Individu {0} , ", (j + 1))
#End If
                        Exit For
                    End If
                Next
            Next
        End Sub
#End Region

        Public Sub StartCrossOver()
#If (SHOW_LOG) Then
			log += String.Format(vbCr & vbLf & vbCr & vbLf & "===========================PROSES CROSSOVER / PINDAH SILANG (CrossOver values = {0})", crossOver)
#End If

            Dim individu_baru As Integer(,,) = New Integer(_populasi - 1, _mataKuliah.Length - 1, 3) {}

            Dim random = New Random()

            For i As Integer = 0 To _populasi - 1 Step 2
                'perulangan untuk jadwal yang terpilih
                Dim b As Integer = 0
                Dim nexRandom As Integer = random.[Next](1, 1000)
                random = New Random(nexRandom)
                Dim cr As Double = random.NextDouble()

                If cr < _crossOver Then
                    'ketika nilai random kurang dari nilai probabilitas pertukaran
                    'maka jadwal mengalami prtukaran

                    Dim a As Integer = random.[Next](_mataKuliah.Length - 1)
                    While b <= a
                        b = random.[Next](_mataKuliah.Length)
                    End While

                    'penentuan jadwal baru dari awal sampai titik pertama
                    For j As Integer = 0 To a - 1
                        For k As Integer = 0 To 3
                            individu_baru(i, j, k) = _individu(_induk(i), j, k)
                            individu_baru(i + 1, j, k) = _individu(_induk(i + 1), j, k)
                        Next
                    Next

                    'Penentuan jadwal baru dai titik pertama sampai titik kedua
                    For j As Integer = a To b - 1
                        For k As Integer = 0 To 3
                            individu_baru(i, j, k) = _individu(_induk(i + 1), j, k)
                            individu_baru(i + 1, j, k) = _individu(_induk(i), j, k)
                        Next
                    Next

                    'penentuan jadwal baru dari titik kedua sampai akhir
                    For j As Integer = b To _mataKuliah.Length - 1
                        For k As Integer = 0 To 3
                            individu_baru(i, j, k) = _individu(_induk(i), j, k)
                            individu_baru(i + 1, j, k) = _individu(_induk(i + 1), j, k)
                        Next
                    Next
#If (SHOW_LOG) Then
#End If
                    _log += String.Format(vbCr & vbLf & "Nilai Random = {0}, maka CrossOver terjadi antara induk {1} dengan induk {2} pada titik {3} dan titik {4}", cr, (i + 1), (i + 2), (a + 1), (b + 1))
                Else
                    'Ketika nilai random lebih dari nilai probabilitas pertukaran, maka jadwal baru sama dengan jadwal terpilih
                    For j As Integer = 0 To _mataKuliah.Length - 1
                        For k As Integer = 0 To 3
                            individu_baru(i, j, k) = _individu(_induk(i), j, k)
                            individu_baru(i + 1, j, k) = _individu(_induk(i + 1), j, k)
                        Next
                    Next
#If (SHOW_LOG) Then
#End If
                    _log += String.Format(vbCr & vbLf & "Nilai random = {0}, maka CrossOver TIDAK TERJADI antara induk {1} dengan induk {2}", cr, (i + 1), (i + 2))
                End If
            Next

            'tampilkan individu baru
#If (SHOW_LOG) Then
			For i As Integer = 0 To populasi - 1

				log += String.Format(vbCr & vbLf & vbLf & "[{0}] => Individu Baru Ke-{1} #MK,JAM,HARI,RUANG", DateTime.Now.ToString("HH:mm:ss.fff tt"), (i + 1))

				For j As Integer = 0 To mata_kuliah.Length - 1
					log += vbCr & vbLf & "Kromosom " + (j + 1) + " = " + mata_kuliah(individu_baru(i, j, 0)) + "," + jam(individu_baru(i, j, 1)) + "," + hari(individu_baru(i, j, 2)) + "," + individu_baru(i, j, 3)

				Next
			Next
#End If

            _individu = New Integer(_populasi - 1, _mataKuliah.Length - 1, 3) {}
            Array.Copy(individu_baru, _individu, individu_baru.Length)
        End Sub


        Public Function Mutasi() As Single()
            Dim fitness As Single() = New Single(_populasi - 1) {}

#If (SHOW_LOG) Then
			log += vbCr & vbLf & vbCr & "===========================PROSES MUTASI / PENGGANTIAN KOMPONEN PENJADWALAN SECARA ACAK:" & vbLf
#End If


            Dim random = New Random()
            'proses perandoman atau penggantian komponen untuk tiap jadwal baru
            For i As Integer = 0 To _populasi - 1
                Dim nexRandom As Integer = random.[Next](1, 1000)
                random = New Random(nexRandom)
                Dim r As Double = random.NextDouble()
                Dim msg As String
                'System.Threading.Thread.Sleep(20);
#If (SHOW_LOG) Then
				msg = "TIDAK terjadi mutasi"
#End If
                'Ketika nilai random kurang dari nilai probalitas Mutasi, 
                'maka terjadi penggantian komponen
                If r < _mutasi Then
                    'Penentuan pada matakuliah dan kelas yang mana yang akan dirandomkan atau diganti
                    Dim krom As Integer = random.[Next](_mataKuliah.Length)

                    Select Case _sks(krom)
                        Case 1
                            _individu(i, krom, 1) = random.[Next](_jam.Length)
                            Exit Select
                        Case 2
                            _individu(i, krom, 1) = random.[Next](_jam.Length - 1)
                            Exit Select
                        Case 3
                            _individu(i, krom, 1) = random.[Next](_jam.Length - 2)
                            Exit Select
                        Case 4
                            _individu(i, krom, 1) = random.[Next](_jam.Length - 3)
                            Exit Select
                    End Select
                    'Proses penggantian hari
                    _individu(i, krom, 2) = random.[Next](_hari.Length)

                    'proses penggantian ruang
                    'individu[i, krom, 3] = random.Next(ruang.Length);

                    If _jenisMk(krom) = TEORI Then
                        _individu(i, krom, 3) = _ruangReguler(random.[Next](_ruangReguler.Length))
                    Else
                        _individu(i, krom, 3) = _ruangLaboratorium(random.[Next](_ruangLaboratorium.Length))
                    End If

#If (SHOW_LOG) Then
#End If
                    msg = String.Format("terjadi mutasi, pada kromosom ke {0}", (krom + 1))
                End If
                fitness(i) = CekFitness(i)


#If (SHOW_LOG) Then
#End If
                ' _log += String.Format("Individu {0}: Nilai Random = {1}, maka {2} (Fitness = {3})" & vbLf & vbLf, (i + 1), r, msg, fitness(i))
            Next
            Return fitness
        End Function


        Public Function GetIndividu(indv As Integer) As Integer(,)
            'return individu;

            Dim individu_solusi As Integer(,) = New Integer(_mataKuliah.Length - 1, 3) {}

            For j As Integer = 0 To _mataKuliah.Length - 1
                individu_solusi(j, 0) = _mataKuliah(_individu(indv, j, 0))
                individu_solusi(j, 1) = _jam(_individu(indv, j, 1))
                individu_solusi(j, 2) = _hari(_individu(indv, j, 2))

                individu_solusi(j, 3) = _individu(indv, j, 3)
            Next

            Return individu_solusi
        End Function

    End Class
End Namespace
