Namespace Form
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmPengampu
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPengampu))
            Me.dtGridView = New System.Windows.Forms.DataGridView()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.btnBatal = New System.Windows.Forms.Button()
            Me.cmbTahunAkademik = New System.Windows.Forms.ComboBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.cmbDosen = New System.Windows.Forms.ComboBox()
            Me.cmbMataKuliah = New System.Windows.Forms.ComboBox()
            Me.btnTutup = New System.Windows.Forms.Button()
            Me.cmbSemester = New System.Windows.Forms.ComboBox()
            Me.btnBaru = New System.Windows.Forms.Button()
            Me.btnSimpan = New System.Windows.Forms.Button()
            Me.txtKelas = New System.Windows.Forms.TextBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            CType(Me.dtGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dtGridView
            '
            Me.dtGridView.AllowUserToAddRows = False
            Me.dtGridView.AllowUserToOrderColumns = True
            Me.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dtGridView.Location = New System.Drawing.Point(12, 189)
            Me.dtGridView.Name = "dtGridView"
            Me.dtGridView.ReadOnly = True
            Me.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dtGridView.Size = New System.Drawing.Size(614, 291)
            Me.dtGridView.TabIndex = 16
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(6, 19)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(148, 146)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 21
            Me.pictureBox1.TabStop = False
            '
            'btnBatal
            '
            Me.btnBatal.Location = New System.Drawing.Point(449, 142)
            Me.btnBatal.Name = "btnBatal"
            Me.btnBatal.Size = New System.Drawing.Size(75, 23)
            Me.btnBatal.TabIndex = 20
            Me.btnBatal.Text = "Batal"
            Me.btnBatal.UseVisualStyleBackColor = True
            '
            'cmbTahunAkademik
            '
            Me.cmbTahunAkademik.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cmbTahunAkademik.FormattingEnabled = True
            Me.cmbTahunAkademik.Items.AddRange(New Object() {"2011/2012", "2012/2013", "2013/2014", "2014/2015", "2015/2016", "2016/2017", "2017/2018", "2018/2019", "2019/2020"})
            Me.cmbTahunAkademik.Location = New System.Drawing.Point(471, 19)
            Me.cmbTahunAkademik.Name = "cmbTahunAkademik"
            Me.cmbTahunAkademik.Size = New System.Drawing.Size(82, 21)
            Me.cmbTahunAkademik.TabIndex = 19
            Me.cmbTahunAkademik.Text = "2011/2012"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(354, 19)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(111, 19)
            Me.label5.TabIndex = 18
            Me.label5.Text = "Tahun Akademik"
            '
            'cmbDosen
            '
            Me.cmbDosen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbDosen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbDosen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cmbDosen.FormattingEnabled = True
            Me.cmbDosen.Location = New System.Drawing.Point(264, 74)
            Me.cmbDosen.Name = "cmbDosen"
            Me.cmbDosen.Size = New System.Drawing.Size(289, 21)
            Me.cmbDosen.TabIndex = 17
            '
            'cmbMataKuliah
            '
            Me.cmbMataKuliah.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbMataKuliah.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbMataKuliah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cmbMataKuliah.FormattingEnabled = True
            Me.cmbMataKuliah.Location = New System.Drawing.Point(264, 47)
            Me.cmbMataKuliah.Name = "cmbMataKuliah"
            Me.cmbMataKuliah.Size = New System.Drawing.Size(289, 21)
            Me.cmbMataKuliah.TabIndex = 16
            '
            'btnTutup
            '
            Me.btnTutup.Location = New System.Drawing.Point(551, 486)
            Me.btnTutup.Name = "btnTutup"
            Me.btnTutup.Size = New System.Drawing.Size(75, 23)
            Me.btnTutup.TabIndex = 14
            Me.btnTutup.Text = "Tutup"
            Me.btnTutup.UseVisualStyleBackColor = True
            '
            'cmbSemester
            '
            Me.cmbSemester.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cmbSemester.FormattingEnabled = True
            Me.cmbSemester.Items.AddRange(New Object() {"GANJIL", "GENAP"})
            Me.cmbSemester.Location = New System.Drawing.Point(264, 20)
            Me.cmbSemester.Name = "cmbSemester"
            Me.cmbSemester.Size = New System.Drawing.Size(75, 21)
            Me.cmbSemester.TabIndex = 15
            Me.cmbSemester.Text = "GANJIL"
            '
            'btnBaru
            '
            Me.btnBaru.Location = New System.Drawing.Point(264, 142)
            Me.btnBaru.Name = "btnBaru"
            Me.btnBaru.Size = New System.Drawing.Size(75, 23)
            Me.btnBaru.TabIndex = 14
            Me.btnBaru.Text = "Data Baru"
            Me.btnBaru.UseVisualStyleBackColor = True
            '
            'btnSimpan
            '
            Me.btnSimpan.Location = New System.Drawing.Point(530, 142)
            Me.btnSimpan.Name = "btnSimpan"
            Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
            Me.btnSimpan.TabIndex = 13
            Me.btnSimpan.Text = "Simpan"
            Me.btnSimpan.UseVisualStyleBackColor = True
            '
            'txtKelas
            '
            Me.txtKelas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtKelas.Location = New System.Drawing.Point(264, 101)
            Me.txtKelas.Name = "txtKelas"
            Me.txtKelas.Size = New System.Drawing.Size(43, 26)
            Me.txtKelas.TabIndex = 12
            Me.txtKelas.Text = "A"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(174, 104)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(44, 19)
            Me.label4.TabIndex = 8
            Me.label4.Text = "Kelas"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(174, 76)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(48, 19)
            Me.label3.TabIndex = 7
            Me.label3.Text = "Dosen"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(174, 49)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(84, 19)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Mata Kuliah"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(174, 19)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(65, 19)
            Me.label1.TabIndex = 5
            Me.label1.Text = "Semester"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.pictureBox1)
            Me.groupBox1.Controls.Add(Me.btnBatal)
            Me.groupBox1.Controls.Add(Me.cmbTahunAkademik)
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.cmbDosen)
            Me.groupBox1.Controls.Add(Me.cmbMataKuliah)
            Me.groupBox1.Controls.Add(Me.cmbSemester)
            Me.groupBox1.Controls.Add(Me.btnBaru)
            Me.groupBox1.Controls.Add(Me.btnSimpan)
            Me.groupBox1.Controls.Add(Me.txtKelas)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Location = New System.Drawing.Point(12, 12)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(614, 171)
            Me.groupBox1.TabIndex = 13
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Data Pengampu"
            '
            'FrmPengampu
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(640, 518)
            Me.Controls.Add(Me.dtGridView)
            Me.Controls.Add(Me.btnTutup)
            Me.Controls.Add(Me.groupBox1)
            Me.Name = "FrmPengampu"
            Me.Text = "FrmPengampu"
            CType(Me.dtGridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents dtGridView As System.Windows.Forms.DataGridView
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents btnBatal As System.Windows.Forms.Button
        Private WithEvents cmbTahunAkademik As System.Windows.Forms.ComboBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents cmbDosen As System.Windows.Forms.ComboBox
        Private WithEvents cmbMataKuliah As System.Windows.Forms.ComboBox
        Private WithEvents btnTutup As System.Windows.Forms.Button
        Private WithEvents cmbSemester As System.Windows.Forms.ComboBox
        Private WithEvents btnBaru As System.Windows.Forms.Button
        Private WithEvents btnSimpan As System.Windows.Forms.Button
        Private WithEvents txtKelas As System.Windows.Forms.TextBox
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    End Class
End Namespace