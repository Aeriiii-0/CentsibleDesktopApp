<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalaryAllocationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalaryAllocationForm))
        txbSalary = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnEnterSalary = New Button()
        btnPlanA = New Button()
        btnPlanB = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        pnlAllocationPlan = New Panel()
        Button3 = New Button()
        Button1 = New Button()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        pnlGreat = New Panel()
        SuspendLayout()
        ' 
        ' txbSalary
        ' 
        txbSalary.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbSalary.Font = New Font("Gadugi", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txbSalary.Location = New Point(52, 236)
        txbSalary.Name = "txbSalary"
        txbSalary.Size = New Size(301, 31)
        txbSalary.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.Font = New Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(52, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 21)
        Label1.TabIndex = 15
        Label1.Text = "Hey Pal!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.Font = New Font("Cambria", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(52, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(245, 17)
        Label2.TabIndex = 16
        Label2.Text = "How much do you earn in a month?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.Font = New Font("Cambria", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(52, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 17)
        Label3.TabIndex = 17
        Label3.Text = "Monthly Salary:"
        ' 
        ' btnEnterSalary
        ' 
        btnEnterSalary.BackColor = Color.WhiteSmoke
        btnEnterSalary.FlatAppearance.BorderSize = 0
        btnEnterSalary.FlatStyle = FlatStyle.Flat
        btnEnterSalary.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEnterSalary.Image = CType(resources.GetObject("btnEnterSalary.Image"), Image)
        btnEnterSalary.Location = New Point(246, 289)
        btnEnterSalary.Name = "btnEnterSalary"
        btnEnterSalary.Size = New Size(107, 34)
        btnEnterSalary.TabIndex = 32
        btnEnterSalary.Text = "Enter"
        btnEnterSalary.UseVisualStyleBackColor = False
        ' 
        ' btnPlanA
        ' 
        btnPlanA.BackColor = Color.WhiteSmoke
        btnPlanA.BackgroundImage = CType(resources.GetObject("btnPlanA.BackgroundImage"), Image)
        btnPlanA.FlatAppearance.BorderSize = 0
        btnPlanA.FlatStyle = FlatStyle.Flat
        btnPlanA.Location = New Point(487, 236)
        btnPlanA.Name = "btnPlanA"
        btnPlanA.Size = New Size(225, 195)
        btnPlanA.TabIndex = 33
        btnPlanA.UseVisualStyleBackColor = False
        ' 
        ' btnPlanB
        ' 
        btnPlanB.BackColor = Color.WhiteSmoke
        btnPlanB.BackgroundImage = CType(resources.GetObject("btnPlanB.BackgroundImage"), Image)
        btnPlanB.FlatAppearance.BorderSize = 0
        btnPlanB.FlatStyle = FlatStyle.Flat
        btnPlanB.Location = New Point(735, 236)
        btnPlanB.Name = "btnPlanB"
        btnPlanB.Size = New Size(237, 195)
        btnPlanB.TabIndex = 34
        btnPlanB.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.Font = New Font("Cambria", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlDarkDark
        Label4.Location = New Point(601, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(275, 17)
        Label4.TabIndex = 36
        Label4.Text = "How do you want to divide your salary?"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.WhiteSmoke
        Label5.Font = New Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(651, 116)
        Label5.Name = "Label5"
        Label5.Size = New Size(168, 21)
        Label5.TabIndex = 35
        Label5.Text = "ALLOCATION PLAN"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.WhiteSmoke
        Label6.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label6.Location = New Point(601, 166)
        Label6.Name = "Label6"
        Label6.Size = New Size(237, 17)
        Label6.TabIndex = 37
        Label6.Text = "Choose among the choices below."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.WhiteSmoke
        Label7.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label7.Location = New Point(573, 445)
        Label7.Name = "Label7"
        Label7.Size = New Size(58, 17)
        Label7.TabIndex = 38
        Label7.Text = "PLAN A"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.WhiteSmoke
        Label8.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label8.Location = New Point(833, 445)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 17)
        Label8.TabIndex = 39
        Label8.Text = "PLAN B"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(124))
        Label9.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(546, 267)
        Label9.Name = "Label9"
        Label9.Size = New Size(53, 34)
        Label9.TabIndex = 40
        Label9.Text = "20%" & vbCrLf & " Wants"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.FromArgb(CByte(98), CByte(171), CByte(171))
        Label10.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(532, 338)
        Label10.Name = "Label10"
        Label10.Size = New Size(64, 34)
        Label10.TabIndex = 41
        Label10.Text = "30%" & vbCrLf & " Savings"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(208))
        Label11.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(618, 313)
        Label11.Name = "Label11"
        Label11.Size = New Size(53, 34)
        Label11.TabIndex = 42
        Label11.Text = "50%" & vbCrLf & " Needs"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(124))
        Label12.Font = New Font("Cambria", 6F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(778, 289)
        Label12.Name = "Label12"
        Label12.Size = New Size(37, 24)
        Label12.TabIndex = 43
        Label12.Text = "     15%" & vbCrLf & " Debts"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(208))
        Label13.Font = New Font("Cambria", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.White
        Label13.Location = New Point(876, 329)
        Label13.Name = "Label13"
        Label13.Size = New Size(47, 30)
        Label13.TabIndex = 44
        Label13.Text = "  60%" & vbCrLf & " Needs"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.FromArgb(CByte(98), CByte(171), CByte(171))
        Label14.Font = New Font("Cambria", 6F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.White
        Label14.Location = New Point(784, 342)
        Label14.Name = "Label14"
        Label14.Size = New Size(41, 24)
        Label14.TabIndex = 45
        Label14.Text = "    15%" & vbCrLf & " Savings"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.FromArgb(CByte(0), CByte(99), CByte(98))
        Label15.Font = New Font("Cambria", 6F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.White
        Label15.Location = New Point(820, 257)
        Label15.Name = "Label15"
        Label15.Size = New Size(37, 24)
        Label15.TabIndex = 46
        Label15.Text = "     15%" & vbCrLf & " Wants" & vbCrLf
        ' 
        ' pnlAllocationPlan
        ' 
        pnlAllocationPlan.BackColor = Color.WhiteSmoke
        pnlAllocationPlan.Location = New Point(456, 101)
        pnlAllocationPlan.Name = "pnlAllocationPlan"
        pnlAllocationPlan.Size = New Size(557, 411)
        pnlAllocationPlan.TabIndex = 47
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.WhiteSmoke
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(868, 550)
        Button3.Name = "Button3"
        Button3.Size = New Size(198, 43)
        Button3.TabIndex = 48
        Button3.Text = "     Go to Dashboard"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Honeydew
        Button1.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1012, 26)
        Button1.Name = "Button1"
        Button1.Size = New Size(44, 29)
        Button1.TabIndex = 49
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.WhiteSmoke
        Label16.Font = New Font("Cambria", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = SystemColors.ControlDarkDark
        Label16.Location = New Point(52, 411)
        Label16.Name = "Label16"
        Label16.Size = New Size(304, 34)
        Label16.TabIndex = 51
        Label16.Text = "Now, we'll suggest you plans to allocate your" & vbCrLf & " monthly plans. Choose wisely!" & vbCrLf
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.WhiteSmoke
        Label17.Font = New Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(52, 379)
        Label17.Name = "Label17"
        Label17.Size = New Size(63, 21)
        Label17.TabIndex = 50
        Label17.Text = "Great!"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.WhiteSmoke
        Label18.Font = New Font("Cambria", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label18.Location = New Point(274, 485)
        Label18.Name = "Label18"
        Label18.Size = New Size(91, 17)
        Label18.TabIndex = 52
        Label18.Text = "Look here   >"
        ' 
        ' pnlGreat
        ' 
        pnlGreat.BackColor = Color.WhiteSmoke
        pnlGreat.Location = New Point(31, 369)
        pnlGreat.Name = "pnlGreat"
        pnlGreat.Size = New Size(366, 143)
        pnlGreat.TabIndex = 48
        ' 
        ' SalaryAllocationForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1078, 602)
        Controls.Add(pnlAllocationPlan)
        Controls.Add(pnlGreat)
        Controls.Add(Label18)
        Controls.Add(Label16)
        Controls.Add(Label17)
        Controls.Add(Button1)
        Controls.Add(Button3)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(btnPlanB)
        Controls.Add(btnPlanA)
        Controls.Add(btnEnterSalary)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txbSalary)
        FormBorderStyle = FormBorderStyle.None
        Name = "SalaryAllocationForm"
        Text = "SalaryAllocationForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txbSalary As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEnterSalary As Button
    Friend WithEvents btnPlanA As Button
    Friend WithEvents btnPlanB As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents pnlAllocationPlan As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents pnlGreat As Panel
End Class
