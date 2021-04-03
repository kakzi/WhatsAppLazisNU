Public Class Dashboard
    Private Sub timerOnDashboard_Tick(sender As Object, e As EventArgs) Handles timerOnDashboard.Tick
        txtTimeinDashboard.Text = TimeOfDay
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDateonDashboard.Text = Today
    End Sub

    Private Sub Dashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub


End Class