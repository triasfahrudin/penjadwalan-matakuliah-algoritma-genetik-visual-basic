Imports penjadwalan.Classes

Namespace Form
    Public Class FrmDosen

        Private ReadOnly _dbConnect As New ClassDbConnect()
        Private _selectedkode As Integer = -1

        Private Sub LoadData()
            ClassHelper.ClearTextBox(Me)
            Dim dataTable = _dbConnect.GetRecord("SELECT kode," & "       nidn as NIDN," & "       nama as Nama," & "       alamat as Alamat," & "       telp as Telp " & "FROM dosen " & "ORDER BY kode")
            dtGridView.DataSource = dataTable
            'dtGridView.Columns[0].Visible = false;
        End Sub

        Private Sub SetEnabledOnBtn(ByVal btnNewEnable As Boolean, ByVal btnCancelEnable As Boolean, ByVal btnSaveEnable As Boolean)
            btnBaru.Enabled = btnNewEnable
            btnBatal.Enabled = btnCancelEnable
            btnSimpan.Enabled = btnSaveEnable
            ClassHelper.SetReadOnlyOnTextBox(Me, btnNewEnable)
        End Sub

        Private Sub FrmDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadData()
            SetEnabledOnBtn(True, False, False)

        End Sub

        Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
            'kode,nip,nama,alamat,telp

            If txtKode.Text.Trim() = "" OrElse txtNIDN.Text.Trim() = "" OrElse txtNama.Text.Trim() = "" Then
                MessageBox.Show("Data Belum Lengkap!")
                Return
            End If


            If _selectedkode <> -1 Then

                Dim check = String.Format("SELECT CAST(COUNT(*) AS CHAR(1)) " & "FROM dosen " & "WHERE (kode={0} OR nidn='{1}') AND kode <> {2}", Integer.Parse(txtKode.Text), txtNama.Text, _selectedkode)
                Dim i = Integer.Parse(_dbConnect.ExecuteScalar(check))

                If i <> 0 Then
                    MessageBox.Show("Kode Atau NIDN ini sudah ada!")
                    Return
                End If

                Dim q = String.Format("UPDATE dosen " & "SET kode = {0}," & "    nidn = '{1}', " & "    nama = '{2}', " & "    alamat = '{3}', " & "    telp = '{4}' " & "WHERE kode = {5}", txtKode.Text, txtNIDN.Text, txtNama.Text, txtAlamat.Text, txtTelp.Text, _selectedkode)
                _dbConnect.ExecuteNonQuery(q)


                'update waktu_tidak_bersedia
                Dim q_1 As String = String.Format("UPDATE waktu_tidak_bersedia " & "SET kode_dosen = {0} " & "WHERE kode_dosen = {1}", txtKode.Text, _selectedkode)
                _dbConnect.ExecuteNonQuery(q_1)

            Else

                Dim check = String.Format("SELECT CAST(COUNT(*) AS CHAR(1)) " & "FROM dosen " & "WHERE kode={0} OR nidn='{1}'", Integer.Parse(txtKode.Text), txtNIDN.Text)
                Dim i = Integer.Parse(_dbConnect.ExecuteScalar(check))

                If i <> 0 Then
                    MessageBox.Show("Kode Atau NIDN ini sudah ada!")
                    Return
                End If

                Dim q = String.Format("INSERT INTO dosen(kode,nidn,nama,alamat,telp) " & "VALUES({0},'{1}','{2}','{3}','{4}')", txtKode.Text, txtNIDN.Text, txtNama.Text, txtAlamat.Text, txtTelp.Text)
                _dbConnect.ExecuteNonQuery(q)
            End If

            _selectedkode = -1 'set to "-1" agar disign sebagai databaru

            ClassHelper.ClearTextBox(Me)
            SetEnabledOnBtn(True, False, False)
            LoadData()

        End Sub

        Private Sub dtGridView_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dtGridView.UserDeletingRow
            If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) <> System.Windows.Forms.DialogResult.Yes Then
                Return
            End If
            If dtGridView.SelectedRows.Count <= 0 Then
                Return
            End If

            Dim kode = dtGridView(0, dtGridView.SelectedRows(0).Index).Value.ToString()
            'delete dosen
            Dim q = String.Format("DELETE FROM dosen WHERE kode = ('{0}')", kode)
            _dbConnect.ExecuteNonQuery(q)

            'delete pengampu
            Dim q_1 = String.Format("DELETE FROM pengampu WHERE kode_dosen = ('{0}')", kode)
            _dbConnect.ExecuteNonQuery(q_1)

        End Sub

        Private Sub dtGridView_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dtGridView.UserDeletedRow
            LoadData()

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

        Private Sub dtGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridView.CellClick
            SetEnabledOnBtn(False, True, True)

            _selectedkode = Integer.Parse(dtGridView(0, dtGridView.SelectedRows(0).Index).Value.ToString())
            txtKode.Text = dtGridView(0, dtGridView.SelectedRows(0).Index).Value.ToString()
            txtNIDN.Text = dtGridView(1, dtGridView.SelectedRows(0).Index).Value.ToString()
            txtNama.Text = dtGridView(2, dtGridView.SelectedRows(0).Index).Value.ToString()
            txtAlamat.Text = dtGridView(3, dtGridView.SelectedRows(0).Index).Value.ToString()
            txtTelp.Text = dtGridView(4, dtGridView.SelectedRows(0).Index).Value.ToString()

        End Sub

        Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
            Close()

        End Sub
    End Class
End Namespace