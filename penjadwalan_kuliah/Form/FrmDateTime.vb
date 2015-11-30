Imports penjadwalan.Classes

Namespace Form

    Public Class FrmDateTime

        Private Const HARI As Integer = 0
        Private Const JAM As Integer = 1
        Private Const SEMUA As Integer = 2
        Private ReadOnly _dbConnect As New ClassDbConnect()
        Private _selectedkodeHr As Integer = -1
        Private _selectedkodeJm As Integer = -1

        Private Sub ClearTxt(ByVal tipe As Integer)
            If tipe = HARI Then
                txtKodeHari.Clear()
                txtNamaHari.Clear()
            Else
                txtKodeJam.Clear()
                txtRangeJam.Clear()
            End If
        End Sub

        Private Sub LoadData(ByVal tipe As Integer)
            'hari:kode,nama
            'jam:kode,range
            'ClassHelper.ClearTextBox(this);

            If tipe <> HARI Then
                ClearTxt(JAM)
                Dim dttblJam = _dbConnect.GetRecord("SELECT * FROM jam")
                dtGridViewJam.DataSource = dttblJam
                dtGridViewJam.Columns(2).Visible = False
            Else
                ClearTxt(HARI)
                Dim dttblHari = _dbConnect.GetRecord("SELECT kode,nama as Hari,aktif " & "FROM hari")
                dtGridViewHari.DataSource = dttblHari
                dtGridViewHari.Columns(2).Visible = False
            End If
        End Sub

        Private Sub SetEnabledOnBtn(ByVal tipe As Integer, ByVal btnNewEnable As Boolean, ByVal btnCancelEnable As Boolean, ByVal btnSaveEnable As Boolean)
            Select Case tipe
                Case HARI
                    txtNamaHari.ReadOnly = btnNewEnable
                    txtKodeHari.ReadOnly = txtNamaHari.ReadOnly
                    btnBaruHari.Enabled = txtKodeHari.ReadOnly

                    btnBatalHari.Enabled = btnCancelEnable
                    btnSimpanHari.Enabled = btnSaveEnable
                    cbAktif.Enabled = btnSaveEnable
                Case JAM
                    txtRangeJam.ReadOnly = btnNewEnable
                    txtKodeJam.ReadOnly = txtRangeJam.ReadOnly
                    btnBaruJam.Enabled = txtKodeJam.ReadOnly

                    btnBatalJam.Enabled = btnCancelEnable
                    btnSimpanJam.Enabled = btnSaveEnable
                Case Else
                    btnBaruHari.Enabled = btnNewEnable
                    btnBatalJam.Enabled = btnCancelEnable
                    btnBatalHari.Enabled = btnBatalJam.Enabled
                    btnSimpanJam.Enabled = btnSaveEnable
                    btnSimpanHari.Enabled = btnSimpanJam.Enabled
                    cbAktif.Enabled = btnSaveEnable

                    txtRangeJam.ReadOnly = btnNewEnable
                    txtKodeJam.ReadOnly = txtRangeJam.ReadOnly
                    btnBaruJam.Enabled = txtKodeJam.ReadOnly
                    txtNamaHari.ReadOnly = btnBaruJam.Enabled
                    txtKodeHari.ReadOnly = txtNamaHari.ReadOnly
            End Select
        End Sub

        Private Sub FrmDateTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadData(HARI)
            LoadData(JAM)
            SetEnabledOnBtn(SEMUA, True, False, False)

        End Sub

        Private Sub btnBaruHari_Click(sender As Object, e As EventArgs) Handles btnBaruHari.Click
            ClearTxt(HARI)
            SetEnabledOnBtn(HARI, False, True, True)
            _selectedkodeHr = -1

        End Sub

        Private Sub btnBaruJam_Click(sender As Object, e As EventArgs) Handles btnBaruJam.Click
            ClearTxt(JAM)
            SetEnabledOnBtn(JAM, False, True, True)
            _selectedkodeJm = -1

        End Sub

        Private Sub btnSimpanHari_Click(sender As Object, e As EventArgs) Handles btnSimpanHari.Click
            If txtKodeHari.Text.Trim() = "" OrElse txtNamaHari.Text.Trim() = "" Then
                MessageBox.Show("Data Belum Lengkap!")
                Return
            End If

            Const _aktif As String = "True" 'cbAktif.Checked ? "True" : "False";

            If _selectedkodeHr <> -1 Then
                'update data

                Dim check = String.Format("SELECT CAST(COUNT(*) AS CHAR(1)) " & "FROM hari " & "WHERE (kode='{0}' OR nama='{1}') AND kode <> {2}", txtKodeHari.Text, txtNamaHari.Text, _selectedkodeHr)
                Dim i = Integer.Parse(_dbConnect.ExecuteScalar(check))

                If i <> 0 Then
                    MessageBox.Show("Kode Atau Nama ini sudah ada!")
                    Return
                End If

                Dim q As String = String.Format("UPDATE hari " & "SET kode = {0}, " & "    nama = '{1}'," & "    aktif = '{2}' " & "WHERE kode = {3}", txtKodeHari.Text, txtNamaHari.Text, _aktif, _selectedkodeHr)
                _dbConnect.ExecuteNonQuery(q)

                'update waktu_tidak_bersedia
                Dim q_1 As String = String.Format("UPDATE waktu_tidak_bersedia " & "SET kode_hari = {0} " & "WHERE kode_hari = {1}", txtKodeHari.Text, _selectedkodeHr)
                _dbConnect.ExecuteNonQuery(q_1)

            Else
                'new data

                Dim check = String.Format("SELECT CAST(COUNT(*) AS CHAR(1)) " & "FROM hari " & "WHERE kode='{0}' OR nama='{1}'", txtKodeHari.Text, txtNamaHari.Text)
                Dim i = Integer.Parse(_dbConnect.ExecuteScalar(check))

                If i <> 0 Then
                    MessageBox.Show("Kode Atau Nama ini sudah ada!")
                    Return
                End If

                Dim q As String = String.Format("INSERT INTO hari(kode,nama,aktif) " & "VALUES({0},'{1}','{2}')", txtKodeHari.Text, txtNamaHari.Text, _aktif)
                _dbConnect.ExecuteNonQuery(q)
            End If

            _selectedkodeHr = -1 'set to "-1" agar disign sebagai databaru

            'ClassHelper.ClearTextBox(this);
            txtKodeHari.Clear()
            txtNamaHari.Clear()
            SetEnabledOnBtn(HARI, True, False, False)
            LoadData(HARI)

        End Sub

        Private Sub btnSimpanJam_Click(sender As Object, e As EventArgs) Handles btnSimpanJam.Click
            If txtKodeJam.Text.Trim() = "" Then
                MessageBox.Show("Data belum lengkap")
                Return
            End If

            If _selectedkodeJm <> -1 Then
                'update data
                Dim check = String.Format("SELECT CAST(COUNT(*) AS CHAR(1)) " & "FROM jam " & "WHERE kode={0} AND kode <> {1}", Integer.Parse(txtKodeJam.Text), _selectedkodeJm)
                Dim i = Integer.Parse(_dbConnect.ExecuteScalar(check))

                If i <> 0 Then
                    MessageBox.Show("Kode ini sudah ada!")
                    Return
                End If

                'update jam 
                Dim q As String = String.Format("UPDATE jam " & "SET kode = {0}, " & "    range_jam = '{1}' " & "WHERE kode = {2}", txtKodeJam.Text, txtRangeJam.Text, _selectedkodeJm)
                _dbConnect.ExecuteNonQuery(q)

                'update waktu_tidak_bersedia
                Dim q_1 As String = String.Format("UPDATE waktu_tidak_bersedia " & "SET kode_jam = {0} " & "WHERE kode_jam = {1}", txtKodeJam.Text, _selectedkodeJm)
                _dbConnect.ExecuteNonQuery(q_1)


            Else
                'new data
                Dim check = String.Format("SELECT CAST(COUNT(*) AS CHAR(1)) " & "FROM jam " & "WHERE kode={0}", Integer.Parse(txtKodeJam.Text))
                Dim i = Integer.Parse(_dbConnect.ExecuteScalar(check))

                If i <> 0 Then
                    MessageBox.Show("Kode ini sudah ada!")
                    Return
                End If

                Dim q As String = String.Format("INSERT INTO jam(kode,range_jam) " & "VALUES({0},'{1}')", txtKodeJam.Text, txtRangeJam.Text)
                _dbConnect.ExecuteNonQuery(q)
            End If

            _selectedkodeJm = -1 'set to "-1" agar disign sebagai databaru

            'ClassHelper.ClearTextBox(this);
            txtKodeJam.Clear()
            txtRangeJam.Clear()
            SetEnabledOnBtn(JAM, True, False, False)
            LoadData(JAM)

        End Sub

        Private Sub dtGridViewHari_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dtGridViewHari.UserDeletingRow
            If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) <> System.Windows.Forms.DialogResult.Yes Then
                Return
            End If
            If dtGridViewHari.SelectedRows.Count <= 0 Then
                Return
            End If

            Dim kode As String = dtGridViewHari(0, dtGridViewHari.SelectedRows(0).Index).Value.ToString()
            Dim q As String = String.Format("DELETE FROM hari WHERE kode = ('{0}')", kode)
            _dbConnect.ExecuteNonQuery(q)

        End Sub

        Private Sub dtGridViewJam_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dtGridViewJam.UserDeletingRow
            If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) <> System.Windows.Forms.DialogResult.Yes Then
                Return
            End If
            If dtGridViewJam.SelectedRows.Count <= 0 Then
                Return
            End If

            Dim kode As String = dtGridViewJam(0, dtGridViewJam.SelectedRows(0).Index).Value.ToString()
            Dim q As String = String.Format("DELETE FROM jam WHERE kode = ('{0}')", kode)
            _dbConnect.ExecuteNonQuery(q)

        End Sub

        Private Sub dtGridViewHari_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dtGridViewHari.UserDeletedRow
            LoadData(HARI)

        End Sub

        Private Sub dtGridViewJam_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dtGridViewJam.UserDeletedRow
            LoadData(JAM)

        End Sub

        Private Sub btnBatalHari_Click(sender As Object, e As EventArgs) Handles btnBatalHari.Click
            ClearTxt(HARI)
            SetEnabledOnBtn(HARI, True, False, False)

        End Sub

        Private Sub btnBatalJam_Click(sender As Object, e As EventArgs) Handles btnBatalJam.Click
            ClearTxt(JAM)
            SetEnabledOnBtn(JAM, True, False, False)

        End Sub

        Private Sub dtGridViewHari_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridViewHari.CellClick
            cbAktif.Checked = False

            SetEnabledOnBtn(HARI, False, True, True)
            _selectedkodeHr = Integer.Parse(dtGridViewHari(0, dtGridViewHari.SelectedRows(0).Index).Value.ToString())
            txtKodeHari.Text = dtGridViewHari(0, dtGridViewHari.SelectedRows(0).Index).Value.ToString()
            txtNamaHari.Text = dtGridViewHari(1, dtGridViewHari.SelectedRows(0).Index).Value.ToString()

            Dim _aktif = dtGridViewHari(2, dtGridViewHari.SelectedRows(0).Index).Value.ToString()
            If _aktif = "True" Then
                cbAktif.Checked = True
            End If

        End Sub

        Private Sub dtGridViewJam_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridViewJam.CellClick
            SetEnabledOnBtn(JAM, False, True, True)
            _selectedkodeJm = Integer.Parse(dtGridViewJam(0, dtGridViewJam.SelectedRows(0).Index).Value.ToString())
            txtKodeJam.Text = dtGridViewJam(0, dtGridViewJam.SelectedRows(0).Index).Value.ToString()
            txtRangeJam.Text = dtGridViewJam(1, dtGridViewJam.SelectedRows(0).Index).Value.ToString()
        End Sub

        Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
            Close()
        End Sub
    End Class
End Namespace