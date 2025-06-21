<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm))
        btnExit = New Button()
        Label4 = New Label()
        txbFName = New TextBox()
        Label7 = New Label()
        Label1 = New Label()
        txbEmail = New TextBox()
        Label2 = New Label()
        txbLName = New TextBox()
        Label3 = New Label()
        Label5 = New Label()
        cmbGender = New ComboBox()
        dateTime = New DateTimePicker()
        Label6 = New Label()
        txbUsername = New TextBox()
        Label8 = New Label()
        txbPassword = New TextBox()
        btnClear = New Button()
        btnNext = New Button()
        Label9 = New Label()
        txbConfirmPass = New TextBox()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Honeydew
        btnExit.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(1011, 26)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(44, 29)
        btnExit.TabIndex = 5
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        Label4.Location = New Point(65, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 19)
        Label4.TabIndex = 12
        Label4.Text = "FIRST NAME:"
        ' 
        ' txbFName
        ' 
        txbFName.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbFName.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        txbFName.Location = New Point(177, 201)
        txbFName.Name = "txbFName"
        txbFName.Size = New Size(301, 27)
        txbFName.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.WhiteSmoke
        Label7.Font = New Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(480, 115)
        Label7.Name = "Label7"
        Label7.Size = New Size(115, 27)
        Label7.TabIndex = 16
        Label7.Text = "REGISTER"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        Label1.Location = New Point(570, 209)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 19)
        Label1.TabIndex = 18
        Label1.Text = "EMAIL ADDRESS:"
        ' 
        ' txbEmail
        ' 
        txbEmail.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbEmail.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        txbEmail.Location = New Point(704, 203)
        txbEmail.Name = "txbEmail"
        txbEmail.Size = New Size(301, 27)
        txbEmail.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        Label2.Location = New Point(65, 271)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 19)
        Label2.TabIndex = 20
        Label2.Text = "LAST NAME:"
        ' 
        ' txbLName
        ' 
        txbLName.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbLName.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        txbLName.Location = New Point(177, 268)
        txbLName.Name = "txbLName"
        txbLName.Size = New Size(301, 27)
        txbLName.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        Label3.Location = New Point(98, 339)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 19)
        Label3.TabIndex = 22
        Label3.Text = "GENDER:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.WhiteSmoke
        Label5.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        Label5.Location = New Point(81, 412)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 19)
        Label5.TabIndex = 24
        Label5.Text = "BIRTHDAY:"
        ' 
        ' cmbGender
        ' 
        cmbGender.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        cmbGender.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female", "Prefer not to say"})
        cmbGender.Location = New Point(177, 337)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(301, 27)
        cmbGender.TabIndex = 25
        cmbGender.Text = "select gender"
        ' 
        ' dateTime
        ' 
        dateTime.CalendarFont = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dateTime.CalendarForeColor = Color.Teal
        dateTime.CalendarMonthBackground = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        dateTime.CalendarTitleBackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        dateTime.CalendarTitleForeColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        dateTime.CalendarTrailingForeColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        dateTime.Format = DateTimePickerFormat.Short
        dateTime.Location = New Point(179, 405)
        dateTime.Name = "dateTime"
        dateTime.Size = New Size(299, 27)
        dateTime.TabIndex = 26
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.WhiteSmoke
        Label6.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        Label6.Location = New Point(605, 279)
        Label6.Name = "Label6"
        Label6.Size = New Size(95, 19)
        Label6.TabIndex = 28
        Label6.Text = "USERNAME:"
        ' 
        ' txbUsername
        ' 
        txbUsername.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbUsername.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        txbUsername.Location = New Point(704, 273)
        txbUsername.Name = "txbUsername"
        txbUsername.Size = New Size(301, 27)
        txbUsername.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.WhiteSmoke
        Label8.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        Label8.Location = New Point(601, 345)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 19)
        Label8.TabIndex = 30
        Label8.Text = "PASSWORD:"
        ' 
        ' txbPassword
        ' 
        txbPassword.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbPassword.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        txbPassword.Location = New Point(704, 339)
        txbPassword.Name = "txbPassword"
        txbPassword.Size = New Size(301, 27)
        txbPassword.TabIndex = 29
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.WhiteSmoke
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Image = CType(resources.GetObject("btnClear.Image"), Image)
        btnClear.Location = New Point(704, 476)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(158, 41)
        btnClear.TabIndex = 31
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.WhiteSmoke
        btnNext.FlatAppearance.BorderSize = 0
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNext.Image = CType(resources.GetObject("btnNext.Image"), Image)
        btnNext.Location = New Point(864, 476)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(158, 41)
        btnNext.TabIndex = 32
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.WhiteSmoke
        Label9.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        Label9.Location = New Point(531, 413)
        Label9.Name = "Label9"
        Label9.Size = New Size(169, 19)
        Label9.TabIndex = 34
        Label9.Text = "CONFIRM PASSWORD:"
        ' 
        ' txbConfirmPass
        ' 
        txbConfirmPass.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbConfirmPass.Font = New Font("Gadugi", 9F, FontStyle.Bold)
        txbConfirmPass.Location = New Point(704, 407)
        txbConfirmPass.Name = "txbConfirmPass"
        txbConfirmPass.Size = New Size(301, 27)
        txbConfirmPass.TabIndex = 33
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1078, 602)
        Controls.Add(Label9)
        Controls.Add(txbConfirmPass)
        Controls.Add(btnNext)
        Controls.Add(btnClear)
        Controls.Add(Label8)
        Controls.Add(txbPassword)
        Controls.Add(Label6)
        Controls.Add(txbUsername)
        Controls.Add(dateTime)
        Controls.Add(cmbGender)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txbLName)
        Controls.Add(Label1)
        Controls.Add(txbEmail)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(txbFName)
        Controls.Add(btnExit)
        FormBorderStyle = FormBorderStyle.None
        Name = "RegistrationForm"
        Text = "RegistrationForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txbFName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txbLName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents dateTime As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txbUsername As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txbPassword As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txbConfirmPass As TextBox
End Class
