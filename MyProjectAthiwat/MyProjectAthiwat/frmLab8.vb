Public Class frmLab8
    Dim sumScore As Integer
    Dim sumCredit As Integer

    Private Sub frmLab8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intScore As Decimal = 150 'กำหนดตัวแปรให้ = 150
        Dim intCredit As Decimal = 50
        Dim intGPA As Decimal
        lblOldtotalScore.Text = intScore    'กำหนดlblช่องนี้มีค่าตามตัวที่แปรที่กำหนด
        lblOldtotalCredit.Text = intCredit
        intGPA = intScore / intCredit
        lblOldGPA.Text = FormatNumber(intGPA)

        lstSubJect.Items.Clear()
        lstScore.Items.Clear()
        lstCredit.Items.Clear()
        lstGrade.Items.Clear()

        txtSubJect.Clear()
        txtScore.Clear()
        txtCredit.Clear()
        lblNewGPA.Text = ""

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ss As String


        ss = getGrade(Val(txtScore.Text))

        If txtSubJect.Text = "" Or txtCredit.Text = "" Or txtScore.Text = "" Then
            MessageBox.Show("กรุณาป้อนใหม่")
            Exit Sub
        Else
            If Not IsNumeric(txtCredit.Text) Or Not IsNumeric(txtScore.Text) Then
                MessageBox.Show("กรุณาป้อนหมายเลขที่ถูกต้อง")
                Exit Sub
            End If
        End If

        lstSubJect.Items.Add(txtSubJect.Text) 'เมื่อเพิ่มข้อมูลใน Lst ให้ไปโชว์ใน Txt
        lstScore.Items.Add(txtScore.Text)
        lstCredit.Items.Add(txtCredit.Text)
        lstGrade.Items.Add(ss) 'Lst Grade มีค่าในฟังกชั่น getgrade


        lstSubJect.SelectedIndex = lstSubJect.Items.Count - 1 'เมือ Lst ถูกเลือก ให้ทำการลบ 1
        lstScore.SelectedIndex = lstScore.Items.Count - 1
        lstCredit.SelectedIndex = lstCredit.Items.Count - 1


        txtSubJect.Clear()
        txtScore.Clear()
        txtCredit.Clear()

        Call calData()

    End Sub

    Private Sub calData()
        Dim grade As String
        Dim douGR1, douGR2, douGR3, douGRTotal, sumGrade, i, douA, douB, douC As Double
        i = lstCredit.Items.Count
        For intGR = 0 To i - 1
            sumScore = lstScore.Items(intGR)
            sumCredit = lstCredit.Items(intGR)
            grade = lstGrade.Items(intGR)
            Select Case grade
                Case "A"
                    sumGrade = 4
                Case "B+"
                    sumGrade = 3.5
                Case "B"
                    sumGrade = 3
                Case "C+"
                    sumGrade = 2.5
                Case "C"
                    sumGrade = 2
                Case "D+"
                    sumGrade = 1.5
                Case "D"
                    sumGrade = 1
                Case "F"
                    sumGrade = 0
            End Select
            douA = sumCredit * sumGrade
            douB = douA + douB
            douC = sumCredit + douC
        Next

        douGR2 = lblOldtotalScore.Text + douB
        douGR3 = lblOldtotalCredit.Text + douC
        douGRTotal = douGR2 / douGR3

        lblNewGPA.Text = FormatNumber(douGRTotal)



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSubJect.Items.Clear()
        lstScore.Items.Clear()
        lstCredit.Items.Clear()
        lstGrade.Items.Clear()
    End Sub
    Public Function getGrade(score As Integer) As String

        Dim grade As String
        score = Val(txtScore.Text)
        If score >= 80 Then
            grade = "A"
        ElseIf score >= 75 Then
            grade = "B+"
        ElseIf score >= 70 Then
            grade = "B"
        ElseIf score >= 65 Then
            grade = "C+"
        ElseIf score >= 60 Then
            grade = "C"
        ElseIf score >= 55 Then
            grade = "D+"
        ElseIf score >= 50 Then
            grade = "D"
        Else
            grade = "F"

        End If

        Return grade
    End Function

    Private Sub lstSubJect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSubJect.SelectedIndexChanged
        lstScore.SelectedIndex = lstSubJect.SelectedIndex
        lstCredit.SelectedIndex = lstSubJect.SelectedIndex
        lstGrade.SelectedIndex = lstSubJect.SelectedIndex
    End Sub

    Private Sub lstScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstScore.SelectedIndexChanged
        lstSubJect.SelectedIndex = lstScore.SelectedIndex
        lstCredit.SelectedIndex = lstScore.SelectedIndex
        lstGrade.SelectedIndex = lstScore.SelectedIndex
    End Sub

    Private Sub lstCredit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCredit.SelectedIndexChanged
        lstSubJect.SelectedIndex = lstCredit.SelectedIndex
        lstScore.SelectedIndex = lstCredit.SelectedIndex
        lstGrade.SelectedIndex = lstCredit.SelectedIndex
    End Sub

    Private Sub lstGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGrade.SelectedIndexChanged
        lstScore.SelectedIndex = lstGrade.SelectedIndex
        lstSubJect.SelectedIndex = lstGrade.SelectedIndex
        lstCredit.SelectedIndex = lstGrade.SelectedIndex
    End Sub
End Class