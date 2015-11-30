Namespace Form
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmDateTime
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
            Me.btnTutup = New System.Windows.Forms.Button()
            Me.label5 = New System.Windows.Forms.Label()
            Me.txtRangeJam = New System.Windows.Forms.TextBox()
            Me.btnBatalJam = New System.Windows.Forms.Button()
            Me.dtGridViewJam = New System.Windows.Forms.DataGridView()
            Me.btnBaruJam = New System.Windows.Forms.Button()
            Me.btnSimpanJam = New System.Windows.Forms.Button()
            Me.txtKodeJam = New System.Windows.Forms.TextBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.cbAktif = New System.Windows.Forms.CheckBox()
            Me.btnBatalHari = New System.Windows.Forms.Button()
            Me.dtGridViewHari = New System.Windows.Forms.DataGridView()
            Me.btnBaruHari = New System.Windows.Forms.Button()
            Me.btnSimpanHari = New System.Windows.Forms.Button()
            Me.txtNamaHari = New System.Windows.Forms.TextBox()
            Me.txtKodeHari = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            CType(Me.dtGridViewJam, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox2.SuspendLayout()
            CType(Me.dtGridViewHari, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnTutup
            '
            Me.btnTutup.Location = New System.Drawing.Point(560, 353)
            Me.btnTutup.Name = "btnTutup"
            Me.btnTutup.Size = New System.Drawing.Size(75, 23)
            Me.btnTutup.TabIndex = 10
            Me.btnTutup.Text = "Tutup"
            Me.btnTutup.UseVisualStyleBackColor = True
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(77, 91)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(102, 13)
            Me.label5.TabIndex = 26
            Me.label5.Text = "format : 00:00-00:00"
            '
            'txtRangeJam
            '
            Me.txtRangeJam.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRangeJam.Location = New System.Drawing.Point(88, 62)
            Me.txtRangeJam.Name = "txtRangeJam"
            Me.txtRangeJam.Size = New System.Drawing.Size(117, 26)
            Me.txtRangeJam.TabIndex = 25
            Me.txtRangeJam.Text = "00:00-00:00"
            '
            'btnBatalJam
            '
            Me.btnBatalJam.Location = New System.Drawing.Point(140, 116)
            Me.btnBatalJam.Name = "btnBatalJam"
            Me.btnBatalJam.Size = New System.Drawing.Size(75, 23)
            Me.btnBatalJam.TabIndex = 24
            Me.btnBatalJam.Text = "Batal"
            Me.btnBatalJam.UseVisualStyleBackColor = True
            '
            'dtGridViewJam
            '
            Me.dtGridViewJam.AllowUserToAddRows = False
            Me.dtGridViewJam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dtGridViewJam.Location = New System.Drawing.Point(6, 145)
            Me.dtGridViewJam.Name = "dtGridViewJam"
            Me.dtGridViewJam.ReadOnly = True
            Me.dtGridViewJam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dtGridViewJam.Size = New System.Drawing.Size(290, 171)
            Me.dtGridViewJam.TabIndex = 23
            '
            'btnBaruJam
            '
            Me.btnBaruJam.Location = New System.Drawing.Point(24, 116)
            Me.btnBaruJam.Name = "btnBaruJam"
            Me.btnBaruJam.Size = New System.Drawing.Size(69, 23)
            Me.btnBaruJam.TabIndex = 22
            Me.btnBaruJam.Text = "Data Baru"
            Me.btnBaruJam.UseVisualStyleBackColor = True
            '
            'btnSimpanJam
            '
            Me.btnSimpanJam.Location = New System.Drawing.Point(221, 116)
            Me.btnSimpanJam.Name = "btnSimpanJam"
            Me.btnSimpanJam.Size = New System.Drawing.Size(75, 23)
            Me.btnSimpanJam.TabIndex = 21
            Me.btnSimpanJam.Text = "Simpan"
            Me.btnSimpanJam.UseVisualStyleBackColor = True
            '
            'txtKodeJam
            '
            Me.txtKodeJam.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtKodeJam.Location = New System.Drawing.Point(88, 27)
            Me.txtKodeJam.Name = "txtKodeJam"
            Me.txtKodeJam.Size = New System.Drawing.Size(91, 26)
            Me.txtKodeJam.TabIndex = 17
            Me.txtKodeJam.Text = "00"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(20, 61)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(47, 19)
            Me.label3.TabIndex = 16
            Me.label3.Text = "Range"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(20, 30)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(70, 19)
            Me.label4.TabIndex = 15
            Me.label4.Text = "Jam Ke - "
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.label5)
            Me.groupBox2.Controls.Add(Me.txtRangeJam)
            Me.groupBox2.Controls.Add(Me.btnBatalJam)
            Me.groupBox2.Controls.Add(Me.dtGridViewJam)
            Me.groupBox2.Controls.Add(Me.btnBaruJam)
            Me.groupBox2.Controls.Add(Me.btnSimpanJam)
            Me.groupBox2.Controls.Add(Me.txtKodeJam)
            Me.groupBox2.Controls.Add(Me.label3)
            Me.groupBox2.Controls.Add(Me.label4)
            Me.groupBox2.Location = New System.Drawing.Point(339, 15)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(302, 322)
            Me.groupBox2.TabIndex = 9
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Data Jam"
            '
            'cbAktif
            '
            Me.cbAktif.AutoSize = True
            Me.cbAktif.Location = New System.Drawing.Point(72, 93)
            Me.cbAktif.Name = "cbAktif"
            Me.cbAktif.Size = New System.Drawing.Size(47, 17)
            Me.cbAktif.TabIndex = 19
            Me.cbAktif.Text = "Aktif"
            Me.cbAktif.UseVisualStyleBackColor = True
            Me.cbAktif.Visible = False
            '
            'btnBatalHari
            '
            Me.btnBatalHari.Location = New System.Drawing.Point(137, 116)
            Me.btnBatalHari.Name = "btnBatalHari"
            Me.btnBatalHari.Size = New System.Drawing.Size(75, 23)
            Me.btnBatalHari.TabIndex = 18
            Me.btnBatalHari.Text = "Batal"
            Me.btnBatalHari.UseVisualStyleBackColor = True
            '
            'dtGridViewHari
            '
            Me.dtGridViewHari.AllowUserToAddRows = False
            Me.dtGridViewHari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dtGridViewHari.Location = New System.Drawing.Point(6, 145)
            Me.dtGridViewHari.Name = "dtGridViewHari"
            Me.dtGridViewHari.ReadOnly = True
            Me.dtGridViewHari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dtGridViewHari.Size = New System.Drawing.Size(287, 171)
            Me.dtGridViewHari.TabIndex = 17
            '
            'btnBaruHari
            '
            Me.btnBaruHari.Location = New System.Drawing.Point(16, 116)
            Me.btnBaruHari.Name = "btnBaruHari"
            Me.btnBaruHari.Size = New System.Drawing.Size(69, 23)
            Me.btnBaruHari.TabIndex = 16
            Me.btnBaruHari.Text = "Data Baru"
            Me.btnBaruHari.UseVisualStyleBackColor = True
            '
            'btnSimpanHari
            '
            Me.btnSimpanHari.Location = New System.Drawing.Point(218, 116)
            Me.btnSimpanHari.Name = "btnSimpanHari"
            Me.btnSimpanHari.Size = New System.Drawing.Size(75, 23)
            Me.btnSimpanHari.TabIndex = 15
            Me.btnSimpanHari.Text = "Simpan"
            Me.btnSimpanHari.UseVisualStyleBackColor = True
            '
            'txtNamaHari
            '
            Me.txtNamaHari.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNamaHari.Location = New System.Drawing.Point(72, 61)
            Me.txtNamaHari.Name = "txtNamaHari"
            Me.txtNamaHari.Size = New System.Drawing.Size(150, 26)
            Me.txtNamaHari.TabIndex = 14
            Me.txtNamaHari.Text = "AAAAAA"
            '
            'txtKodeHari
            '
            Me.txtKodeHari.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtKodeHari.Location = New System.Drawing.Point(72, 30)
            Me.txtKodeHari.Name = "txtKodeHari"
            Me.txtKodeHari.Size = New System.Drawing.Size(91, 26)
            Me.txtKodeHari.TabIndex = 13
            Me.txtKodeHari.Text = "00"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(12, 64)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(46, 19)
            Me.label2.TabIndex = 12
            Me.label2.Text = "Nama"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(12, 33)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(53, 19)
            Me.label1.TabIndex = 11
            Me.label1.Text = "KODE"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.cbAktif)
            Me.groupBox1.Controls.Add(Me.btnBatalHari)
            Me.groupBox1.Controls.Add(Me.dtGridViewHari)
            Me.groupBox1.Controls.Add(Me.btnBaruHari)
            Me.groupBox1.Controls.Add(Me.btnSimpanHari)
            Me.groupBox1.Controls.Add(Me.txtNamaHari)
            Me.groupBox1.Controls.Add(Me.txtKodeHari)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Location = New System.Drawing.Point(6, 15)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(299, 322)
            Me.groupBox1.TabIndex = 8
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Data Hari"
            '
            'FrmDateTime
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(662, 388)
            Me.Controls.Add(Me.btnTutup)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Name = "FrmDateTime"
            Me.Text = "FrmDateTime"
            CType(Me.dtGridViewJam, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            CType(Me.dtGridViewHari, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents btnTutup As System.Windows.Forms.Button
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents txtRangeJam As System.Windows.Forms.TextBox
        Private WithEvents btnBatalJam As System.Windows.Forms.Button
        Private WithEvents dtGridViewJam As System.Windows.Forms.DataGridView
        Private WithEvents btnBaruJam As System.Windows.Forms.Button
        Private WithEvents btnSimpanJam As System.Windows.Forms.Button
        Private WithEvents txtKodeJam As System.Windows.Forms.TextBox
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents cbAktif As System.Windows.Forms.CheckBox
        Private WithEvents btnBatalHari As System.Windows.Forms.Button
        Private WithEvents dtGridViewHari As System.Windows.Forms.DataGridView
        Private WithEvents btnBaruHari As System.Windows.Forms.Button
        Private WithEvents btnSimpanHari As System.Windows.Forms.Button
        Private WithEvents txtNamaHari As System.Windows.Forms.TextBox
        Private WithEvents txtKodeHari As System.Windows.Forms.TextBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    End Class
End Namespace