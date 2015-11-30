Namespace Form
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmDosen
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
            Me.txtKode = New System.Windows.Forms.TextBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.btnBatal = New System.Windows.Forms.Button()
            Me.btnBaru = New System.Windows.Forms.Button()
            Me.btnSimpan = New System.Windows.Forms.Button()
            Me.txtTelp = New System.Windows.Forms.TextBox()
            Me.txtAlamat = New System.Windows.Forms.TextBox()
            Me.btnTutup = New System.Windows.Forms.Button()
            Me.txtNama = New System.Windows.Forms.TextBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.txtNIDN = New System.Windows.Forms.TextBox()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            CType(Me.dtGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dtGridView
            '
            Me.dtGridView.AllowUserToAddRows = False
            Me.dtGridView.AllowUserToOrderColumns = True
            Me.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dtGridView.Location = New System.Drawing.Point(13, 222)
            Me.dtGridView.Name = "dtGridView"
            Me.dtGridView.ReadOnly = True
            Me.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dtGridView.Size = New System.Drawing.Size(523, 237)
            Me.dtGridView.TabIndex = 12
            '
            'txtKode
            '
            Me.txtKode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtKode.Location = New System.Drawing.Point(84, 19)
            Me.txtKode.Name = "txtKode"
            Me.txtKode.Size = New System.Drawing.Size(100, 26)
            Me.txtKode.TabIndex = 17
            Me.txtKode.Text = "00"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(26, 22)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(44, 19)
            Me.label5.TabIndex = 16
            Me.label5.Text = "Kode"
            '
            'btnBatal
            '
            Me.btnBatal.Location = New System.Drawing.Point(362, 184)
            Me.btnBatal.Name = "btnBatal"
            Me.btnBatal.Size = New System.Drawing.Size(75, 23)
            Me.btnBatal.TabIndex = 15
            Me.btnBatal.Text = "Batal"
            Me.btnBatal.UseVisualStyleBackColor = True
            '
            'btnBaru
            '
            Me.btnBaru.Location = New System.Drawing.Point(84, 184)
            Me.btnBaru.Name = "btnBaru"
            Me.btnBaru.Size = New System.Drawing.Size(75, 23)
            Me.btnBaru.TabIndex = 14
            Me.btnBaru.Text = "Data Baru"
            Me.btnBaru.UseVisualStyleBackColor = True
            '
            'btnSimpan
            '
            Me.btnSimpan.Location = New System.Drawing.Point(443, 184)
            Me.btnSimpan.Name = "btnSimpan"
            Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
            Me.btnSimpan.TabIndex = 13
            Me.btnSimpan.Text = "Simpan"
            Me.btnSimpan.UseVisualStyleBackColor = True
            '
            'txtTelp
            '
            Me.txtTelp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelp.Location = New System.Drawing.Point(84, 150)
            Me.txtTelp.Name = "txtTelp"
            Me.txtTelp.Size = New System.Drawing.Size(121, 26)
            Me.txtTelp.TabIndex = 12
            Me.txtTelp.Text = "000000000000"
            '
            'txtAlamat
            '
            Me.txtAlamat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAlamat.Location = New System.Drawing.Point(84, 117)
            Me.txtAlamat.Name = "txtAlamat"
            Me.txtAlamat.Size = New System.Drawing.Size(425, 26)
            Me.txtAlamat.TabIndex = 11
            Me.txtAlamat.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
            '
            'btnTutup
            '
            Me.btnTutup.Location = New System.Drawing.Point(461, 465)
            Me.btnTutup.Name = "btnTutup"
            Me.btnTutup.Size = New System.Drawing.Size(75, 23)
            Me.btnTutup.TabIndex = 10
            Me.btnTutup.Text = "Tutup"
            Me.btnTutup.UseVisualStyleBackColor = True
            '
            'txtNama
            '
            Me.txtNama.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNama.Location = New System.Drawing.Point(84, 85)
            Me.txtNama.Name = "txtNama"
            Me.txtNama.Size = New System.Drawing.Size(316, 26)
            Me.txtNama.TabIndex = 10
            Me.txtNama.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAA"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(24, 150)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(35, 19)
            Me.label4.TabIndex = 8
            Me.label4.Text = "Telp"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(24, 120)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(52, 19)
            Me.label3.TabIndex = 7
            Me.label3.Text = "Alamat"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(24, 88)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(46, 19)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Nama"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(24, 57)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(49, 19)
            Me.label1.TabIndex = 5
            Me.label1.Text = "NIDN"
            '
            'txtNIDN
            '
            Me.txtNIDN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNIDN.Location = New System.Drawing.Point(84, 54)
            Me.txtNIDN.Name = "txtNIDN"
            Me.txtNIDN.Size = New System.Drawing.Size(100, 26)
            Me.txtNIDN.TabIndex = 9
            Me.txtNIDN.Text = "0000000000"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.txtKode)
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.btnBatal)
            Me.groupBox1.Controls.Add(Me.btnBaru)
            Me.groupBox1.Controls.Add(Me.btnSimpan)
            Me.groupBox1.Controls.Add(Me.txtTelp)
            Me.groupBox1.Controls.Add(Me.txtAlamat)
            Me.groupBox1.Controls.Add(Me.txtNama)
            Me.groupBox1.Controls.Add(Me.txtNIDN)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Location = New System.Drawing.Point(12, 3)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(524, 213)
            Me.groupBox1.TabIndex = 9
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Data Dosen"
            '
            'FrmDosen
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(552, 496)
            Me.Controls.Add(Me.dtGridView)
            Me.Controls.Add(Me.btnTutup)
            Me.Controls.Add(Me.groupBox1)
            Me.Name = "FrmDosen"
            Me.Text = "FrmDosen"
            CType(Me.dtGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents dtGridView As System.Windows.Forms.DataGridView
        Private WithEvents txtKode As System.Windows.Forms.TextBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents btnBatal As System.Windows.Forms.Button
        Private WithEvents btnBaru As System.Windows.Forms.Button
        Private WithEvents btnSimpan As System.Windows.Forms.Button
        Private WithEvents txtTelp As System.Windows.Forms.TextBox
        Private WithEvents txtAlamat As System.Windows.Forms.TextBox
        Private WithEvents btnTutup As System.Windows.Forms.Button
        Private WithEvents txtNama As System.Windows.Forms.TextBox
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents txtNIDN As System.Windows.Forms.TextBox
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    End Class
End Namespace