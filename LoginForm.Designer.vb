<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        btnExit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txbUsername = New TextBox()
        txbPassword = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        btnLogIn = New Button()
        chkbShowPassword = New CheckBox()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Honeydew
        btnExit.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(1004, 29)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(44, 29)
        btnExit.TabIndex = 4
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.Font = New Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(43, 208)
        Label1.Name = "Label1"
        Label1.Size = New Size(372, 72)
        Label1.TabIndex = 5
        Label1.Text = "Split it into needs, wants, and savings." & vbCrLf & "Track your income with ease." & vbCrLf & "Make every cent count." & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.Font = New Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(43, 318)
        Label2.Name = "Label2"
        Label2.Size = New Size(352, 38)
        Label2.TabIndex = 6
        Label2.Text = "Take control of your money—budget with intention." & vbCrLf & "Start your journey with Centsible today." & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.Font = New Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(43, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 20)
        Label3.TabIndex = 7
        Label3.Text = "APP OVERVIEW"
        ' 
        ' txbUsername
        ' 
        txbUsername.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbUsername.Location = New Point(664, 221)
        txbUsername.Name = "txbUsername"
        txbUsername.Size = New Size(328, 27)
        txbUsername.TabIndex = 8
        ' 
        ' txbPassword
        ' 
        txbPassword.BackColor = Color.FromArgb(CByte(216), CByte(238), CByte(235))
        txbPassword.Location = New Point(664, 295)
        txbPassword.Name = "txbPassword"
        txbPassword.Size = New Size(328, 27)
        txbPassword.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.Font = New Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(565, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 20)
        Label4.TabIndex = 10
        Label4.Text = "Username:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.WhiteSmoke
        Label5.Font = New Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(565, 298)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 20)
        Label5.TabIndex = 11
        Label5.Text = "Password:"
        ' 
        ' btnLogIn
        ' 
        btnLogIn.BackColor = Color.WhiteSmoke
        btnLogIn.FlatAppearance.BorderSize = 0
        btnLogIn.FlatStyle = FlatStyle.Flat
        btnLogIn.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogIn.Image = CType(resources.GetObject("btnLogIn.Image"), Image)
        btnLogIn.Location = New Point(664, 373)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(158, 41)
        btnLogIn.TabIndex = 12
        btnLogIn.Text = "Log-in"
        btnLogIn.UseVisualStyleBackColor = False
        ' 
        ' chkbShowPassword
        ' 
        chkbShowPassword.AutoSize = True
        chkbShowPassword.BackColor = Color.WhiteSmoke
        chkbShowPassword.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkbShowPassword.Location = New Point(871, 331)
        chkbShowPassword.Name = "chkbShowPassword"
        chkbShowPassword.Size = New Size(121, 21)
        chkbShowPassword.TabIndex = 13
        chkbShowPassword.Text = "show password"
        chkbShowPassword.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.WhiteSmoke
        Label7.Font = New Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(773, 147)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 24)
        Label7.TabIndex = 15
        Label7.Text = "LOG-IN"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1078, 602)
        Controls.Add(Label7)
        Controls.Add(chkbShowPassword)
        Controls.Add(btnLogIn)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txbPassword)
        Controls.Add(txbUsername)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txbUsername As TextBox
    Friend WithEvents txbPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLogIn As Button
    Friend WithEvents chkbShowPassword As CheckBox
    Friend WithEvents Label7 As Label
End Class
