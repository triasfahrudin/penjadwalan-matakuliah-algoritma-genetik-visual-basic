Imports penjadwalan.Classes

Namespace Form

    Public Class FrmMataKuliah

        Private ReadOnly _dbConnect As New ClassDbConnect()
        Private _selectedkode As Integer = -1

        Private Sub CreateDtGridViewColumn()
            Dim dgvKode = New DataGridViewTextBoxColumn With {.HeaderText = "Kode", .Name = "dgvKode"}
            dtGridView.Columns.Add(dgvKode)

            Dim dgvKodeMK = New DataGridViewTextBoxColumn With {.HeaderText = "KodeMK", .Name = "dgvKodeMK"}
            dtGridView.Columns.Add(dgvKodeMK)

            Dim dgvNama = New DataGridViewTextBoxColumn With {.HeaderText = "Nama", .Name = "dgvNama"}
            dtGridView.Columns.Add(dgvNama)

            Dim dgvSKS = New DataGridViewTextBoxColumn With {.HeaderText = "SKS", .Name = "dgvSKS"}
            dtGridView.Columns.Add(dgvSKS)

            Dim dgvSemester = New DataGridViewTextBoxColumn With {.HeaderText = "Semester", .Name = "dgvSemester"}
            dtGridView.Columns.Add(dgvSemester)

            Dim dgvAktif = New DataGridViewCheckBoxColumn With {.HeaderText = "Aktif", .Name = "dgvAktif"}
            dtGridView.Columns.Add(dgvAktif)
            dgvAktif.Visible = False

            Dim dgvJenis = New DataGridViewComboBoxColumn With {.HeaderText = "Jenis", .Name = "dgvJenis"}
            dgvJenis.Items.Add("TEORI")
            dgvJenis.Items.Add("PRAKTIKUM")
            dtGridView.Columns.Add(dgvJenis)

        End Sub

        Private Sub LoadData()
            dtGridView.Rows.Clear()
            ClassHelper.ClearTextBox(Me)
            Dim datatable = _dbConnect.GetRecord("SELECT kode as id," & "       kode_mk as Kode," & "       nama as Nama," & "       sks as SKS," & "       semester as Semester," & "       aktif as Aktif," & "       jenis as Jenis " & "FROM mata_kuliah ORDER BY nama") 'combobox - checkbox

            For count = 0 To datatable.Rows.Count - 1
                dtGridView.Rows.Add(datatable.Rows(count)(0).ToString(), datatable.Rows(count)(1).ToString(), datatable.Rows(count)(2).ToString(), datatable.Rows(count)(3).ToString(), datatable.Rows(count)(4).ToString(), datatable.Rows(count)(5).ToString(), datatable.Rows(count)(6).ToString())
            Next count

            dtGridView.Columns(0).Visible = False

        End Sub

        Private Sub SetEnabledOnBtn(ByVal btnNewEnable As Boolean, ByVal btnCancelEnable As Boolean, ByVal btnSaveEnable As Boolean)
            btnBaru.Enabled = btnNewEnable
            btnBatal.Enabled = btnCancelEnable
            btnSimpan.Enabled = btnSaveEnable
            cmbKategori.Enabled = btnSaveEnable
            cbAktif.Enabled = btnSaveEnable
            ClassHelper.SetReadOnlyOnTextBox(Me, btnNewEnable)
        End Sub
        Private Sub btnPrint_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub FrmMataKuliah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CreateDtGridViewColumn()

            LoadData()
            SetEnabledOnBtn(True, False, False)


        End Sub


        Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
            ClassHelper.ClearTextBox(Me)
            SetEnabledOnBtn(False, True, True)
            _selectedkode = -1

        End Sub

        Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
            'tablename = mata_kuliah
            'kode,nama,sks,semester,aktif,jenis


            If txtKode.Text.Trim() = "" OrElse txtNama.Text.Trim() = "" OrElse txtSKS.Text.Trim() = "" OrElse txtSemester.Text.Trim() = "" Then
                MessageBox.Show("Data Belum Lengkap!")
                Return
            End If


            Const _aktif As String = "True" 'cbAktif.Checked ? "True" : "False";
            Dim _sks = Integer.Parse(txtSKS.Text)
            Dim _semester = Integer.Parse(txtSemester.Text)



            If _selectedkode <> -1 Then
                Dim check = String.Format("SELECT CAST(COUNT(*) AS CHAR(1)) " & "FROM mata_kuliah " & "WHERE (kode_mk='{0}' OR nama='{1}') AND kode <> {2}", txtKode.Text, txtNama.Text, _selectedkode)
                Dim i = Integer.Parse(_dbConnect.ExecuteScalar(check))

                If i <> 0 Then
                    MessageBox.Show("Kode Atau Nama ini sudah ada!")
                    Return
                End If

                Dim q = String.Format("UPDATE mata_kuliah " & "set kode_mk = '{0}', " & "    nama = '{1}', " & "    sks = {2}, " & "    semester = {3}," & "    aktif ='{4}'," & "    jenis = '{5}' " & "where kode = {6}", txtKode.Text, txtNama.Text, _sks, _semester, _aktif, cmbKategori.Text, _selectedkode)
                _dbConnect.ExecuteNonQuery(q)

            Else

                Dim check = String.Format("SELECT CAST(COUNT(*) AS CHAR(1)) " & "FROM mata_kuliah " & "WHERE kode_mk ='{0}' OR nama='{1}'", txtKode.Text, txtNama.Text)

                Dim i = Integer.Parse(_dbConnect.ExecuteScalar(check))

                If i <> 0 Then
                    MessageBox.Show("Kode Atau Nama ini sudah ada!")
                    Return
                End If

                Dim q = String.Format("INSERT INTO mata_kuliah(kode_mk,nama,sks,semester,aktif,jenis) " & "VALUES('{0}','{1}',{2},{3},'{4}','{5}')", txtKode.Text, txtNama.Text, _sks, _semester, _aktif, cmbKategori.Text)
                _dbConnect.ExecuteNonQuery(q)
            End If

            _selectedkode = -1 'set to "-1" agar disign sebagai databaru

            ClassHelper.ClearTextBox(Me)
            SetEnabledOnBtn(True, False, False)
            LoadData()

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
            'delete mata_kuliah
            Dim q = String.Format("DELETE FROM mata_kuliah where kode = ({0})", kode)
            _dbConnect.ExecuteNonQuery(q)
            'delete pengampu
            Dim q_1 = String.Format("DELETE FROM pengampu where kode_mk = ({0})", kode)
            _dbConnect.ExecuteNonQuery(q_1)


        End Sub

        Private Sub dtGridView_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dtGridView.UserDeletedRow
            LoadData()

        End Sub

        Private Sub dtGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridView.CellClick
            SetEnabledOnBtn(False, True, True)

            'kode,nama,sks,semester,aktif,jenis
            _selectedkode = Integer.Parse(dtGridView(0, dtGridView.SelectedRows(0).Index).Value.ToString())
            txtKode.Text = dtGridView(1, dtGridView.SelectedRows(0).Index).Value.ToString()
            txtNama.Text = dtGridView(2, dtGridView.SelectedRows(0).Index).Value.ToString()
            txtSKS.Text = dtGridView(3, dtGridView.SelectedRows(0).Index).Value.ToString()
            txtSemester.Text = dtGridView(4, dtGridView.SelectedRows(0).Index).Value.ToString()
            Dim _checked = dtGridView(5, dtGridView.SelectedRows(0).Index).Value.ToString()
            cbAktif.Checked = _checked = "True"
            cmbKategori.Text = dtGridView(6, dtGridView.SelectedRows(0).Index).Value.ToString()

        End Sub

        Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
            Close()

        End Sub
    End Class
End Namespace