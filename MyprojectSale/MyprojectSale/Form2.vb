Public Class Form2
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        lbltotalSalary.Text = Val(txtSalary.Text) * 12
        lblTax.Text = lbltotalSalary.Text * 0.5

        lblTotal.Text = lbltotalSalary.Text - lblTax.Text
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class