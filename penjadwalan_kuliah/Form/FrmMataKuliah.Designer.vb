Namespace Form
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmMataKuliah
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
            Me.dtGridView = New System.Windows.Forms.DataGridView()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.txtSKS = New System.Windows.Forms.TextBox()
            Me.btnBatal = New System.Windows.Forms.Button()
            Me.cmbKategori = New System.Windows.Forms.ComboBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.cbAktif = New System.Windows.Forms.CheckBox()
            Me.btnBaru = New System.Windows.Forms.Button()
            Me.btnTutup = New System.Windows.Forms.Button()
            Me.btnSimpan = New System.Windows.Forms.Button()
            Me.txtSemester = New System.Windows.Forms.TextBox()
            Me.txtNama = New System.Windows.Forms.TextBox()
            Me.txtKode = New System.Windows.Forms.TextBox()
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
            Me.dtGridView.Location = New System.Drawing.Point(13, 215)
            Me.dtGridView.Name = "dtGridView"
            Me.dtGridView.ReadOnly = True
            Me.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dtGridView.Size = New System.Drawing.Size(677, 253)
            Me.dtGridView.TabIndex = 16
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = Global.penjadwalan.My.Resources.Resources.mk
            Me.pictureBox1.Location = New System.Drawing.Point(6, 19)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(171, 153)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 21
            Me.pictureBox1.TabStop = False
            '
            'txtSKS
            '
            Me.txtSKS.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSKS.Location = New System.Drawing.Point(254, 79)
            Me.txtSKS.Name = "txtSKS"
            Me.txtSKS.Size = New System.Drawing.Size(56, 26)
            Me.txtSKS.TabIndex = 20
            Me.txtSKS.Text = "00"
            '
            'btnBatal
            '
            Me.btnBatal.Location = New System.Drawing.Point(356, 165)
            Me.btnBatal.Name = "btnBatal"
            Me.btnBatal.Size = New System.Drawing.Size(75, 23)
            Me.btnBatal.TabIndex = 19
            Me.btnBatal.Text = "Batal"
            Me.btnBatal.UseVisualStyleBackColor = True
            '
            'cmbKategori
            '
            Me.cmbKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbKategori.FormattingEnabled = True
            Me.cmbKategori.Items.AddRange(New Object() {"TEORI", "PRAKTIKUM"})
            Me.cmbKategori.Location = New System.Drawing.Point(254, 112)
            Me.cmbKategori.Name = "cmbKategori"
            Me.cmbKategori.Size = New System.Drawing.Size(121, 21)
            Me.cmbKategori.TabIndex = 18
            Me.cmbKategori.Text = "TEORI"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(183, 112)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(62, 19)
            Me.label5.TabIndex = 17
            Me.label5.Text = "Kategori"
            '
            'cbAktif
            '
            Me.cbAktif.AutoSize = True
            Me.cbAktif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbAktif.Location = New System.Drawing.Point(253, 139)
            Me.cbAktif.Name = "cbAktif"
            Me.cbAktif.Size = New System.Drawing.Size(57, 20)
            Me.cbAktif.TabIndex = 16
            Me.cbAktif.Text = "Aktif"
            Me.cbAktif.UseVisualStyleBackColor = True
            Me.cbAktif.Visible = False
            '
            'btnBaru
            '
            Me.btnBaru.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBaru.Location = New System.Drawing.Point(253, 165)
            Me.btnBaru.Name = "btnBaru"
            Me.btnBaru.Size = New System.Drawing.Size(75, 23)
            Me.btnBaru.TabIndex = 14
            Me.btnBaru.Text = "Data Baru"
            Me.btnBaru.UseVisualStyleBackColor = True
            '
            'btnTutup
            '
            Me.btnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTutup.Location = New System.Drawing.Point(615, 474)
            Me.btnTutup.Name = "btnTutup"
            Me.btnTutup.Size = New System.Drawing.Size(75, 25)
            Me.btnTutup.TabIndex = 14
            Me.btnTutup.Text = "Tutup"
            Me.btnTutup.UseVisualStyleBackColor = True
            '
            'btnSimpan
            '
            Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSimpan.Location = New System.Drawing.Point(437, 165)
            Me.btnSimpan.Name = "btnSimpan"
            Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
            Me.btnSimpan.TabIndex = 13
            Me.btnSimpan.Text = "Simpan"
            Me.btnSimpan.UseVisualStyleBackColor = True
            '
            'txtSemester
            '
            Me.txtSemester.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSemester.Location = New System.Drawing.Point(437, 76)
            Me.txtSemester.Name = "txtSemester"
            Me.txtSemester.Size = New System.Drawing.Size(56, 26)
            Me.txtSemester.TabIndex = 12
            Me.txtSemester.Text = "00"
            '
            'txtNama
            '
            Me.txtNama.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNama.Location = New System.Drawing.Point(254, 44)
            Me.txtNama.Name = "txtNama"
            Me.txtNama.Size = New System.Drawing.Size(264, 26)
            Me.txtNama.TabIndex = 10
            '
            'txtKode
            '
            Me.txtKode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtKode.Location = New System.Drawing.Point(254, 13)
            Me.txtKode.Name = "txtKode"
            Me.txtKode.Size = New System.Drawing.Size(100, 26)
            Me.txtKode.TabIndex = 9
            Me.txtKode.Text = "0000000000"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(366, 79)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(65, 19)
            Me.label4.TabIndex = 8
            Me.label4.Text = "Semester"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(183, 79)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(39, 19)
            Me.label3.TabIndex = 7
            Me.label3.Text = "SKS"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(183, 47)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(46, 19)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Nama"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(183, 16)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(53, 19)
            Me.label1.TabIndex = 5
            Me.label1.Text = "KODE"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.pictureBox1)
            Me.groupBox1.Controls.Add(Me.txtSKS)
            Me.groupBox1.Controls.Add(Me.btnBatal)
            Me.groupBox1.Controls.Add(Me.cmbKategori)
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.cbAktif)
            Me.groupBox1.Controls.Add(Me.btnBaru)
            Me.groupBox1.Controls.Add(Me.btnSimpan)
            Me.groupBox1.Controls.Add(Me.txtSemester)
            Me.groupBox1.Controls.Add(Me.txtNama)
            Me.groupBox1.Controls.Add(Me.txtKode)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Location = New System.Drawing.Point(12, 12)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(678, 197)
            Me.groupBox1.TabIndex = 13
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Data Mata Kuliah"
            '
            'FrmMataKuliah
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(705, 513)
            Me.Controls.Add(Me.dtGridView)
            Me.Controls.Add(Me.btnTutup)
            Me.Controls.Add(Me.groupBox1)
            Me.Name = "FrmMataKuliah"
            Me.Text = "FrmMataKuliah"
            CType(Me.dtGridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents dtGridView As System.Windows.Forms.DataGridView
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents txtSKS As System.Windows.Forms.TextBox
        Private WithEvents btnBatal As System.Windows.Forms.Button
        Private WithEvents cmbKategori As System.Windows.Forms.ComboBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents cbAktif As System.Windows.Forms.CheckBox
        Private WithEvents btnBaru As System.Windows.Forms.Button
        Private WithEvents btnTutup As System.Windows.Forms.Button
        Private WithEvents btnSimpan As System.Windows.Forms.Button
        Private WithEvents txtSemester As System.Windows.Forms.TextBox
        Private WithEvents txtNama As System.Windows.Forms.TextBox
        Private WithEvents txtKode As System.Windows.Forms.TextBox
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    End Class
End Namespace