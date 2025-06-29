Public Class SalaryAllocationForm
    Public AccountID As Integer
    Private salary As Double
    Private Sub btnEnterSalary_Click(sender As Object, e As EventArgs) Handles btnEnterSalary.Click
        salary = txbSalary.Text
        pnlGreat.Visible = False
        pnlAllocationPlan.Visible = False


    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DashboardForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub

    Private Sub btnPlanA_Click(sender As Object, e As EventArgs)

        If (salary > 0) Then
            GlobalData.AddSalary(AccountID, salary, "A")
            MessageBox.Show("Monthly Salary Updated!", "Notification")
            DashboardForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Error: Please enter a valid salary amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnPlanB_Click(sender As Object, e As EventArgs)
        If (salary > 0) Then
            GlobalData.AddSalary(AccountID, salary, "B")
            MessageBox.Show("Monthly Salary Updated!", "Notification")

            DashboardForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Error: Please enter a valid salary amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class