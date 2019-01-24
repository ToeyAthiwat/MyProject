Public Class frmJob6
    Private Sub ChkForme_Click(sender As Object, e As EventArgs) Handles ChkForme.Click
        Dim Free1, Free2, Free3 As Integer
        Free1 = 25000
        Free2 = 15000
        Free3 = 35000
        If ChkForme.Checked = True Then

            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            lblPaidPrice.Text = lblStartPrice.Text + Free1 + Free2 + Free3
        Else

            If MessageBox.Show("ต้องการยกเลิกหรือไม่", "แจ้งเตือน !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                ChkForme.Checked = False
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                ChkItemAdd1.Checked = False
                ChkItemAdd2.Checked = False
                ChkItemAdd3.Checked = False
                ChkItemAdd4.Checked = False
                ChkFree1.Checked = False
                ChkFree2.Checked = False
                ChkFree3.Checked = False
                lblPaidPrice.Text = 0
            Else
                ChkForme.Checked = True
            End If
        End If

    End Sub

    Private Sub frmJob6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
    End Sub

    Private Sub ChkFree1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFree1.CheckedChanged
        If ChkFree1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree1.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree1.Text)
        End If
    End Sub

    Private Sub ChkFree2_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFree2.CheckedChanged
        If ChkFree2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree2.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree2.Text)
        End If
    End Sub

    Private Sub ChkFree3_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFree3.CheckedChanged
        If ChkFree3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree3.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree3.Text)
        End If
    End Sub

    Private Sub ChkItemAdd1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkItemAdd1.CheckedChanged
        If ChkItemAdd1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemPrice1.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemPrice1.Text)
        End If
    End Sub

    Private Sub ChkItemAdd2_CheckedChanged(sender As Object, e As EventArgs) Handles ChkItemAdd2.CheckedChanged
        If ChkItemAdd2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemPrice2.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemPrice2.Text)
        End If
    End Sub

    Private Sub ChkItemAdd3_CheckedChanged(sender As Object, e As EventArgs) Handles ChkItemAdd3.CheckedChanged
        If ChkItemAdd3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemPrice3.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemPrice3.Text)
        End If
    End Sub

    Private Sub ChkItemAdd4_CheckedChanged(sender As Object, e As EventArgs) Handles ChkItemAdd4.CheckedChanged
        If ChkItemAdd4.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemPrice4.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemPrice4.Text)
        End If
    End Sub

    Private Sub ChkForme_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

End Class