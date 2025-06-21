Public Class RegistrationForm
    Public Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txbConfirmPass.Clear()
        txbEmail.Clear()
        txbFName.Clear()
        txbLName.Clear()
        txbPassword.Clear()
        txbUsername.Clear()
        cmbGender.SelectedIndex = 0
        dateTime.Value = DateAndTime.Now

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim confirmPass As String = txbConfirmPass.Text
        Dim email As String = txbEmail.Text
        Dim FName As String = txbFName.Text
        Dim LName As String = txbLName.Text
        Dim username As String = txbUsername.Text
        Dim password As String = txbPassword.Text
        Dim gender As String = cmbGender.Text
        Dim birthday As String = dateTime.Value.ToString("yyyy/MM/dd")


        SalaryAllocationForm.Show()
        Me.Hide()
    End Sub
End Class