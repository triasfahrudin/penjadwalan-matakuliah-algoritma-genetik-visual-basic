Namespace Form
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmWaktuTidakBersedia
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
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.cmbDosen = New System.Windows.Forms.ComboBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.btnBatal = New System.Windows.Forms.Button()
            Me.btnSimpan = New System.Windows.Forms.Button()
            Me.btnTutup = New System.Windows.Forms.Button()
            Me.dtGridView = New System.Windows.Forms.DataGridView()
            Me.groupBox1.SuspendLayout()
            CType(Me.dtGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.cmbDosen)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.btnBatal)
            Me.groupBox1.Controls.Add(Me.btnSimpan)
            Me.groupBox1.Location = New System.Drawing.Point(12, 12)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(378, 97)
            Me.groupBox1.TabIndex = 10
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Data Dosen Tidak Bersedia"
            '
            'cmbDosen
            '
            Me.cmbDosen.FormattingEnabled = True
            Me.cmbDosen.Location = New System.Drawing.Point(96, 29)
            Me.cmbDosen.Name = "cmbDosen"
            Me.cmbDosen.Size = New System.Drawing.Size(267, 21)
            Me.cmbDosen.TabIndex = 22
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(29, 28)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(48, 19)
            Me.label2.TabIndex = 19
            Me.label2.Text = "Dosen"
            '
            'btnBatal
            '
            Me.btnBatal.Location = New System.Drawing.Point(211, 68)
            Me.btnBatal.Name = "btnBatal"
            Me.btnBatal.Size = New System.Drawing.Size(75, 23)
            Me.btnBatal.TabIndex = 18
            Me.btnBatal.Text = "Batal"
            Me.btnBatal.UseVisualStyleBackColor = True
            '
            'btnSimpan
            '
            Me.btnSimpan.Location = New System.Drawing.Point(292, 68)
            Me.btnSimpan.Name = "btnSimpan"
            Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
            Me.btnSimpan.TabIndex = 16
            Me.btnSimpan.Text = "Simpan"
            Me.btnSimpan.UseVisualStyleBackColor = True
            '
            'btnTutup
            '
            Me.btnTutup.Location = New System.Drawing.Point(315, 440)
            Me.btnTutup.Name = "btnTutup"
            Me.btnTutup.Size = New System.Drawing.Size(75, 23)
            Me.btnTutup.TabIndex = 12
            Me.btnTutup.Text = "Tutup"
            Me.btnTutup.UseVisualStyleBackColor = True
            '
            'dtGridView
            '
            Me.dtGridView.AllowUserToAddRows = False
            Me.dtGridView.AllowUserToDeleteRows = False
            Me.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dtGridView.Location = New System.Drawing.Point(12, 115)
            Me.dtGridView.Name = "dtGridView"
            Me.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dtGridView.Size = New System.Drawing.Size(378, 319)
            Me.dtGridView.TabIndex = 11
            '
            'FrmWaktuTidakBersedia
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(413, 472)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.btnTutup)
            Me.Controls.Add(Me.dtGridView)
            Me.Name = "FrmWaktuTidakBersedia"
            Me.Text = "FrmWaktuTidakBersedia"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.dtGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents cmbDosen As System.Windows.Forms.ComboBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents btnBatal As System.Windows.Forms.Button
        Private WithEvents btnSimpan As System.Windows.Forms.Button
        Private WithEvents btnTutup As System.Windows.Forms.Button
        Private WithEvents dtGridView As System.Windows.Forms.DataGridView
    End Class
End Namespace