<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        btnExit = New Button()
        Panel2 = New Panel()
        btnWithdraw = New Button()
        btnPayDebts = New Button()
        btnDashboard = New Button()
        btnLogExpenses = New Button()
        btnViewRec = New Button()
        btnEditSalary = New Button()
        btnAllocationSetting = New Button()
        Panel3 = New Panel()
        pnlDashboard = New Panel()
        lblAllSavings = New Label()
        lblTotalSpent = New Label()
        lblMontlySalary = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel4 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        lblTotalSavings = New Label()
        lblDebts = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        lblMonthSavings = New Label()
        lblWants = New Label()
        lblNeeds = New Label()
        lblSalaryLeft = New Label()
        Panel5 = New Panel()
        pnlUpdateSalary = New Panel()
        Label12 = New Label()
        btnEnterSalary = New Button()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        txbSalary = New TextBox()
        pnlAllocationSettings = New Panel()
        btnDoneAlloc = New Button()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        btnPlanB = New Button()
        btnPlanA = New Button()
        txbRent = New TextBox()
        txbGroceries = New TextBox()
        Label27 = New Label()
        Label29 = New Label()
        Label25 = New Label()
        Label26 = New Label()
        txbUtilities = New TextBox()
        Label30 = New Label()
        Label31 = New Label()
        txbSubscription = New TextBox()
        txbMisc = New TextBox()
        Label32 = New Label()
        Label34 = New Label()
        txbTranspo = New TextBox()
        pnlLogExpenses = New Panel()
        Label28 = New Label()
        btnDone = New Button()
        pnlDebts = New Panel()
        lblDebtBudget = New Label()
        Label38 = New Label()
        Label33 = New Label()
        Button1 = New Button()
        Label35 = New Label()
        Label36 = New Label()
        Label37 = New Label()
        txbDebt = New TextBox()
        pnlWithdraw = New Panel()
        lblSavingsTotal = New Label()
        Label41 = New Label()
        Label42 = New Label()
        Button2 = New Button()
        Label43 = New Label()
        Label44 = New Label()
        Label45 = New Label()
        txbWithdraw = New TextBox()
        Panel2.SuspendLayout()
        pnlDashboard.SuspendLayout()
        Panel4.SuspendLayout()
        pnlUpdateSalary.SuspendLayout()
        pnlAllocationSettings.SuspendLayout()
        pnlLogExpenses.SuspendLayout()
        pnlDebts.SuspendLayout()
        pnlWithdraw.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Honeydew
        btnExit.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(1003, 28)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(44, 29)
        btnExit.TabIndex = 5
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(177), CByte(214), CByte(209))
        Panel2.Controls.Add(btnWithdraw)
        Panel2.Controls.Add(btnPayDebts)
        Panel2.Controls.Add(btnDashboard)
        Panel2.Controls.Add(btnLogExpenses)
        Panel2.Controls.Add(btnViewRec)
        Panel2.Controls.Add(btnEditSalary)
        Panel2.Controls.Add(btnAllocationSetting)
        Panel2.Location = New Point(-2, 104)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(271, 445)
        Panel2.TabIndex = 7
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.BackColor = Color.Transparent
        btnWithdraw.FlatAppearance.BorderSize = 0
        btnWithdraw.FlatStyle = FlatStyle.Flat
        btnWithdraw.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnWithdraw.Image = CType(resources.GetObject("btnWithdraw.Image"), Image)
        btnWithdraw.ImageAlign = ContentAlignment.MiddleLeft
        btnWithdraw.Location = New Point(3, 317)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(266, 53)
        btnWithdraw.TabIndex = 14
        btnWithdraw.Text = "                     WITHDRAW SAVINGS"
        btnWithdraw.TextAlign = ContentAlignment.MiddleLeft
        btnWithdraw.UseVisualStyleBackColor = False
        ' 
        ' btnPayDebts
        ' 
        btnPayDebts.BackColor = Color.Transparent
        btnPayDebts.FlatAppearance.BorderSize = 0
        btnPayDebts.FlatStyle = FlatStyle.Flat
        btnPayDebts.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPayDebts.Image = CType(resources.GetObject("btnPayDebts.Image"), Image)
        btnPayDebts.ImageAlign = ContentAlignment.MiddleLeft
        btnPayDebts.Location = New Point(5, 193)
        btnPayDebts.Name = "btnPayDebts"
        btnPayDebts.Size = New Size(266, 61)
        btnPayDebts.TabIndex = 13
        btnPayDebts.Text = "                      PAY DEBTS"
        btnPayDebts.TextAlign = ContentAlignment.MiddleLeft
        btnPayDebts.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), Image)
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(3, 11)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(268, 53)
        btnDashboard.TabIndex = 12
        btnDashboard.Text = "                     DASHBOARD"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnLogExpenses
        ' 
        btnLogExpenses.BackColor = Color.Transparent
        btnLogExpenses.FlatAppearance.BorderSize = 0
        btnLogExpenses.FlatStyle = FlatStyle.Flat
        btnLogExpenses.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogExpenses.Image = CType(resources.GetObject("btnLogExpenses.Image"), Image)
        btnLogExpenses.ImageAlign = ContentAlignment.MiddleLeft
        btnLogExpenses.Location = New Point(5, 129)
        btnLogExpenses.Name = "btnLogExpenses"
        btnLogExpenses.Padding = New Padding(9, 0, 0, 0)
        btnLogExpenses.Size = New Size(266, 53)
        btnLogExpenses.TabIndex = 11
        btnLogExpenses.Text = "                    LOG EXPENSES"
        btnLogExpenses.TextAlign = ContentAlignment.MiddleLeft
        btnLogExpenses.UseVisualStyleBackColor = False
        ' 
        ' btnViewRec
        ' 
        btnViewRec.BackColor = Color.Transparent
        btnViewRec.FlatAppearance.BorderSize = 0
        btnViewRec.FlatStyle = FlatStyle.Flat
        btnViewRec.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewRec.Image = CType(resources.GetObject("btnViewRec.Image"), Image)
        btnViewRec.ImageAlign = ContentAlignment.MiddleLeft
        btnViewRec.Location = New Point(2, 256)
        btnViewRec.Name = "btnViewRec"
        btnViewRec.Size = New Size(266, 53)
        btnViewRec.TabIndex = 10
        btnViewRec.Text = "                      VIEW RECORDS"
        btnViewRec.TextAlign = ContentAlignment.MiddleLeft
        btnViewRec.UseVisualStyleBackColor = False
        ' 
        ' btnEditSalary
        ' 
        btnEditSalary.BackColor = Color.Transparent
        btnEditSalary.FlatAppearance.BorderSize = 0
        btnEditSalary.FlatStyle = FlatStyle.Flat
        btnEditSalary.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditSalary.Image = CType(resources.GetObject("btnEditSalary.Image"), Image)
        btnEditSalary.ImageAlign = ContentAlignment.MiddleLeft
        btnEditSalary.Location = New Point(0, 70)
        btnEditSalary.Name = "btnEditSalary"
        btnEditSalary.Padding = New Padding(9, 0, 0, 0)
        btnEditSalary.Size = New Size(271, 53)
        btnEditSalary.TabIndex = 9
        btnEditSalary.Text = "                    EDIT SALARY"
        btnEditSalary.TextAlign = ContentAlignment.MiddleLeft
        btnEditSalary.UseVisualStyleBackColor = False
        ' 
        ' btnAllocationSetting
        ' 
        btnAllocationSetting.BackColor = Color.Transparent
        btnAllocationSetting.FlatAppearance.BorderSize = 0
        btnAllocationSetting.FlatStyle = FlatStyle.Flat
        btnAllocationSetting.Font = New Font("Gadugi", 8.5F, FontStyle.Bold)
        btnAllocationSetting.Image = CType(resources.GetObject("btnAllocationSetting.Image"), Image)
        btnAllocationSetting.ImageAlign = ContentAlignment.MiddleLeft
        btnAllocationSetting.Location = New Point(0, 379)
        btnAllocationSetting.Name = "btnAllocationSetting"
        btnAllocationSetting.Padding = New Padding(7, 0, 0, 0)
        btnAllocationSetting.Size = New Size(271, 66)
        btnAllocationSetting.TabIndex = 8
        btnAllocationSetting.Text = "                   ALLOCATION SETTING"
        btnAllocationSetting.TextAlign = ContentAlignment.MiddleLeft
        btnAllocationSetting.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(177), CByte(214), CByte(209))
        Panel3.Location = New Point(-2, 85)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1105, 24)
        Panel3.TabIndex = 7
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        pnlDashboard.Controls.Add(lblAllSavings)
        pnlDashboard.Controls.Add(lblTotalSpent)
        pnlDashboard.Controls.Add(lblMontlySalary)
        pnlDashboard.Controls.Add(Label5)
        pnlDashboard.Controls.Add(Label4)
        pnlDashboard.Controls.Add(Label3)
        pnlDashboard.Controls.Add(Panel4)
        pnlDashboard.Controls.Add(lblTotalSavings)
        pnlDashboard.Controls.Add(lblDebts)
        pnlDashboard.Controls.Add(Label8)
        pnlDashboard.Controls.Add(Label7)
        pnlDashboard.Controls.Add(Label6)
        pnlDashboard.Controls.Add(lblMonthSavings)
        pnlDashboard.Controls.Add(lblWants)
        pnlDashboard.Controls.Add(lblNeeds)
        pnlDashboard.Controls.Add(lblSalaryLeft)
        pnlDashboard.Controls.Add(Panel5)
        pnlDashboard.Location = New Point(290, 132)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(767, 280)
        pnlDashboard.TabIndex = 8
        pnlDashboard.Visible = False
        ' 
        ' lblAllSavings
        ' 
        lblAllSavings.AutoSize = True
        lblAllSavings.Font = New Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAllSavings.ForeColor = Color.Maroon
        lblAllSavings.Location = New Point(419, 215)
        lblAllSavings.Name = "lblAllSavings"
        lblAllSavings.Size = New Size(59, 27)
        lblAllSavings.TabIndex = 24
        lblAllSavings.Text = "0.00"
        ' 
        ' lblTotalSpent
        ' 
        lblTotalSpent.AutoSize = True
        lblTotalSpent.Font = New Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalSpent.ForeColor = Color.Maroon
        lblTotalSpent.Location = New Point(388, 184)
        lblTotalSpent.Name = "lblTotalSpent"
        lblTotalSpent.Size = New Size(59, 27)
        lblTotalSpent.TabIndex = 23
        lblTotalSpent.Text = "0.00"
        ' 
        ' lblMontlySalary
        ' 
        lblMontlySalary.AutoSize = True
        lblMontlySalary.Font = New Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMontlySalary.ForeColor = Color.Maroon
        lblMontlySalary.Location = New Point(66, 221)
        lblMontlySalary.Name = "lblMontlySalary"
        lblMontlySalary.Size = New Size(59, 27)
        lblMontlySalary.TabIndex = 22
        lblMontlySalary.Text = "0.00"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(19, 197)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 20)
        Label5.TabIndex = 21
        Label5.Text = "Monthly Salary :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(266, 190)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 20)
        Label4.TabIndex = 20
        Label4.Text = "Total Spent :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(660, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 23)
        Label3.TabIndex = 19
        Label3.Text = "Debts"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(177), CByte(214), CByte(209))
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(Label2)
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(767, 49)
        Panel4.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(44, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 23)
        Label1.TabIndex = 0
        Label1.Text = "SALARY LEFT "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(426, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 23)
        Label2.TabIndex = 1
        Label2.Text = "ALLOCATION"
        ' 
        ' lblTotalSavings
        ' 
        lblTotalSavings.AutoSize = True
        lblTotalSavings.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalSavings.Location = New Point(266, 221)
        lblTotalSavings.Name = "lblTotalSavings"
        lblTotalSavings.Size = New Size(120, 20)
        lblTotalSavings.TabIndex = 18
        lblTotalSavings.Text = "Total Savings :"
        ' 
        ' lblDebts
        ' 
        lblDebts.AutoSize = True
        lblDebts.Font = New Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDebts.ForeColor = Color.Firebrick
        lblDebts.Location = New Point(664, 109)
        lblDebts.Name = "lblDebts"
        lblDebts.Size = New Size(59, 27)
        lblDebts.TabIndex = 17
        lblDebts.Text = "0.00"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(531, 71)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 23)
        Label8.TabIndex = 16
        Label8.Text = "Savings"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(411, 71)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 23)
        Label7.TabIndex = 15
        Label7.Text = "Wants"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(275, 71)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 23)
        Label6.TabIndex = 14
        Label6.Text = "Needs"
        ' 
        ' lblMonthSavings
        ' 
        lblMonthSavings.AutoSize = True
        lblMonthSavings.Font = New Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMonthSavings.ForeColor = Color.Firebrick
        lblMonthSavings.Location = New Point(550, 109)
        lblMonthSavings.Name = "lblMonthSavings"
        lblMonthSavings.Size = New Size(59, 27)
        lblMonthSavings.TabIndex = 13
        lblMonthSavings.Text = "0.00"
        ' 
        ' lblWants
        ' 
        lblWants.AutoSize = True
        lblWants.Font = New Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWants.ForeColor = Color.Firebrick
        lblWants.Location = New Point(411, 109)
        lblWants.Name = "lblWants"
        lblWants.Size = New Size(59, 27)
        lblWants.TabIndex = 12
        lblWants.Text = "0.00"
        ' 
        ' lblNeeds
        ' 
        lblNeeds.AutoSize = True
        lblNeeds.Font = New Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNeeds.ForeColor = Color.Firebrick
        lblNeeds.Location = New Point(275, 109)
        lblNeeds.Name = "lblNeeds"
        lblNeeds.Size = New Size(59, 27)
        lblNeeds.TabIndex = 11
        lblNeeds.Text = "0.00"
        ' 
        ' lblSalaryLeft
        ' 
        lblSalaryLeft.AutoSize = True
        lblSalaryLeft.Font = New Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSalaryLeft.ForeColor = Color.Firebrick
        lblSalaryLeft.Location = New Point(66, 100)
        lblSalaryLeft.Name = "lblSalaryLeft"
        lblSalaryLeft.Size = New Size(85, 40)
        lblSalaryLeft.TabIndex = 10
        lblSalaryLeft.Text = "0.00"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.DarkGray
        Panel5.ForeColor = Color.Gainsboro
        Panel5.Location = New Point(238, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(2, 280)
        Panel5.TabIndex = 9
        ' 
        ' pnlUpdateSalary
        ' 
        pnlUpdateSalary.BackColor = Color.WhiteSmoke
        pnlUpdateSalary.Controls.Add(Label12)
        pnlUpdateSalary.Controls.Add(btnEnterSalary)
        pnlUpdateSalary.Controls.Add(Label9)
        pnlUpdateSalary.Controls.Add(Label10)
        pnlUpdateSalary.Controls.Add(Label11)
        pnlUpdateSalary.Controls.Add(txbSalary)
        pnlUpdateSalary.Location = New Point(470, 104)
        pnlUpdateSalary.Name = "pnlUpdateSalary"
        pnlUpdateSalary.Size = New Size(418, 445)
        pnlUpdateSalary.TabIndex = 9
        pnlUpdateSalary.Visible = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.WhiteSmoke
        Label12.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label12.Location = New Point(49, 77)
        Label12.Name = "Label12"
        Label12.Size = New Size(178, 17)
        Label12.TabIndex = 38
        Label12.Text = "Let's update your salary!"
        ' 
        ' btnEnterSalary
        ' 
        btnEnterSalary.BackColor = Color.WhiteSmoke
        btnEnterSalary.FlatAppearance.BorderSize = 0
        btnEnterSalary.FlatStyle = FlatStyle.Flat
        btnEnterSalary.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEnterSalary.Image = CType(resources.GetObject("btnEnterSalary.Image"), Image)
        btnEnterSalary.Location = New Point(246, 287)
        btnEnterSalary.Name = "btnEnterSalary"
        btnEnterSalary.Size = New Size(107, 34)
        btnEnterSalary.TabIndex = 37
        btnEnterSalary.Text = "Enter"
        btnEnterSalary.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.WhiteSmoke
        Label9.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ControlDarkDark
        Label9.Location = New Point(49, 225)
        Label9.Name = "Label9"
        Label9.Size = New Size(130, 17)
        Label9.TabIndex = 36
        Label9.Text = "Monthly Salary  ▲"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.WhiteSmoke
        Label10.Font = New Font("Cambria", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlDarkDark
        Label10.Location = New Point(49, 151)
        Label10.Name = "Label10"
        Label10.Size = New Size(245, 17)
        Label10.TabIndex = 35
        Label10.Text = "How much do you earn in a month?"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.WhiteSmoke
        Label11.Font = New Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(49, 56)
        Label11.Name = "Label11"
        Label11.Size = New Size(80, 21)
        Label11.TabIndex = 34
        Label11.Text = "Hey Pal!"
        ' 
        ' txbSalary
        ' 
        txbSalary.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbSalary.Font = New Font("Gadugi", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txbSalary.Location = New Point(49, 184)
        txbSalary.Name = "txbSalary"
        txbSalary.Size = New Size(319, 31)
        txbSalary.TabIndex = 33
        ' 
        ' pnlAllocationSettings
        ' 
        pnlAllocationSettings.BackColor = Color.WhiteSmoke
        pnlAllocationSettings.Controls.Add(btnDoneAlloc)
        pnlAllocationSettings.Controls.Add(Label15)
        pnlAllocationSettings.Controls.Add(Label14)
        pnlAllocationSettings.Controls.Add(Label13)
        pnlAllocationSettings.Controls.Add(Label16)
        pnlAllocationSettings.Controls.Add(Label17)
        pnlAllocationSettings.Controls.Add(Label18)
        pnlAllocationSettings.Controls.Add(Label19)
        pnlAllocationSettings.Controls.Add(Label20)
        pnlAllocationSettings.Controls.Add(Label21)
        pnlAllocationSettings.Controls.Add(Label22)
        pnlAllocationSettings.Controls.Add(Label23)
        pnlAllocationSettings.Controls.Add(Label24)
        pnlAllocationSettings.Controls.Add(btnPlanB)
        pnlAllocationSettings.Controls.Add(btnPlanA)
        pnlAllocationSettings.Location = New Point(390, 107)
        pnlAllocationSettings.Name = "pnlAllocationSettings"
        pnlAllocationSettings.Size = New Size(573, 442)
        pnlAllocationSettings.TabIndex = 10
        pnlAllocationSettings.Visible = False
        ' 
        ' btnDoneAlloc
        ' 
        btnDoneAlloc.BackColor = Color.WhiteSmoke
        btnDoneAlloc.FlatAppearance.BorderSize = 0
        btnDoneAlloc.FlatStyle = FlatStyle.Flat
        btnDoneAlloc.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDoneAlloc.Image = CType(resources.GetObject("btnDoneAlloc.Image"), Image)
        btnDoneAlloc.Location = New Point(450, 396)
        btnDoneAlloc.Name = "btnDoneAlloc"
        btnDoneAlloc.Size = New Size(107, 34)
        btnDoneAlloc.TabIndex = 61
        btnDoneAlloc.Text = "Done"
        btnDoneAlloc.UseVisualStyleBackColor = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.FromArgb(CByte(0), CByte(99), CByte(98))
        Label15.Font = New Font("Cambria", 6F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.White
        Label15.Location = New Point(377, 156)
        Label15.Name = "Label15"
        Label15.Size = New Size(37, 24)
        Label15.TabIndex = 60
        Label15.Text = "     15%" & vbCrLf & " Wants" & vbCrLf
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.FromArgb(CByte(98), CByte(171), CByte(171))
        Label14.Font = New Font("Cambria", 6F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.White
        Label14.Location = New Point(341, 241)
        Label14.Name = "Label14"
        Label14.Size = New Size(41, 24)
        Label14.TabIndex = 59
        Label14.Text = "    15%" & vbCrLf & " Savings"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(208))
        Label13.Font = New Font("Cambria", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.White
        Label13.Location = New Point(433, 228)
        Label13.Name = "Label13"
        Label13.Size = New Size(47, 30)
        Label13.TabIndex = 58
        Label13.Text = "  60%" & vbCrLf & " Needs"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(124))
        Label16.Font = New Font("Cambria", 6F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.White
        Label16.Location = New Point(335, 188)
        Label16.Name = "Label16"
        Label16.Size = New Size(37, 24)
        Label16.TabIndex = 57
        Label16.Text = "     15%" & vbCrLf & " Debts"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(208))
        Label17.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.White
        Label17.Location = New Point(175, 212)
        Label17.Name = "Label17"
        Label17.Size = New Size(53, 34)
        Label17.TabIndex = 56
        Label17.Text = "50%" & vbCrLf & " Needs"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.FromArgb(CByte(98), CByte(171), CByte(171))
        Label18.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.White
        Label18.Location = New Point(89, 237)
        Label18.Name = "Label18"
        Label18.Size = New Size(64, 34)
        Label18.TabIndex = 55
        Label18.Text = "30%" & vbCrLf & " Savings"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(124))
        Label19.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.White
        Label19.Location = New Point(103, 166)
        Label19.Name = "Label19"
        Label19.Size = New Size(53, 34)
        Label19.TabIndex = 54
        Label19.Text = "20%" & vbCrLf & " Wants"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.WhiteSmoke
        Label20.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label20.Location = New Point(390, 344)
        Label20.Name = "Label20"
        Label20.Size = New Size(58, 17)
        Label20.TabIndex = 53
        Label20.Text = "PLAN B"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.BackColor = Color.WhiteSmoke
        Label21.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label21.Location = New Point(130, 344)
        Label21.Name = "Label21"
        Label21.Size = New Size(58, 17)
        Label21.TabIndex = 52
        Label21.Text = "PLAN A"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.BackColor = Color.WhiteSmoke
        Label22.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label22.Location = New Point(41, 77)
        Label22.Name = "Label22"
        Label22.Size = New Size(237, 17)
        Label22.TabIndex = 51
        Label22.Text = "Choose among the choices below."
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.BackColor = Color.WhiteSmoke
        Label23.Font = New Font("Cambria", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = SystemColors.ControlDarkDark
        Label23.Location = New Point(41, 60)
        Label23.Name = "Label23"
        Label23.Size = New Size(275, 17)
        Label23.TabIndex = 50
        Label23.Text = "How do you want to divide your salary?"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.BackColor = Color.WhiteSmoke
        Label24.Font = New Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(41, 25)
        Label24.Name = "Label24"
        Label24.Size = New Size(168, 21)
        Label24.TabIndex = 49
        Label24.Text = "ALLOCATION PLAN"
        ' 
        ' btnPlanB
        ' 
        btnPlanB.BackColor = Color.WhiteSmoke
        btnPlanB.BackgroundImage = CType(resources.GetObject("btnPlanB.BackgroundImage"), Image)
        btnPlanB.FlatAppearance.BorderSize = 0
        btnPlanB.FlatStyle = FlatStyle.Flat
        btnPlanB.Location = New Point(292, 135)
        btnPlanB.Name = "btnPlanB"
        btnPlanB.Size = New Size(237, 195)
        btnPlanB.TabIndex = 48
        btnPlanB.UseVisualStyleBackColor = False
        ' 
        ' btnPlanA
        ' 
        btnPlanA.BackColor = Color.WhiteSmoke
        btnPlanA.BackgroundImage = CType(resources.GetObject("btnPlanA.BackgroundImage"), Image)
        btnPlanA.FlatAppearance.BorderSize = 0
        btnPlanA.FlatStyle = FlatStyle.Flat
        btnPlanA.Location = New Point(44, 135)
        btnPlanA.Name = "btnPlanA"
        btnPlanA.Size = New Size(225, 195)
        btnPlanA.TabIndex = 47
        btnPlanA.UseVisualStyleBackColor = False
        ' 
        ' txbRent
        ' 
        txbRent.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbRent.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        txbRent.Location = New Point(106, 133)
        txbRent.Name = "txbRent"
        txbRent.Size = New Size(245, 27)
        txbRent.TabIndex = 35
        ' 
        ' txbGroceries
        ' 
        txbGroceries.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbGroceries.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        txbGroceries.Location = New Point(106, 252)
        txbGroceries.Name = "txbGroceries"
        txbGroceries.Size = New Size(245, 27)
        txbGroceries.TabIndex = 37
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.BackColor = Color.WhiteSmoke
        Label27.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        Label27.Location = New Point(380, 256)
        Label27.Name = "Label27"
        Label27.Size = New Size(150, 19)
        Label27.TabIndex = 38
        Label27.Text = "TRANSPORTATION:"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.BackColor = Color.WhiteSmoke
        Label29.Font = New Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label29.Location = New Point(338, 28)
        Label29.Name = "Label29"
        Label29.Size = New Size(131, 21)
        Label29.TabIndex = 43
        Label29.Text = "LOG EXPENSES"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.BackColor = Color.WhiteSmoke
        Label25.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        Label25.Location = New Point(19, 200)
        Label25.Name = "Label25"
        Label25.Size = New Size(81, 19)
        Label25.TabIndex = 44
        Label25.Text = "UTILITIES:"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.BackColor = Color.WhiteSmoke
        Label26.Font = New Font("Cambria", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = SystemColors.ControlDarkDark
        Label26.Location = New Point(313, 53)
        Label26.Name = "Label26"
        Label26.Size = New Size(205, 17)
        Label26.TabIndex = 45
        Label26.Text = "Leave blank if not applicable."
        ' 
        ' txbUtilities
        ' 
        txbUtilities.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbUtilities.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        txbUtilities.Location = New Point(106, 194)
        txbUtilities.Name = "txbUtilities"
        txbUtilities.Size = New Size(245, 27)
        txbUtilities.TabIndex = 46
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.BackColor = Color.WhiteSmoke
        Label30.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        Label30.Location = New Point(23, 136)
        Label30.Name = "Label30"
        Label30.Size = New Size(52, 19)
        Label30.TabIndex = 47
        Label30.Text = "RENT:"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.BackColor = Color.WhiteSmoke
        Label31.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        Label31.Location = New Point(15, 260)
        Label31.Name = "Label31"
        Label31.Size = New Size(93, 19)
        Label31.TabIndex = 49
        Label31.Text = "GROCERIES:"
        ' 
        ' txbSubscription
        ' 
        txbSubscription.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbSubscription.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        txbSubscription.Location = New Point(535, 128)
        txbSubscription.Name = "txbSubscription"
        txbSubscription.Size = New Size(245, 27)
        txbSubscription.TabIndex = 50
        ' 
        ' txbMisc
        ' 
        txbMisc.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbMisc.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        txbMisc.Location = New Point(535, 192)
        txbMisc.Name = "txbMisc"
        txbMisc.Size = New Size(245, 27)
        txbMisc.TabIndex = 51
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.BackColor = Color.WhiteSmoke
        Label32.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        Label32.Location = New Point(381, 134)
        Label32.Name = "Label32"
        Label32.Size = New Size(120, 19)
        Label32.TabIndex = 52
        Label32.Text = "SUBSCRIPTION:"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.BackColor = Color.WhiteSmoke
        Label34.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        Label34.Location = New Point(380, 197)
        Label34.Name = "Label34"
        Label34.Size = New Size(138, 19)
        Label34.TabIndex = 54
        Label34.Text = "MISCELLANEOUS: "
        ' 
        ' txbTranspo
        ' 
        txbTranspo.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbTranspo.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        txbTranspo.Location = New Point(535, 252)
        txbTranspo.Name = "txbTranspo"
        txbTranspo.Size = New Size(245, 27)
        txbTranspo.TabIndex = 55
        ' 
        ' pnlLogExpenses
        ' 
        pnlLogExpenses.BackColor = Color.WhiteSmoke
        pnlLogExpenses.Controls.Add(Label28)
        pnlLogExpenses.Controls.Add(btnDone)
        pnlLogExpenses.Controls.Add(txbTranspo)
        pnlLogExpenses.Controls.Add(Label34)
        pnlLogExpenses.Controls.Add(Label32)
        pnlLogExpenses.Controls.Add(txbMisc)
        pnlLogExpenses.Controls.Add(txbSubscription)
        pnlLogExpenses.Controls.Add(Label31)
        pnlLogExpenses.Controls.Add(Label30)
        pnlLogExpenses.Controls.Add(txbUtilities)
        pnlLogExpenses.Controls.Add(Label26)
        pnlLogExpenses.Controls.Add(Label25)
        pnlLogExpenses.Controls.Add(Label29)
        pnlLogExpenses.Controls.Add(Label27)
        pnlLogExpenses.Controls.Add(txbGroceries)
        pnlLogExpenses.Controls.Add(txbRent)
        pnlLogExpenses.Location = New Point(267, 107)
        pnlLogExpenses.Name = "pnlLogExpenses"
        pnlLogExpenses.Size = New Size(812, 442)
        pnlLogExpenses.TabIndex = 11
        pnlLogExpenses.Visible = False
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.BackColor = Color.WhiteSmoke
        Label28.Font = New Font("Cambria", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label28.ForeColor = SystemColors.ControlDarkDark
        Label28.Location = New Point(28, 381)
        Label28.Name = "Label28"
        Label28.Size = New Size(502, 17)
        Label28.TabIndex = 56
        Label28.Text = "* Please take note that the expensess listed above will be counted as needs."
        ' 
        ' btnDone
        ' 
        btnDone.BackColor = Color.WhiteSmoke
        btnDone.FlatAppearance.BorderSize = 0
        btnDone.FlatStyle = FlatStyle.Flat
        btnDone.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDone.Image = CType(resources.GetObject("btnDone.Image"), Image)
        btnDone.Location = New Point(632, 320)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(158, 41)
        btnDone.TabIndex = 33
        btnDone.Text = "Done"
        btnDone.UseVisualStyleBackColor = False
        ' 
        ' pnlDebts
        ' 
        pnlDebts.BackColor = Color.WhiteSmoke
        pnlDebts.Controls.Add(lblDebtBudget)
        pnlDebts.Controls.Add(Label38)
        pnlDebts.Controls.Add(Label33)
        pnlDebts.Controls.Add(Button1)
        pnlDebts.Controls.Add(Label35)
        pnlDebts.Controls.Add(Label36)
        pnlDebts.Controls.Add(Label37)
        pnlDebts.Controls.Add(txbDebt)
        pnlDebts.Location = New Point(470, 107)
        pnlDebts.Name = "pnlDebts"
        pnlDebts.Size = New Size(418, 442)
        pnlDebts.TabIndex = 12
        pnlDebts.Visible = False
        ' 
        ' lblDebtBudget
        ' 
        lblDebtBudget.AutoSize = True
        lblDebtBudget.BackColor = Color.WhiteSmoke
        lblDebtBudget.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDebtBudget.ForeColor = Color.Firebrick
        lblDebtBudget.Location = New Point(195, 112)
        lblDebtBudget.Name = "lblDebtBudget"
        lblDebtBudget.Size = New Size(51, 23)
        lblDebtBudget.TabIndex = 46
        lblDebtBudget.Text = "0.00"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.BackColor = Color.WhiteSmoke
        Label38.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label38.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label38.Location = New Point(48, 117)
        Label38.Name = "Label38"
        Label38.Size = New Size(126, 17)
        Label38.TabIndex = 45
        Label38.Text = "Budget for debts:"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.BackColor = Color.WhiteSmoke
        Label33.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label33.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label33.Location = New Point(50, 60)
        Label33.Name = "Label33"
        Label33.Size = New Size(150, 17)
        Label33.TabIndex = 44
        Label33.Text = "Let's pay your debts!"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.WhiteSmoke
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(268, 364)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 34)
        Button1.TabIndex = 43
        Button1.Text = "Enter"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.BackColor = Color.WhiteSmoke
        Label35.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label35.ForeColor = SystemColors.ControlDarkDark
        Label35.Location = New Point(49, 257)
        Label35.Name = "Label35"
        Label35.Size = New Size(97, 17)
        Label35.TabIndex = 42
        Label35.Text = "Input here  ▲"
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.BackColor = Color.WhiteSmoke
        Label36.Font = New Font("Cambria", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label36.ForeColor = SystemColors.ControlDarkDark
        Label36.Location = New Point(48, 181)
        Label36.Name = "Label36"
        Label36.Size = New Size(217, 17)
        Label36.TabIndex = 41
        Label36.Text = "How much do you want to pay?"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.BackColor = Color.WhiteSmoke
        Label37.Font = New Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label37.Location = New Point(50, 39)
        Label37.Name = "Label37"
        Label37.Size = New Size(80, 21)
        Label37.TabIndex = 40
        Label37.Text = "Hey Pal!"
        ' 
        ' txbDebt
        ' 
        txbDebt.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbDebt.Font = New Font("Gadugi", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txbDebt.Location = New Point(48, 211)
        txbDebt.Name = "txbDebt"
        txbDebt.Size = New Size(326, 31)
        txbDebt.TabIndex = 39
        ' 
        ' pnlWithdraw
        ' 
        pnlWithdraw.BackColor = Color.WhiteSmoke
        pnlWithdraw.Controls.Add(lblSavingsTotal)
        pnlWithdraw.Controls.Add(Label41)
        pnlWithdraw.Controls.Add(Label42)
        pnlWithdraw.Controls.Add(Button2)
        pnlWithdraw.Controls.Add(Label43)
        pnlWithdraw.Controls.Add(Label44)
        pnlWithdraw.Controls.Add(Label45)
        pnlWithdraw.Controls.Add(txbWithdraw)
        pnlWithdraw.Location = New Point(470, 104)
        pnlWithdraw.Name = "pnlWithdraw"
        pnlWithdraw.Size = New Size(418, 445)
        pnlWithdraw.TabIndex = 13
        pnlWithdraw.Visible = False
        ' 
        ' lblSavingsTotal
        ' 
        lblSavingsTotal.AutoSize = True
        lblSavingsTotal.BackColor = Color.WhiteSmoke
        lblSavingsTotal.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSavingsTotal.ForeColor = Color.Firebrick
        lblSavingsTotal.Location = New Point(168, 116)
        lblSavingsTotal.Name = "lblSavingsTotal"
        lblSavingsTotal.Size = New Size(51, 23)
        lblSavingsTotal.TabIndex = 54
        lblSavingsTotal.Text = "0.00"
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.BackColor = Color.WhiteSmoke
        Label41.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label41.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label41.Location = New Point(46, 121)
        Label41.Name = "Label41"
        Label41.Size = New Size(104, 17)
        Label41.TabIndex = 53
        Label41.Text = "Total Savings:"
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.BackColor = Color.WhiteSmoke
        Label42.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label42.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label42.Location = New Point(48, 64)
        Label42.Name = "Label42"
        Label42.Size = New Size(206, 17)
        Label42.TabIndex = 52
        Label42.Text = "Let's withdraw your savings!"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.WhiteSmoke
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(266, 368)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 34)
        Button2.TabIndex = 51
        Button2.Text = "Enter"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.BackColor = Color.WhiteSmoke
        Label43.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label43.ForeColor = SystemColors.ControlDarkDark
        Label43.Location = New Point(47, 261)
        Label43.Name = "Label43"
        Label43.Size = New Size(97, 17)
        Label43.TabIndex = 50
        Label43.Text = "Input here  ▲"
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.BackColor = Color.WhiteSmoke
        Label44.Font = New Font("Cambria", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label44.ForeColor = SystemColors.ControlDarkDark
        Label44.Location = New Point(46, 185)
        Label44.Name = "Label44"
        Label44.Size = New Size(259, 17)
        Label44.TabIndex = 49
        Label44.Text = "How much do you want to withdraw?"
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.BackColor = Color.WhiteSmoke
        Label45.Font = New Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label45.Location = New Point(48, 43)
        Label45.Name = "Label45"
        Label45.Size = New Size(80, 21)
        Label45.TabIndex = 48
        Label45.Text = "Hey Pal!"
        ' 
        ' txbWithdraw
        ' 
        txbWithdraw.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbWithdraw.Font = New Font("Gadugi", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txbWithdraw.Location = New Point(46, 215)
        txbWithdraw.Name = "txbWithdraw"
        txbWithdraw.Size = New Size(326, 31)
        txbWithdraw.TabIndex = 47
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1078, 602)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(btnExit)
        Controls.Add(pnlDebts)
        Controls.Add(pnlLogExpenses)
        Controls.Add(pnlDashboard)
        Controls.Add(pnlUpdateSalary)
        Controls.Add(pnlAllocationSettings)
        Controls.Add(pnlWithdraw)
        FormBorderStyle = FormBorderStyle.None
        Name = "DashboardForm"
        Text = "DashboardForm"
        Panel2.ResumeLayout(False)
        pnlDashboard.ResumeLayout(False)
        pnlDashboard.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        pnlUpdateSalary.ResumeLayout(False)
        pnlUpdateSalary.PerformLayout()
        pnlAllocationSettings.ResumeLayout(False)
        pnlAllocationSettings.PerformLayout()
        pnlLogExpenses.ResumeLayout(False)
        pnlLogExpenses.PerformLayout()
        pnlDebts.ResumeLayout(False)
        pnlDebts.PerformLayout()
        pnlWithdraw.ResumeLayout(False)
        pnlWithdraw.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAllocationSetting As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnLogExpenses As Button
    Friend WithEvents btnViewRec As Button
    Friend WithEvents btnEditSalary As Button
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblMonthSavings As Label
    Friend WithEvents lblWants As Label
    Friend WithEvents lblNeeds As Label
    Friend WithEvents lblSalaryLeft As Label
    Friend WithEvents lblTotalSavings As Label
    Friend WithEvents lblDebts As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMontlySalary As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblAllSavings As Label
    Friend WithEvents lblTotalSpent As Label
    Friend WithEvents pnlUpdateSalary As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents btnEnterSalary As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txbSalary As TextBox
    Friend WithEvents pnlAllocationSettings As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents btnPlanB As Button
    Friend WithEvents btnPlanA As Button
    Friend WithEvents btnDoneAlloc As Button
    Friend WithEvents txbRent As TextBox
    Friend WithEvents txbGroceries As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txbUtilities As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txbSubscription As TextBox
    Friend WithEvents txbMisc As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents txbTranspo As TextBox
    Friend WithEvents pnlLogExpenses As Panel
    Friend WithEvents btnDone As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnPayDebts As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents pnlDebts As Panel
    Friend WithEvents lblDebtBudget As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents txbDebt As TextBox
    Friend WithEvents pnlWithdraw As Panel
    Friend WithEvents lblSavingsTotal As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents txbWithdraw As TextBox
End Class
