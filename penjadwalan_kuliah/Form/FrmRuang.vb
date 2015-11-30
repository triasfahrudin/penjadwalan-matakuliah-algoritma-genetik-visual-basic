Imports penjadwalan.Classes

Namespace Form

    Public Class FrmRuang

        'ruang:kode,nama,kapasitas,jenis
        Private ReadOnly _dbConnect As New ClassDbConnect()
        Private _selectedkode As Integer = -1

        Private Sub CreateDtGridViewColumn()
            Dim dgvKode = New DataGridViewTextBoxColumn With {.HeaderText = "Kode", .Name = "dgvKode"}
            dtGridView.Columns.Add(dgvKode)

            Dim dgvNama = New DataGridViewTextBoxColumn With {.HeaderText = "Nama", .Name = "dgvNama"}
            dtGridView.Columns.Add(dgvNama)

            Dim dgvKapasitas = New DataGridViewTextBoxColumn With {.HeaderText = "SKS", .Name = "dgvSKS"}
            dtGridView.Columns.Add(dgvKapasitas)

            Dim dgvJenis = New DataGridViewComboBoxColumn With {.HeaderText = "Jenis", .Name = "dgvJenis"}
            dgvJenis.Items.Add("TEORI")
            dgvJenis.Items.Add("LABORATORIUM")
            dtGridView.Columns.Add(dgvJenis)

        End Sub

        Private Sub LoadData()
            dtGridView.Rows.Clear()

            ClassHelper.ClearTextBox(Me)
            Dim dt = _dbConnect.GetRecord("SELECT * FROM ruang")


            For count = 0 To dt.Rows.Count - 1
                dtGridView.Rows.Add(dt.Rows(count)(0).ToString(), dt.Rows(count)(1).ToString(), dt.Rows(count)(2).ToString(), dt.Rows(count)(3).ToString()) 'Jenis - Kapasitas - Nama - kode
            Next count

            dtGridView.Columns(0).Visible = False
        End Sub

        Private Sub SetEnabledOnBtn(ByVal btnNewEnable As Boolean, ByVal btnCancelEnable As Boolean, ByVal btnSaveEnable As Boolean)
            btnBaru.Enabled = btnNewEnable
            btnBatal.Enabled = btnCancelEnable
            cmbJenis.Enabled = btnSaveEnable
            btnSimpan.Enabled = cmbJenis.Enabled

            ClassHelper.SetReadOnlyOnTextBox(Me, btnNewEnable)
        End Sub

        Private Sub FrmRuang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CreateDtGridViewColumn()
            LoadData()
            SetEnabledOnBtn(True, False, False)
        End Sub

        Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
            'ruang:kode,nama,kapasitas,jenis

            If txtNama.Text.Trim() = "" OrElse txtKapasitas.Text.Trim() = "" Then
                MessageBox.Show("Data Belum Lengkap!")
                Return
            End If

            Dim _kapasitas = Integer.Parse(txtKapasitas.Text)



            If _selectedkode <> -1 Then

                Dim check = String.Format("SELECT CAST(COUNT(*) AS CHAR(1)) " & "FROM ruang " & "WHERE nama='{0}' AND kode <> {1}", txtNama.Text, _selectedkode)
                Dim i = Integer.Parse(_dbConnect.ExecuteScalar(check))

                If i <> 0 Then
                    MessageBox.Show("Nama ini sudah ada!")
                    Return
                End If

                Dim q = String.Format("UPDATE ruang " & "SET nama = '{0}', " & "    kapasitas = {1}, " & "    jenis = '{2}' " & "WHERE kode = {3}", txtNama.Text, _kapasitas, cmbJenis.Text, _selectedkode)
                _dbConnect.ExecuteNonQuery(q)

            Else

                Dim check = String.Format("SELECT CAST(COUNT(*) AS CHAR(1)) " & "FROM ruang " & "WHERE nama='{0}'", txtNama.Text)
                Dim i = Integer.Parse(_dbConnect.ExecuteScalar(check))

                If i <> 0 Then
                    MessageBox.Show("Nama ini sudah ada!")
                    Return
                End If

                Dim q = String.Format("INSERT INTO ruang(nama,kapasitas,jenis) " & "VALUES('{0}',{1},'{2}')", txtNama.Text, _kapasitas, cmbJenis.Text)
                _dbConnect.ExecuteNonQuery(q)
            End If

            _selectedkode = -1 'set to "-1" agar disign sebagai databaru

            ClassHelper.ClearTextBox(Me)
            SetEnabledOnBtn(True, False, False)
            LoadData()

        End Sub

        Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
            Close()

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
            Dim q = String.Format("DELETE FROM ruang where kode = ({0})", kode)
            _dbConnect.ExecuteNonQuery(q)

        End Sub

        Private Sub dtGridView_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dtGridView.UserDeletedRow
            LoadData()

        End Sub

        Private Sub dtGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridView.CellClick
            SetEnabledOnBtn(False, True, True)

            'ruang:kode,nama,kapasitas,jenis
            _selectedkode = Integer.Parse(dtGridView(0, dtGridView.SelectedRows(0).Index).Value.ToString())
            txtNama.Text = dtGridView(1, dtGridView.SelectedRows(0).Index).Value.ToString()
            txtKapasitas.Text = dtGridView(2, dtGridView.SelectedRows(0).Index).Value.ToString()
            cmbJenis.Text = dtGridView(3, dtGridView.SelectedRows(0).Index).Value.ToString()

        End Sub
    End Class
End Namespace