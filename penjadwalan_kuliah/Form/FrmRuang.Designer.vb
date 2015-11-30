Namespace Form
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmRuang
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
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnBatal = New System.Windows.Forms.Button()
            Me.cmbJenis = New System.Windows.Forms.ComboBox()
            Me.btnBaru = New System.Windows.Forms.Button()
            Me.btnSimpan = New System.Windows.Forms.Button()
            Me.txtKapasitas = New System.Windows.Forms.TextBox()
            Me.txtNama = New System.Windows.Forms.TextBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.dtGridView = New System.Windows.Forms.DataGridView()
            Me.groupBox1.SuspendLayout()
            CType(Me.dtGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnTutup
            '
            Me.btnTutup.Location = New System.Drawing.Point(461, 474)
            Me.btnTutup.Name = "btnTutup"
            Me.btnTutup.Size = New System.Drawing.Size(75, 23)
            Me.btnTutup.TabIndex = 14
            Me.btnTutup.Text = "Tutup"
            Me.btnTutup.UseVisualStyleBackColor = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.btnBatal)
            Me.groupBox1.Controls.Add(Me.cmbJenis)
            Me.groupBox1.Controls.Add(Me.btnBaru)
            Me.groupBox1.Controls.Add(Me.btnSimpan)
            Me.groupBox1.Controls.Add(Me.txtKapasitas)
            Me.groupBox1.Controls.Add(Me.txtNama)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Location = New System.Drawing.Point(12, 12)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(524, 152)
            Me.groupBox1.TabIndex = 13
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Data Dosen"
            '
            'btnBatal
            '
            Me.btnBatal.Location = New System.Drawing.Point(365, 121)
            Me.btnBatal.Name = "btnBatal"
            Me.btnBatal.Size = New System.Drawing.Size(75, 23)
            Me.btnBatal.TabIndex = 16
            Me.btnBatal.Text = "Batal"
            Me.btnBatal.UseVisualStyleBackColor = True
            '
            'cmbJenis
            '
            Me.cmbJenis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cmbJenis.FormattingEnabled = True
            Me.cmbJenis.Items.AddRange(New Object() {"TEORI", "LABORATORIUM"})
            Me.cmbJenis.Location = New System.Drawing.Point(99, 94)
            Me.cmbJenis.Name = "cmbJenis"
            Me.cmbJenis.Size = New System.Drawing.Size(121, 21)
            Me.cmbJenis.TabIndex = 15
            Me.cmbJenis.Text = "TEORI"
            '
            'btnBaru
            '
            Me.btnBaru.Location = New System.Drawing.Point(99, 121)
            Me.btnBaru.Name = "btnBaru"
            Me.btnBaru.Size = New System.Drawing.Size(75, 23)
            Me.btnBaru.TabIndex = 14
            Me.btnBaru.Text = "Data Baru"
            Me.btnBaru.UseVisualStyleBackColor = True
            '
            'btnSimpan
            '
            Me.btnSimpan.Location = New System.Drawing.Point(443, 121)
            Me.btnSimpan.Name = "btnSimpan"
            Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
            Me.btnSimpan.TabIndex = 13
            Me.btnSimpan.Text = "Simpan"
            Me.btnSimpan.UseVisualStyleBackColor = True
            '
            'txtKapasitas
            '
            Me.txtKapasitas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtKapasitas.Location = New System.Drawing.Point(99, 62)
            Me.txtKapasitas.Name = "txtKapasitas"
            Me.txtKapasitas.Size = New System.Drawing.Size(40, 26)
            Me.txtKapasitas.TabIndex = 11
            Me.txtKapasitas.Text = "00"
            '
            'txtNama
            '
            Me.txtNama.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNama.Location = New System.Drawing.Point(99, 30)
            Me.txtNama.Name = "txtNama"
            Me.txtNama.Size = New System.Drawing.Size(316, 26)
            Me.txtNama.TabIndex = 10
            Me.txtNama.Text = "AAAAAAAAAAAAAAAAAAAAAAAA"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(24, 93)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(38, 19)
            Me.label4.TabIndex = 8
            Me.label4.Text = "Jenis"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(24, 65)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(69, 19)
            Me.label3.TabIndex = 7
            Me.label3.Text = "Kapasitas"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(24, 33)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(46, 19)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Nama"
            '
            'dtGridView
            '
            Me.dtGridView.AllowUserToAddRows = False
            Me.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dtGridView.Location = New System.Drawing.Point(13, 170)
            Me.dtGridView.Name = "dtGridView"
            Me.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dtGridView.Size = New System.Drawing.Size(524, 298)
            Me.dtGridView.TabIndex = 16
            '
            'FrmRuang
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(557, 508)
            Me.Controls.Add(Me.btnTutup)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.dtGridView)
            Me.Name = "FrmRuang"
            Me.Text = "FrmRuang"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.dtGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents btnTutup As System.Windows.Forms.Button
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents btnBatal As System.Windows.Forms.Button
        Private WithEvents cmbJenis As System.Windows.Forms.ComboBox
        Private WithEvents btnBaru As System.Windows.Forms.Button
        Private WithEvents btnSimpan As System.Windows.Forms.Button
        Private WithEvents txtKapasitas As System.Windows.Forms.TextBox
        Private WithEvents txtNama As System.Windows.Forms.TextBox
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents dtGridView As System.Windows.Forms.DataGridView
    End Class
End Namespace