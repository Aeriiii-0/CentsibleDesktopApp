Public Class LoginForm
    Private AccountID As Integer
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim username As String = txbUsername.Text
        Dim password As String = txbPassword.Text
        If username = "" Or password = "" Then
            MessageBox.Show("Error: Please enter both username and password")
            Return
        Else
            If (GlobalData.CheckLogin(username, password)) Then
                AccountID = Convert.ToInt16(GlobalData.GetAccountID(username))
                DashboardForm.AccountID = AccountID
                DashboardForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Error: Incorrect username or password")
            End If
        End If



    End Sub

    Private Sub chkbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkbShowPassword.CheckedChanged
        'hide password 
    End Sub
End Class