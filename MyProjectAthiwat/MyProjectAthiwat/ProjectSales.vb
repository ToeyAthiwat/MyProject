Public Class ProjectSales
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim Vist, computer, sales, commission, commissVist, commissCom As Double

        Vist = Val(txtVist.Text)
        computer = Val(txtComputer.Text)

        commissVist = Vist * 5 / 100
        commissCom = computer * 10 / 100
        commission = commissVist + commissCom

        sales = Vist + computer
        lblSales.Text = sales
        lblVist.Text = commissVist
        lblComputer.Text = commissCom
        lblTotal.Text = commission
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class