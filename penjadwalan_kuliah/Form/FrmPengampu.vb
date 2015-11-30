Option Infer On
Imports penjadwalan.Classes

Namespace Form
    Public Class FrmPengampu

        Private Const GENAP As Integer = 0
        Private Const GANJIL As Integer = 1

        Private ReadOnly _dbConnect As New ClassDbConnect()
        Private _selectedkode As Integer = -1

        Public Sub New()
            InitializeComponent()
        End Sub


        Private Sub LoadData(ByVal tipe As Integer)
            'kode,kode_mk,nama mk,kode dosen,nama dosen,kelas,tahun akademik

            ClassHelper.ClearTextBox(Me)

            Dim dataTable = _dbConnect.GetRecord(String.Format("SELECT a.kode as Kode," &
                                                               "       b.kode as `Kode MK`," &
                                                               "       b.nama as `Nama MK`," &
                                                               "       c.kode as `Kode Dosen`," &
                                                               "       c.nama as  `Nama Dosen`," &
                                                               "       a.kelas as Kelas," &
                                                               "       a.tahun_akademik as `Tahun Akademik` " &
                                                               "FROM pengampu a " &
                                                               "LEFT JOIN mata_kuliah b ON a.kode_mk = b.kode " &
                                                               "LEFT JOIN dosen c ON a.kode_dosen = c.kode " &
                                                               "WHERE b.semester%2={0} AND a.tahun_akademik = '{1}' " &
                                                               "ORDER BY b.nama,a.kelas", tipe, cmbTahunAkademik.Text))

            dtGridView.DataSource = dataTable
            If (dtGridView.Columns.Count > 0) Then
                dtGridView.Columns(0).Visible = False 'kode
                dtGridView.Columns(1).Visible = False 'kode MK
                dtGridView.Columns(3).Visible = False 'kode dosen
            End If
            
            'load dosen
            'cbDosen.Items.Clear();
            Dim dosen_dt = _dbConnect.GetRecord("SELECT kode,nama  " &
                                                "FROM dosen " &
                                                "ORDER BY nama")

            cmbDosen.DataSource = dosen_dt
            cmbDosen.DisplayMember = "nama"
            cmbDosen.ValueMember = "kode"

            'load mata kuliah
            'cbMataKuliah.Items.Clear();
            Dim mk_dt = _dbConnect.GetRecord(String.Format("SELECT * " &
                                                           "FROM mata_kuliah " &
                                                           "WHERE semester%2={0} " &
                                                           "ORDER BY nama", tipe))

            cmbMataKuliah.DataSource = mk_dt
            cmbMataKuliah.DisplayMember = "nama"
            cmbMataKuliah.ValueMember = "kode"
        End Sub

        Private Sub SetEnabledOnBtn(ByVal btnNewEnable As Boolean, ByVal btnCancelEnable As Boolean, ByVal btnSaveEnable As Boolean)
            btnBaru.Enabled = btnNewEnable
            btnBatal.Enabled = btnCancelEnable
            cmbSemester.Enabled = btnSaveEnable
            cmbTahunAkademik.Enabled = cmbSemester.Enabled
            cmbMataKuliah.Enabled = cmbTahunAkademik.Enabled
            cmbDosen.Enabled = cmbMataKuliah.Enabled
            btnSimpan.Enabled = cmbDosen.Enabled

            ClassHelper.SetReadOnlyOnTextBox(Me, btnNewEnable)
        End Sub

        Private Sub FrmPengampu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadData(If(cmbSemester.Text = "GANJIL", GANJIL, GENAP))
            SetEnabledOnBtn(True, False, False)
        End Sub

        Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
            'pengampu
            'kode,kode_mk,kode_dosen,kelas,tahun_akademik

            If txtKelas.Text.Trim() = "" Then
                MessageBox.Show("Data belum lengkap")
                Return
            End If

            Dim rowDosen = CType(cmbDosen.DataSource, DataTable).Rows(cmbDosen.SelectedIndex)
            Dim kodeDosen = CInt(Fix(rowDosen("kode")))

            Dim rowMK = CType(cmbMataKuliah.DataSource, DataTable).Rows(cmbMataKuliah.SelectedIndex)
            Dim kodeMK = CInt(Fix(rowMK("kode")))

            If _selectedkode <> -1 Then

                Dim check = String.Format("SELECT CAST(COUNT(*) AS CHAR(1)) " & "FROM pengampu " & "WHERE kode_mk='{0}' AND " & "      kode_dosen={1} AND " & "      kelas = '{2}' AND " & "      tahun_akademik='{3}' " & "      AND kode <> {4}", kodeMK, kodeDosen, txtKelas.Text, cmbTahunAkademik.Text, _selectedkode)

                Dim i = Integer.Parse(_dbConnect.ExecuteScalar(check))

                If i <> 0 Then
                    MessageBox.Show("Data ini sudah ada!")
                    Return
                End If

                Dim q = String.Format("UPDATE pengampu " & "SET kode_mk = {0}," & "    kode_dosen = {1}, " & "    kelas = '{2}', " & "    tahun_akademik = '{3}' " & "WHERE kode = {4}", kodeMK, kodeDosen, txtKelas.Text, cmbTahunAkademik.Text, _selectedkode)
                _dbConnect.ExecuteNonQuery(q)

            Else
                Dim check = String.Format("SELECT CAST(COUNT(*) AS CHAR(1)) " & "FROM pengampu " & "WHERE kode_mk='{0}' AND " & "      kode_dosen={1} AND " & "      kelas = '{2}' AND " & "      tahun_akademik='{3}'", kodeMK, kodeDosen, txtKelas.Text, cmbTahunAkademik.Text)
                Dim i = Integer.Parse(_dbConnect.ExecuteScalar(check))

                If i <> 0 Then
                    MessageBox.Show("Data ini sudah ada!")
                    Return
                End If


                Dim q = String.Format("INSERT INTO pengampu(kode_mk,kode_dosen,kelas,tahun_akademik) " & "VALUES({0},{1},'{2}','{3}')", kodeMK, kodeDosen, txtKelas.Text, cmbTahunAkademik.Text)
                _dbConnect.ExecuteNonQuery(q)
            End If

            _selectedkode = -1 'set to "-1" agar disign sebagai databaru

            ClassHelper.ClearTextBox(Me)
            SetEnabledOnBtn(True, False, False)
            LoadData(If(cmbSemester.Text = "GANJIL", GANJIL, GENAP))

        End Sub

        Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
            ClassHelper.ClearTextBox(Me)
            SetEnabledOnBtn(False, True, True)
            _selectedkode = -1

        End Sub

        Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
            ClassHelper.ClearTextBox(Me)
            SetEnabledOnBtn(True, False, False)

        End Sub

        Private Sub dtGridView_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dtGridView.UserDeletingRow
            If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) <> System.Windows.Forms.DialogResult.Yes Then
                Return
            End If
            If dtGridView.SelectedRows.Count <= 0 Then
                Return
            End If

            Dim kode = Integer.Parse(dtGridView(0, dtGridView.SelectedRows(0).Index).Value.ToString())
            Dim q = String.Format("DELETE FROM pengampu where kode = ({0})", kode)
            _dbConnect.ExecuteNonQuery(q)

        End Sub

        Private Sub dtGridView_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dtGridView.UserDeletedRow
            LoadData(If(cmbSemester.Text = "GANJIL", GANJIL, GENAP))

        End Sub

        Private Sub dtGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridView.CellClick
            SetEnabledOnBtn(False, True, True)

            'kode,kode_mk,nama mk,kode dosen,nama dosen,kelas,tahun akademik
            _selectedkode = Integer.Parse(dtGridView(0, dtGridView.SelectedRows(0).Index).Value.ToString())
            cmbMataKuliah.Text = dtGridView(2, dtGridView.SelectedRows(0).Index).Value.ToString()
            cmbDosen.Text = dtGridView(4, dtGridView.SelectedRows(0).Index).Value.ToString()
            txtKelas.Text = dtGridView(5, dtGridView.SelectedRows(0).Index).Value.ToString()
            cmbTahunAkademik.Text = dtGridView(6, dtGridView.SelectedRows(0).Index).Value.ToString()

        End Sub

        Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
            Close()

        End Sub

        Private Sub cmbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemester.SelectedIndexChanged
            'MessageBox.Show(cmbSemester.Text)
            If (cmbSemester.Text.Length > 0) Then
                LoadData(If(cmbSemester.Text = "GANJIL", GANJIL, GENAP))
            End If


        End Sub

        Private Sub cmbTahunAkademik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTahunAkademik.SelectedIndexChanged
            If (cmbSemester.Text.Length > 0) Then
                LoadData(If(cmbSemester.Text = "GANJIL", GANJIL, GENAP))
            End If
        End Sub
    End Class
End Namespace