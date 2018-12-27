Public Class frm5
    Dim price As Double
    Dim unit As Double
    Dim nPro As String
    Dim decTotal, discount, totaldiscount, totalprice As Double
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        nPro = txtProduct.Text
        If txtProduct.Text = "" Or txtPrice.Text = "" Or txtUnit.Text = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
        Else
            If radMember.Checked = True Then
                If radPaid.Checked = True Then

                    If decTotal < 1000 Then
                        discount = 0
                        totaldiscount = discount
                        totalprice = decTotal - totaldiscount
                    ElseIf decTotal < 5000 Then
                        discount = 0.05
                        totaldiscount = decTotal * discount
                        totalprice = decTotal - totaldiscount
                    ElseIf decTotal < 10000 Then
                        discount = 0.1
                        totaldiscount = decTotal * discount
                        totalprice = decTotal - totaldiscount
                    Else
                        discount = 0.15
                        totaldiscount = decTotal * discount
                        totalprice = decTotal - totaldiscount



                    End If
                    lblDiscount.Text = totaldiscount
                    lblPaid.Text = totalprice
                    lblCredit.Text = "ไม่มีค่าค้างชำระ"
                ElseIf radCredit.Checked = True Then
                    lblDiscount.Text = "ไม่มีส่วนลด"
                    lblPaid.Text = decTotal
                    lblCredit.Text = decTotal

                End If
            ElseIf radOther.Checked = True Then
                lblPaid.Text = decTotal
                lblDiscount.Text = "ไม่มีส่วนลด"
                lblCredit.Text = "ไม่มีเงินเชื่อ"

            End If
        End If

    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        lblTotal.Text = txtPrice.Text
    End Sub

    Private Sub lblTotal_TextChanged(sender As Object, e As EventArgs) Handles lblTotal.TextChanged

    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        price = Val(txtPrice.Text)
        unit = Val(txtUnit.Text)
        decTotal = price * unit
        lblTotal.Text = decTotal
    End Sub

    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        If radMember.Checked = True Then
            gpbPaid.Enabled = True
        End If


    End Sub

    Private Sub radOther_CheckedChanged(sender As Object, e As EventArgs) Handles radOther.CheckedChanged

        gpbPaid.Enabled = False
        radPaid.Checked = True



    End Sub

    Private Sub radPaid_CheckedChanged(sender As Object, e As EventArgs) Handles radPaid.CheckedChanged

    End Sub

    Private Sub radCredit_CheckedChanged(sender As Object, e As EventArgs) Handles radCredit.CheckedChanged

    End Sub
End Class