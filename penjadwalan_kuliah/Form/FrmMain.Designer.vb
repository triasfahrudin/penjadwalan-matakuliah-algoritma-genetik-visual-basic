Namespace Form
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmMain
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
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.AplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DosenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.MataKuliahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.RuangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.HariJamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.WaktuTidakBersediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.PengampuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.PenjadwalanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ProsesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AplikasiToolStripMenuItem, Me.PengampuToolStripMenuItem, Me.DataToolStripMenuItem, Me.PenjadwalanToolStripMenuItem})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(878, 24)
            Me.MenuStrip1.TabIndex = 1
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'AplikasiToolStripMenuItem
            '
            Me.AplikasiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeluarToolStripMenuItem})
            Me.AplikasiToolStripMenuItem.Name = "AplikasiToolStripMenuItem"
            Me.AplikasiToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
            Me.AplikasiToolStripMenuItem.Text = "Aplikasi"
            '
            'KeluarToolStripMenuItem
            '
            Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
            Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
            Me.KeluarToolStripMenuItem.Text = "Keluar"
            '
            'DataToolStripMenuItem
            '
            Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosenToolStripMenuItem, Me.MataKuliahToolStripMenuItem, Me.RuangToolStripMenuItem, Me.HariJamToolStripMenuItem, Me.WaktuTidakBersediaToolStripMenuItem})
            Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
            Me.DataToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
            Me.DataToolStripMenuItem.Text = "Data"
            '
            'DosenToolStripMenuItem
            '
            Me.DosenToolStripMenuItem.Name = "DosenToolStripMenuItem"
            Me.DosenToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
            Me.DosenToolStripMenuItem.Text = "Dosen"
            '
            'MataKuliahToolStripMenuItem
            '
            Me.MataKuliahToolStripMenuItem.Name = "MataKuliahToolStripMenuItem"
            Me.MataKuliahToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
            Me.MataKuliahToolStripMenuItem.Text = "Mata Kuliah"
            '
            'RuangToolStripMenuItem
            '
            Me.RuangToolStripMenuItem.Name = "RuangToolStripMenuItem"
            Me.RuangToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
            Me.RuangToolStripMenuItem.Text = "Ruang"
            '
            'HariJamToolStripMenuItem
            '
            Me.HariJamToolStripMenuItem.Name = "HariJamToolStripMenuItem"
            Me.HariJamToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
            Me.HariJamToolStripMenuItem.Text = "Hari && Jam"
            '
            'WaktuTidakBersediaToolStripMenuItem
            '
            Me.WaktuTidakBersediaToolStripMenuItem.Name = "WaktuTidakBersediaToolStripMenuItem"
            Me.WaktuTidakBersediaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
            Me.WaktuTidakBersediaToolStripMenuItem.Text = "Waktu Tidak Bersedia"
            '
            'PengampuToolStripMenuItem
            '
            Me.PengampuToolStripMenuItem.Name = "PengampuToolStripMenuItem"
            Me.PengampuToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
            Me.PengampuToolStripMenuItem.Text = "Pengampu"
            '
            'PenjadwalanToolStripMenuItem
            '
            Me.PenjadwalanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProsesToolStripMenuItem})
            Me.PenjadwalanToolStripMenuItem.Name = "PenjadwalanToolStripMenuItem"
            Me.PenjadwalanToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
            Me.PenjadwalanToolStripMenuItem.Text = "Penjadwalan"
            '
            'ProsesToolStripMenuItem
            '
            Me.ProsesToolStripMenuItem.Name = "ProsesToolStripMenuItem"
            Me.ProsesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.ProsesToolStripMenuItem.Text = "Proses"
            '
            'FrmMain
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(878, 521)
            Me.Controls.Add(Me.MenuStrip1)
            Me.IsMdiContainer = True
            Me.MainMenuStrip = Me.MenuStrip1
            Me.Name = "FrmMain"
            Me.Text = "Form1"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents AplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents DosenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MataKuliahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents RuangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents HariJamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents WaktuTidakBersediaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents PengampuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents PenjadwalanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ProsesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    End Class
End Namespace