Public Class LoginForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim username As String = txbUsername.Text
        Dim password As String = txbPassword.Text

        'call account validation method if correct, next frame (dashboard)
        DashboardForm.Show()
        Me.Hide()
    End Sub

    Private Sub chkbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkbShowPassword.CheckedChanged
        'hide password 
    End Sub
End Class