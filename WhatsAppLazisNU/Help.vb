Public Class Help
    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Help_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub


End Class