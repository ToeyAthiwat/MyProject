<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab8
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstSubJect = New System.Windows.Forms.ListBox()
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.lstCredit = New System.Windows.Forms.ListBox()
        Me.lstGrade = New System.Windows.Forms.ListBox()
        Me.txtSubJect = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblOldtotalScore = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblOldtotalCredit = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblOldGPA = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNewGPA = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณเกรดเฉลี่ยสะสม"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 35)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รายการ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(146, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 35)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "คะแนนสอบ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(280, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 35)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "หน่วยกิต"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(413, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 35)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เกรด"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstSubJect
        '
        Me.lstSubJect.FormattingEnabled = True
        Me.lstSubJect.Location = New System.Drawing.Point(14, 77)
        Me.lstSubJect.Name = "lstSubJect"
        Me.lstSubJect.Size = New System.Drawing.Size(125, 186)
        Me.lstSubJect.TabIndex = 1
        '
        'lstScore
        '
        Me.lstScore.FormattingEnabled = True
        Me.lstScore.Location = New System.Drawing.Point(149, 77)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(125, 186)
        Me.lstScore.TabIndex = 1
        '
        'lstCredit
        '
        Me.lstCredit.FormattingEnabled = True
        Me.lstCredit.Location = New System.Drawing.Point(283, 77)
        Me.lstCredit.Name = "lstCredit"
        Me.lstCredit.Size = New System.Drawing.Size(125, 186)
        Me.lstCredit.TabIndex = 1
        '
        'lstGrade
        '
        Me.lstGrade.FormattingEnabled = True
        Me.lstGrade.Location = New System.Drawing.Point(416, 77)
        Me.lstGrade.Name = "lstGrade"
        Me.lstGrade.Size = New System.Drawing.Size(125, 186)
        Me.lstGrade.TabIndex = 1
        '
        'txtSubJect
        '
        Me.txtSubJect.Location = New System.Drawing.Point(14, 269)
        Me.txtSubJect.Name = "txtSubJect"
        Me.txtSubJect.Size = New System.Drawing.Size(126, 20)
        Me.txtSubJect.TabIndex = 2
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(149, 269)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(126, 20)
        Me.txtScore.TabIndex = 2
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(282, 269)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(126, 20)
        Me.txtCredit.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(416, 267)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(61, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(480, 267)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(61, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "คะแนนสะสมก่อนหน้า"
        '
        'lblOldtotalScore
        '
        Me.lblOldtotalScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblOldtotalScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOldtotalScore.Location = New System.Drawing.Point(126, 307)
        Me.lblOldtotalScore.Name = "lblOldtotalScore"
        Me.lblOldtotalScore.Size = New System.Drawing.Size(56, 29)
        Me.lblOldtotalScore.TabIndex = 5
        Me.lblOldtotalScore.Text = "150"
        Me.lblOldtotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(211, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "หน่วยกิตสะสม"
        '
        'lblOldtotalCredit
        '
        Me.lblOldtotalCredit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblOldtotalCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOldtotalCredit.Location = New System.Drawing.Point(299, 307)
        Me.lblOldtotalCredit.Name = "lblOldtotalCredit"
        Me.lblOldtotalCredit.Size = New System.Drawing.Size(56, 29)
        Me.lblOldtotalCredit.TabIndex = 5
        Me.lblOldtotalCredit.Text = "50"
        Me.lblOldtotalCredit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(382, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "เกรดเฉลี่ยสะสม"
        '
        'lblOldGPA
        '
        Me.lblOldGPA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblOldGPA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOldGPA.Location = New System.Drawing.Point(470, 307)
        Me.lblOldGPA.Name = "lblOldGPA"
        Me.lblOldGPA.Size = New System.Drawing.Size(56, 29)
        Me.lblOldGPA.TabIndex = 5
        Me.lblOldGPA.Text = "3.00"
        Me.lblOldGPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(94, 358)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(199, 26)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "เกรดเฉลี่ยสะสมภาคปัจจุบัน"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNewGPA
        '
        Me.lblNewGPA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNewGPA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNewGPA.Location = New System.Drawing.Point(299, 355)
        Me.lblNewGPA.Name = "lblNewGPA"
        Me.lblNewGPA.Size = New System.Drawing.Size(82, 29)
        Me.lblNewGPA.TabIndex = 5
        Me.lblNewGPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmLab8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(553, 403)
        Me.Controls.Add(Me.lblOldGPA)
        Me.Controls.Add(Me.lblOldtotalCredit)
        Me.Controls.Add(Me.lblNewGPA)
        Me.Controls.Add(Me.lblOldtotalScore)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtSubJect)
        Me.Controls.Add(Me.lstGrade)
        Me.Controls.Add(Me.lstCredit)
        Me.Controls.Add(Me.lstScore)
        Me.Controls.Add(Me.lstSubJect)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab8"
        Me.Text = "frmLab8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lstSubJect As ListBox
    Friend WithEvents lstScore As ListBox
    Friend WithEvents lstCredit As ListBox
    Friend WithEvents lstGrade As ListBox
    Friend WithEvents txtSubJect As TextBox
    Friend WithEvents txtScore As TextBox
    Friend WithEvents txtCredit As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblOldtotalScore As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblOldtotalCredit As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblOldGPA As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNewGPA As Label
End Class
