Public Class frmJob4
    Private Sub btnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click
        Const Bonus As Double = 0.2
        Const Allow As Double = 0.01
        Const Tax As Double = 0.07
        Dim dblYearSalary, dblBonus, dblAllIncome, dblAllowance, dblTax, Saraly, YearSale

        Saraly = Val(txtSaraly.Text)
        YearSale = Val(txtSale.Text)

        dblYearSalary = Saraly * 12
        dblBonus = (YearSale * Bonus)
        dblAllIncome = dblYearSalary + dblBonus
        dblAllowance = dblAllIncome * Allow
        dblTax = (dblAllIncome - dblAllowance) * Tax

        lblYearSaraly.Text = FormatNumber(dblYearSalary, 2)
        lblBonus.Text = FormatNumber(dblBonus, 2)
        lblAllIncome.Text = FormatNumber(dblAllIncome, 2)
        lblAllowance.Text = FormatNumber(dblAllowance, 2)
        lblTax.Text = FormatNumber(dblTax, 2)

    End Sub

    Private Sub frmJob4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim day As String = Now.Date
        lblDate.Text = day
        radGenDate.Checked = True

    End Sub

    Private Sub radShortDate_CheckedChanged(sender As Object, e As EventArgs) Handles radShortDate.CheckedChanged
        Dim mDate As Date = Date.Now
        lblDate.Text = mDate.Date

    End Sub

    Private Sub radGenDate_CheckedChanged(sender As Object, e As EventArgs) Handles radGenDate.CheckedChanged
        Dim mDate As Date = Date.Now
        lblDate.Text = mDate
    End Sub

    Private Sub radLongDate_CheckedChanged(sender As Object, e As EventArgs) Handles radLongDate.CheckedChanged
        Dim longDate As String = Format(Now, "Long Date")
        lblDate.Text = longDate
    End Sub
End Class