Namespace Form
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmBuildJadwal
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
            Me.progressBar = New System.Windows.Forms.ProgressBar()
            Me.btnStop = New System.Windows.Forms.Button()
            Me.label9 = New System.Windows.Forms.Label()
            Me.txtIterasi = New System.Windows.Forms.TextBox()
            Me.label8 = New System.Windows.Forms.Label()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.numMutasi = New System.Windows.Forms.NumericUpDown()
            Me.label5 = New System.Windows.Forms.Label()
            Me.worker = New System.ComponentModel.BackgroundWorker()
            Me.lv = New System.Windows.Forms.ListView()
            Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.lblPosition = New System.Windows.Forms.Label()
            Me.numCrossover = New System.Windows.Forms.NumericUpDown()
            Me.cmbSemester = New System.Windows.Forms.ComboBox()
            Me.cmbTahunAkademik = New System.Windows.Forms.ComboBox()
            Me.dtGridView = New System.Windows.Forms.DataGridView()
            Me.btnProses = New System.Windows.Forms.Button()
            Me.lblRata2Fitness = New System.Windows.Forms.Label()
            Me.txtJumlahPopulasi = New System.Windows.Forms.TextBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.btnTutup = New System.Windows.Forms.Button()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numMutasi, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numCrossover, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'progressBar
            '
            Me.progressBar.ForeColor = System.Drawing.SystemColors.Desktop
            Me.progressBar.Location = New System.Drawing.Point(13, 490)
            Me.progressBar.Name = "progressBar"
            Me.progressBar.Size = New System.Drawing.Size(117, 6)
            Me.progressBar.TabIndex = 29
            Me.progressBar.Value = 50
            '
            'btnStop
            '
            Me.btnStop.Enabled = False
            Me.btnStop.Location = New System.Drawing.Point(574, 141)
            Me.btnStop.Name = "btnStop"
            Me.btnStop.Size = New System.Drawing.Size(75, 23)
            Me.btnStop.TabIndex = 24
            Me.btnStop.Text = "STOP"
            Me.btnStop.UseVisualStyleBackColor = True
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Cursor = System.Windows.Forms.Cursors.Hand
            Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label9.ForeColor = System.Drawing.SystemColors.Desktop
            Me.label9.Location = New System.Drawing.Point(159, 146)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(171, 13)
            Me.label9.TabIndex = 23
            Me.label9.Text = "*Populasi harus bernilai kelipatan 2"
            '
            'txtIterasi
            '
            Me.txtIterasi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIterasi.Location = New System.Drawing.Point(655, 90)
            Me.txtIterasi.Name = "txtIterasi"
            Me.txtIterasi.Size = New System.Drawing.Size(60, 26)
            Me.txtIterasi.TabIndex = 22
            Me.txtIterasi.Text = "100000"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.Location = New System.Drawing.Point(492, 93)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(46, 19)
            Me.label8.TabIndex = 21
            Me.label8.Text = "Iterasi"
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = Global.penjadwalan.My.Resources.Resources.images
            Me.pictureBox1.Location = New System.Drawing.Point(6, 19)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(121, 145)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 20
            Me.pictureBox1.TabStop = False
            '
            'numMutasi
            '
            Me.numMutasi.DecimalPlaces = 2
            Me.numMutasi.Location = New System.Drawing.Point(655, 66)
            Me.numMutasi.Name = "numMutasi"
            Me.numMutasi.Size = New System.Drawing.Size(60, 20)
            Me.numMutasi.TabIndex = 19
            Me.numMutasi.Value = New Decimal(New Integer() {15, 0, 0, 131072})
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(492, 67)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(125, 19)
            Me.label5.TabIndex = 18
            Me.label5.Text = "Probabilitas Mutasi"
            '
            'worker
            '
            Me.worker.WorkerSupportsCancellation = True
            '
            'lv
            '
            Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2})
            Me.lv.FullRowSelect = True
            Me.lv.GridLines = True
            Me.lv.Location = New System.Drawing.Point(763, 28)
            Me.lv.Name = "lv"
            Me.lv.Size = New System.Drawing.Size(221, 456)
            Me.lv.TabIndex = 32
            Me.lv.UseCompatibleStateImageBehavior = False
            Me.lv.View = System.Windows.Forms.View.Details
            '
            'columnHeader1
            '
            Me.columnHeader1.Text = "Individu Ke - "
            Me.columnHeader1.Width = 100
            '
            'columnHeader2
            '
            Me.columnHeader2.Text = "Fitness"
            Me.columnHeader2.Width = 100
            '
            'lblPosition
            '
            Me.lblPosition.AutoSize = True
            Me.lblPosition.Location = New System.Drawing.Point(763, 12)
            Me.lblPosition.Name = "lblPosition"
            Me.lblPosition.Size = New System.Drawing.Size(14, 13)
            Me.lblPosition.TabIndex = 31
            Me.lblPosition.Text = "#"
            '
            'numCrossover
            '
            Me.numCrossover.DecimalPlaces = 2
            Me.numCrossover.Location = New System.Drawing.Point(655, 38)
            Me.numCrossover.Name = "numCrossover"
            Me.numCrossover.Size = New System.Drawing.Size(60, 20)
            Me.numCrossover.TabIndex = 17
            Me.numCrossover.Value = New Decimal(New Integer() {70, 0, 0, 131072})
            '
            'cmbSemester
            '
            Me.cmbSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbSemester.FormattingEnabled = True
            Me.cmbSemester.Items.AddRange(New Object() {"GANJIL", "GENAP"})
            Me.cmbSemester.Location = New System.Drawing.Point(287, 62)
            Me.cmbSemester.Name = "cmbSemester"
            Me.cmbSemester.Size = New System.Drawing.Size(121, 21)
            Me.cmbSemester.TabIndex = 16
            Me.cmbSemester.Text = "GANJIL"
            '
            'cmbTahunAkademik
            '
            Me.cmbTahunAkademik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbTahunAkademik.FormattingEnabled = True
            Me.cmbTahunAkademik.Items.AddRange(New Object() {"2011/2012", "2012/2013", "2013/2014", "2014/2015", "2015/2016", "2016/2017", "2017/2018", "2018/2019", "2019/2020"})
            Me.cmbTahunAkademik.Location = New System.Drawing.Point(287, 34)
            Me.cmbTahunAkademik.Name = "cmbTahunAkademik"
            Me.cmbTahunAkademik.Size = New System.Drawing.Size(121, 21)
            Me.cmbTahunAkademik.TabIndex = 15
            Me.cmbTahunAkademik.Text = "2012/2013"
            '
            'dtGridView
            '
            Me.dtGridView.AllowUserToAddRows = False
            Me.dtGridView.AllowUserToDeleteRows = False
            Me.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dtGridView.Location = New System.Drawing.Point(13, 185)
            Me.dtGridView.Name = "dtGridView"
            Me.dtGridView.ReadOnly = True
            Me.dtGridView.Size = New System.Drawing.Size(744, 299)
            Me.dtGridView.TabIndex = 30
            '
            'btnProses
            '
            Me.btnProses.Location = New System.Drawing.Point(655, 141)
            Me.btnProses.Name = "btnProses"
            Me.btnProses.Size = New System.Drawing.Size(75, 23)
            Me.btnProses.TabIndex = 13
            Me.btnProses.Text = "PROSES"
            Me.btnProses.UseVisualStyleBackColor = True
            '
            'lblRata2Fitness
            '
            Me.lblRata2Fitness.AutoSize = True
            Me.lblRata2Fitness.Location = New System.Drawing.Point(774, 487)
            Me.lblRata2Fitness.Name = "lblRata2Fitness"
            Me.lblRata2Fitness.Size = New System.Drawing.Size(90, 13)
            Me.lblRata2Fitness.TabIndex = 33
            Me.lblRata2Fitness.Text = "Rata-rata Fitness:"
            '
            'txtJumlahPopulasi
            '
            Me.txtJumlahPopulasi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtJumlahPopulasi.Location = New System.Drawing.Point(287, 93)
            Me.txtJumlahPopulasi.Name = "txtJumlahPopulasi"
            Me.txtJumlahPopulasi.Size = New System.Drawing.Size(41, 26)
            Me.txtJumlahPopulasi.TabIndex = 12
            Me.txtJumlahPopulasi.Text = "10"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(492, 36)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(147, 19)
            Me.label4.TabIndex = 8
            Me.label4.Text = "Probabilitas Crossover"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(158, 96)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(113, 19)
            Me.label3.TabIndex = 7
            Me.label3.Text = "Jumlah Populasi*"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(158, 64)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(65, 19)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Semester"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(158, 33)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(111, 19)
            Me.label1.TabIndex = 5
            Me.label1.Text = "Tahun Akademik"
            '
            'btnTutup
            '
            Me.btnTutup.Location = New System.Drawing.Point(909, 513)
            Me.btnTutup.Name = "btnTutup"
            Me.btnTutup.Size = New System.Drawing.Size(75, 23)
            Me.btnTutup.TabIndex = 28
            Me.btnTutup.Text = "Tutup"
            Me.btnTutup.UseVisualStyleBackColor = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.btnStop)
            Me.groupBox1.Controls.Add(Me.label9)
            Me.groupBox1.Controls.Add(Me.txtIterasi)
            Me.groupBox1.Controls.Add(Me.label8)
            Me.groupBox1.Controls.Add(Me.pictureBox1)
            Me.groupBox1.Controls.Add(Me.numMutasi)
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.numCrossover)
            Me.groupBox1.Controls.Add(Me.cmbSemester)
            Me.groupBox1.Controls.Add(Me.cmbTahunAkademik)
            Me.groupBox1.Controls.Add(Me.btnProses)
            Me.groupBox1.Controls.Add(Me.txtJumlahPopulasi)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Location = New System.Drawing.Point(13, 9)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(744, 170)
            Me.groupBox1.TabIndex = 27
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Build Jadwal"
            '
            'FrmBuildJadwal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(991, 544)
            Me.Controls.Add(Me.progressBar)
            Me.Controls.Add(Me.lv)
            Me.Controls.Add(Me.lblPosition)
            Me.Controls.Add(Me.dtGridView)
            Me.Controls.Add(Me.lblRata2Fitness)
            Me.Controls.Add(Me.btnTutup)
            Me.Controls.Add(Me.groupBox1)
            Me.Name = "FrmBuildJadwal"
            Me.Text = "FrmBuildJadwal"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numMutasi, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numCrossover, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Private WithEvents progressBar As System.Windows.Forms.ProgressBar
        Private WithEvents btnStop As System.Windows.Forms.Button
        Private WithEvents label9 As System.Windows.Forms.Label
        Private WithEvents txtIterasi As System.Windows.Forms.TextBox
        Private WithEvents label8 As System.Windows.Forms.Label
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents numMutasi As System.Windows.Forms.NumericUpDown
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents worker As System.ComponentModel.BackgroundWorker
        Private WithEvents lv As System.Windows.Forms.ListView
        Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
        Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
        Private WithEvents lblPosition As System.Windows.Forms.Label
        Private WithEvents numCrossover As System.Windows.Forms.NumericUpDown
        Private WithEvents cmbSemester As System.Windows.Forms.ComboBox
        Private WithEvents cmbTahunAkademik As System.Windows.Forms.ComboBox
        Private WithEvents dtGridView As System.Windows.Forms.DataGridView
        Private WithEvents btnProses As System.Windows.Forms.Button
        Private WithEvents lblRata2Fitness As System.Windows.Forms.Label
        Private WithEvents txtJumlahPopulasi As System.Windows.Forms.TextBox
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents btnTutup As System.Windows.Forms.Button
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    End Class
End Namespace