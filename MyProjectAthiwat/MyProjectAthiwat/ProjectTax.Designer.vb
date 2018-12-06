<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectTax
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lbltotalSalary = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.tax = New System.Windows.Forms.Label()
        Me.Salary = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(440, 353)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "ปิด"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(347, 353)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(75, 23)
        Me.btnCal.TabIndex = 26
        Me.btnCal.Text = "คำนวณ"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(450, 276)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 23
        Me.lblTotal.Text = " "
        '
        'lbltotalSalary
        '
        Me.lbltotalSalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbltotalSalary.Location = New System.Drawing.Point(450, 187)
        Me.lbltotalSalary.Name = "lbltotalSalary"
        Me.lbltotalSalary.Size = New System.Drawing.Size(100, 23)
        Me.lbltotalSalary.TabIndex = 24
        Me.lbltotalSalary.Text = " "
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTax.Location = New System.Drawing.Point(450, 234)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 25
        Me.lblTax.Text = " "
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(450, 143)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(100, 20)
        Me.txtSalary.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(242, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 30)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "รวมรายได้ทั้งปี"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'total
        '
        Me.total.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.total.Location = New System.Drawing.Point(242, 276)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(180, 30)
        Me.total.TabIndex = 19
        Me.total.Text = "เงินได้คงเหลือหลังหักภาษี"
        Me.total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tax
        '
        Me.tax.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tax.Location = New System.Drawing.Point(242, 234)
        Me.tax.Name = "tax"
        Me.tax.Size = New System.Drawing.Size(180, 30)
        Me.tax.TabIndex = 20
        Me.tax.Text = "ภาษีที่ต้องชำระ"
        Me.tax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Salary
        '
        Me.Salary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Salary.Location = New System.Drawing.Point(242, 137)
        Me.Salary.Name = "Salary"
        Me.Salary.Size = New System.Drawing.Size(180, 30)
        Me.Salary.TabIndex = 21
        Me.Salary.Text = "เงินเดือน"
        Me.Salary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "โปรแกรมคำนวณรายได้ทั้งปี"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProjectTax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lbltotalSalary)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.tax)
        Me.Controls.Add(Me.Salary)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ProjectTax"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnCal As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lbltotalSalary As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents total As Label
    Friend WithEvents tax As Label
    Friend WithEvents Salary As Label
    Friend WithEvents Label1 As Label
End Class
