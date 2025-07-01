Imports System.Drawing
Imports System.Windows.Forms

Public Class DashboardForm

    Private Sub HighlightActiveButton(clickedBtn As Button)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)
                btn.BackColor = SystemColors.Control
                btn.ForeColor = Color.DarkCyan
            End If
            If ctrl.HasChildren Then
                ResetNestedButtons(ctrl)
            End If
        Next

        clickedBtn.BackColor = ColorTranslator.FromHtml("#b1d6d1")
        clickedBtn.ForeColor = Color.White
    End Sub

    Private Sub ResetNestedButtons(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)
                btn.BackColor = SystemColors.Control
                btn.ForeColor = Color.DarkCyan
            End If
            If ctrl.HasChildren Then
                ResetNestedButtons(ctrl)
            End If
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        HighlightActiveButton(btnExit)
        Application.Exit()
    End Sub

    Private Sub btnDoneAlloc_Click(sender As Object, e As EventArgs) Handles btnDoneAlloc.Click
        HighlightActiveButton(btnDoneAlloc)
        MessageBox.Show("Budget Allocation Updated!", "Notification")
        DashboardPanels()
    End Sub

    Private Sub DashboardPanels()
        pnlDashboard.Visible = True
        pnlUpdateSalary.Visible = False
        pnlAllocationSettings.Visible = False
        pnlDebts.Visible = False
        pnlLogExpenses.Visible = False
        pnlWithdraw.Visible = False
        pnlDashButtons.Visible = True
        pnlDash.Visible = False
        pnlDashh.Visible = False
        pnlVieRecord.Visible = False
    End Sub

    Private Sub btnEnterSalary_Click(sender As Object, e As EventArgs) Handles btnEnterSalary.Click
        HighlightActiveButton(btnEnterSalary)
        MessageBox.Show("Monthly Salary Updated!", "Notification")
        DashboardPanels()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        HighlightActiveButton(btnDone)
        DashboardPanels()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HighlightActiveButton(Button1)
        MessageBox.Show("Debt amount deducted!", "Notification")
        DashboardPanels()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HighlightActiveButton(Button2)
        MessageBox.Show("Amount Withdrawn!", "Notification")
        DashboardPanels()
    End Sub

    Private Sub btnDashboard_Click_1(sender As Object, e As EventArgs) Handles btnDashboard.Click
        HighlightActiveButton(btnDashboard)
        DashboardPanels()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        HighlightActiveButton(btnLogout)
        HomePage.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogExp_Click(sender As Object, e As EventArgs) Handles btnLogExp.Click
        HighlightActiveButton(btnLogExp)
        pnlDebts.Visible = False
        pnlDashboard.Visible = False
        pnlUpdateSalary.Visible = False
        pnlAllocationSettings.Visible = False
        pnlLogExpenses.Visible = True
        pnlWithdraw.Visible = False
        pnlDashButtons.Visible = True
        pnlDash.Visible = False
        pnlDashh.Visible = False
        pnlVieRecord.Visible = False
    End Sub

    Private Sub btnPayDebts_Click_1(sender As Object, e As EventArgs) Handles btnPayDebts.Click
        HighlightActiveButton(btnPayDebts)
        pnlDebts.Visible = True
        pnlDashboard.Visible = False
        pnlUpdateSalary.Visible = False
        pnlAllocationSettings.Visible = False
        pnlLogExpenses.Visible = False
        pnlWithdraw.Visible = False
        pnlDashButtons.Visible = True
        pnlDashh.Visible = True
        pnlDash.Visible = True
        pnlVieRecord.Visible = False
    End Sub

    Private Sub btnAccSettings_Click(sender As Object, e As EventArgs) Handles btnAccSettings.Click
        HighlightActiveButton(btnAccSettings)
        pnlAllocationSettings.Visible = True
        pnlUpdateSalary.Visible = False
        pnlDashboard.Visible = False
        pnlDebts.Visible = False
        pnlLogExpenses.Visible = False
        pnlWithdraw.Visible = False
        pnlDashButtons.Visible = False
        pnlVieRecord.Visible = False
        pnlDashh.Visible = True
        pnlDash.Visible = True
    End Sub

    Private Sub btnEditSalary_Click(sender As Object, e As EventArgs) Handles btnEditSalary.Click
        HighlightActiveButton(btnEditSalary)
        pnlUpdateSalary.Visible = True
        pnlDashboard.Visible = False
        pnlAllocationSettings.Visible = False
        pnlDebts.Visible = False
        pnlLogExpenses.Visible = False
        pnlDashButtons.Visible = True
        pnlDashh.Visible = True
        pnlDash.Visible = True
        pnlVieRecord.Visible = False
    End Sub

    Private Sub btnWithdraww_Click(sender As Object, e As EventArgs) Handles btnWithdraww.Click
        HighlightActiveButton(btnWithdraww)
        pnlWithdraw.Visible = True
        pnlDebts.Visible = False
        pnlDashboard.Visible = False
        pnlUpdateSalary.Visible = False
        pnlAllocationSettings.Visible = False
        pnlLogExpenses.Visible = False
        pnlDashButtons.Visible = False
        pnlDashh.Visible = True
        pnlDash.Visible = True
        pnlVieRecord.Visible = False
    End Sub

    Private Sub btnViewRecords_Click(sender As Object, e As EventArgs) Handles btnViewRecords.Click
        HighlightActiveButton(btnViewRecords)
        pnlWithdraw.Visible = False
        pnlDebts.Visible = False
        pnlDashboard.Visible = False
        pnlUpdateSalary.Visible = False
        pnlAllocationSettings.Visible = False
        pnlLogExpenses.Visible = False
        pnlDashButtons.Visible = True
        pnlDashh.Visible = False
        pnlDash.Visible = False
        pnlVieRecord.Visible = True
    End Sub
End Class
