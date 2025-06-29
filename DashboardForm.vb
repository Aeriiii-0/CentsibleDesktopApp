Public Class DashboardForm

    Public AccountID As Integer
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        DashboardPanels()
    End Sub

    Private Sub btnEditSalary_Click(sender As Object, e As EventArgs) Handles btnEditSalary.Click
        pnlUpdateSalary.Visible = True
        pnlDashboard.Visible = False
        pnlAllocationSettings.Visible = False
        pnlDebts.Visible = False
        pnlLogExpenses.Visible = False
    End Sub

    Private Sub btnDoneAlloc_Click(sender As Object, e As EventArgs) Handles btnDoneAlloc.Click
        MessageBox.Show("Budget Allocation Updated!", "Notification")
        DashboardPanels()
    End Sub

    Private Sub btnAllocationSetting_Click(sender As Object, e As EventArgs) Handles btnAllocationSetting.Click
        pnlAllocationSettings.Visible = True
        pnlUpdateSalary.Visible = False
        pnlDashboard.Visible = False
        pnlDebts.Visible = False
        pnlLogExpenses.Visible = False
        pnlWithdraw.Visible = False

    End Sub

    Private Sub DashboardPanels()
        pnlDashboard.Visible = True
        pnlUpdateSalary.Visible = False
        pnlAllocationSettings.Visible = False
        pnlDebts.Visible = False
        pnlLogExpenses.Visible = False
        pnlWithdraw.Visible = False

        lblMontlySalary.Text = GlobalData.GetSalary(AccountID)



    End Sub

    Private Sub btnEnterSalary_Click(sender As Object, e As EventArgs) Handles btnEnterSalary.Click
        MessageBox.Show("Monthly Salary Updated!", "Notification")
        DashboardPanels()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        DashboardPanels()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Debt amount deducted!", "Notification")
        DashboardPanels()

    End Sub



    Private Sub btnLogExpenses_Click(sender As Object, e As EventArgs) Handles btnLogExpenses.Click
        pnlDebts.Visible = False
        pnlDashboard.Visible = False
        pnlUpdateSalary.Visible = False
        pnlAllocationSettings.Visible = False
        pnlLogExpenses.Visible = True
        pnlWithdraw.Visible = False
    End Sub

    Private Sub btnPayDebts_Click(sender As Object, e As EventArgs) Handles btnPayDebts.Click
        pnlDebts.Visible = True
        pnlDashboard.Visible = False
        pnlUpdateSalary.Visible = False
        pnlAllocationSettings.Visible = False
        pnlLogExpenses.Visible = False
        pnlWithdraw.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Amount Withdrawn!", "Notification")
        DashboardPanels()

    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        pnlWithdraw.Visible = True
        pnlDebts.Visible = False
        pnlDashboard.Visible = False
        pnlUpdateSalary.Visible = False
        pnlAllocationSettings.Visible = False
        pnlLogExpenses.Visible = False
    End Sub
End Class