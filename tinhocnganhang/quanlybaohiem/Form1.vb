

Public Class Form1

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub HợpĐồngToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form3.Show()

    End Sub

    Private Sub TraCứuKỳHạnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraCứuKỳHạnToolStripMenuItem.Click
        tracuukyhan.Show()
    End Sub

    Private Sub TraCứuHợpĐồngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraCứuHợpĐồngToolStripMenuItem.Click
        tracuuhopdong.Show()
    End Sub

    
    Private Sub HồSơBảoHiểmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HồSơBảoHiểmToolStripMenuItem.Click
        themmoisua.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
