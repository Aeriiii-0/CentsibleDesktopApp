<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        btnSignUp = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnSignUp
        ' 
        btnSignUp.FlatAppearance.BorderSize = 0
        btnSignUp.FlatStyle = FlatStyle.Flat
        btnSignUp.Image = CType(resources.GetObject("btnSignUp.Image"), Image)
        btnSignUp.Location = New Point(642, 338)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(259, 64)
        btnSignUp.TabIndex = 0
        btnSignUp.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.Font = New Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(617, 178)
        Label1.Name = "Label1"
        Label1.Size = New Size(372, 72)
        Label1.TabIndex = 1
        Label1.Text = "Split it into needs, wants, and savings." & vbCrLf & "Track your income with ease." & vbCrLf & "Make every cent count." & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.Font = New Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(617, 270)
        Label2.Name = "Label2"
        Label2.Size = New Size(352, 38)
        Label2.TabIndex = 2
        Label2.Text = "Take control of your money—budget with intention." & vbCrLf & "Start your journey with Centsible today." & vbCrLf
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Honeydew
        Button1.Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1013, 26)
        Button1.Name = "Button1"
        Button1.Size = New Size(44, 29)
        Button1.TabIndex = 3
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.Font = New Font("Cambria", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(715, 396)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 17)
        Label3.TabIndex = 4
        Label3.Text = "I have an account"
        ' 
        ' HomePage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1078, 602)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSignUp)
        FormBorderStyle = FormBorderStyle.None
        Name = "HomePage"
        Text = "HomePage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSignUp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
