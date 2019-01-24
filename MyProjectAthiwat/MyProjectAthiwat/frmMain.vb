Public Class frmMain
    Private Sub Lab1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab1ToolStripMenuItem.Click
        Dim first As New ProjectTax
        ProjectTax.Show()
    End Sub

    Private Sub Lab2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab2ToolStripMenuItem.Click
        Dim Lab2 As New ProjectSales
        ProjectSales.Show()
    End Sub

    Private Sub Lab3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab3ToolStripMenuItem.Click
        Dim Lab3 As New frm3
        frm3.Show()
    End Sub

    Private Sub Lab4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab4ToolStripMenuItem.Click
        Dim Lab4 As New frmJob4
        frmJob4.Show()
    End Sub

    Private Sub Lab5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab5ToolStripMenuItem.Click
        Dim Lab5 As New frm5
        frm5.Show()
    End Sub

    Private Sub Lab6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab6ToolStripMenuItem.Click
        Dim Lab6 As New frmJob6
        frmJob6.Show()
    End Sub

    Private Sub Lab7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab7ToolStripMenuItem.Click
        Dim Lab7 As New frmLab7
        frmLab7.Show()
    End Sub

    Private Sub Lab8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab8ToolStripMenuItem.Click
        Dim Lab8 As New frmLab8
        frmLab8.Show()
    End Sub
End Class