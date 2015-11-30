Imports penjadwalan.Classes

Namespace Form
    Public Class FrmMain

        Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
            Application.Exit()
        End Sub

        Private Sub DosenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DosenToolStripMenuItem.Click
            MdiFormLoader.LoadFormType(GetType(FrmDosen), Me)
        End Sub

        Private Sub MataKuliahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MataKuliahToolStripMenuItem.Click
            MdiFormLoader.LoadFormType(GetType(FrmMataKuliah), Me)
        End Sub

        Private Sub RuangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RuangToolStripMenuItem.Click
            MdiFormLoader.LoadFormType(GetType(FrmRuang), Me)
        End Sub

        Private Sub HariJamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HariJamToolStripMenuItem.Click
            MdiFormLoader.LoadFormType(GetType(FrmDateTime), Me)
        End Sub

        Private Sub WaktuTidakBersediaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaktuTidakBersediaToolStripMenuItem.Click
            MdiFormLoader.LoadFormType(GetType(FrmWaktuTidakBersedia), Me)
        End Sub

        Private Sub PengampuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengampuToolStripMenuItem.Click
            MdiFormLoader.LoadFormType(GetType(FrmPengampu), Me)
        End Sub

        Private Sub ProsesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProsesToolStripMenuItem.Click
            MdiFormLoader.LoadFormType(GetType(FrmBuildJadwal), Me)
        End Sub

        Private Sub PengampuToolStripMenuItem1_Click(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace