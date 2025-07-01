Public Class SalaryAllocationForm
    Private Sub btnEnterSalary_Click(sender As Object, e As EventArgs) Handles btnEnterSalary.Click
        Dim salary As Double = txbSalary.Text
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

    Private Sub btnPlanA_Click(sender As Object, e As EventArgs) Handles btnPlanA.Click
        'Plan a computation + display
    End Sub

    Private Sub btnPlanB_Click(sender As Object, e As EventArgs) Handles btnPlanB.Click
        'plan b computation + display
    End Sub
End Class