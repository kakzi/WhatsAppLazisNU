Public Class ExitDialog

    Private Sub btnCanceltoExit_Click(sender As Object, e As EventArgs) Handles btnCanceltoExit.Click
        Me.Hide()
        HomeScreen.Show()
    End Sub

    Private Sub btnConfirmtoExit_Click(sender As Object, e As EventArgs) Handles btnConfirmtoExit.Click
        Me.Hide()
        HomeScreen.Hide()
        LoginInterface.Show()
        LoginInterface.txtUsername.Text = ""
        LoginInterface.txtPassword.Text = ""
    End Sub
End Class