Public Class frmLab7
    Private Sub frmLab7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        LstAdd.Items.Add(txtAdd.Text)
        LstAdd.SelectedIndex = LstAdd.Items.Count - 1
        txtAdd.Clear()

    End Sub

    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text <> "" Then
            btnAdd.Enabled = True
        Else
            btnAdd.Enabled = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        LstAdd.Items.Clear()
        txtAdd.Clear()
        cboOutput.Items.Clear()
        cboOutput.Text = ""
        lblOutput.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Dim a, b As Integer
        a = LstAdd.Items.Count
        If a = 0 Then
            MessageBox.Show("ไม่ไดเลือกรายการใน ListBox")
        Else
            cboOutput.Items.Add(LstAdd.SelectedItem)
            b = LstAdd.SelectedIndex
            If LstAdd.SelectedIndex = LstAdd.Items.Count - 1 Then
                LstAdd.Items.RemoveAt(LstAdd.SelectedIndex)
                LstAdd.SelectedIndex = LstAdd.Items.Count - 1
            Else
                LstAdd.Items.RemoveAt(LstAdd.SelectedIndex)
                LstAdd.SelectedIndex = b
            End If
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim a, b As Integer
        a = cboOutput.Items.Count
        If a < 1 Then
            MessageBox.Show("ไม่ได้เลือกรายการใน ComboBox")
        Else
            cboOutput.Text = ""
            LstAdd.Items.Add(cboOutput.SelectedItem)
            ' b = ListBox1.SelectedIndex
            ' If ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1 Then
            ' ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex)
            ' ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1
            ' Else
            'ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex)
            'ComboBox1.SelectedIndex = b
            'End If
            cboOutput.Items.Remove(cboOutput.SelectedItem)
            LstAdd.SelectedIndex = LstAdd.Items.Count - 1
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
        End If
        lblOutput.Text = cboOutput.SelectedItem

    End Sub

    Private Sub btnMoveAll_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        Dim a As Integer
        a = LstAdd.Items.Count
        If a < 1 Then
            MessageBox.Show("ไม่มีรายการใน ListBox")
        Else
            For aa = 1 To LstAdd.Items.Count
                cboOutput.Items.Add(LstAdd.SelectedItem)
                LstAdd.Items.RemoveAt(LstAdd.SelectedIndex)
                LstAdd.SelectedIndex = LstAdd.Items.Count - 1
                cboOutput.SelectedIndex = cboOutput.Items.Count - 1
            Next
            lblOutput.Text = cboOutput.SelectedItem
        End If
    End Sub

    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click
        Dim b As Integer
        b = cboOutput.Items.Count
        If b < 1 Then
            MessageBox.Show("ไม่มีรายการใน ComboBox")
        Else
            For bb = 1 To cboOutput.Items.Count
                LstAdd.Items.Add(cboOutput.SelectedItem)
                cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)
                cboOutput.SelectedIndex = cboOutput.Items.Count - 1
                LstAdd.SelectedIndex = LstAdd.Items.Count - 1
            Next
            cboOutput.Text = ""
            lblOutput.Text = cboOutput.SelectedItem
        End If
    End Sub

    Private Sub cboOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOutput.SelectedIndexChanged
        lblOutput.Text = cboOutput.SelectedItem
    End Sub
End Class