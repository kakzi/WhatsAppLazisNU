
Public Class LoginInterface
    Dim webService As New System.Net.WebClient

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please all forms cannot be empty!", MsgBoxStyle.Information, "Attention")
        ElseIf txtUsername.Text = "" Then
            MsgBox("Username cannot be empty", MsgBoxStyle.Information, "Attenton")
        ElseIf txtPassword.Text = "" Then
            MsgBox("Password cannot be empty", MsgBoxStyle.Information, "Attenton")
        Else
            Dim result As String = webService.DownloadString("http://apiwhatsapp.newsnasional.site/api.php?action=login&username=" + txtUsername.Text + "&password=" + txtPassword.Text)
            If result = "success" Then
                MsgBox("Login Success, Welcome " & txtUsername.Text & "!", MsgBoxStyle.Information, "Successfull Login")
                HomeScreen.Show()
                Me.Hide()
            ElseIf result = "error" Then
                MsgBox("Username or Password is wrong, check again!",
                       MsgBoxStyle.Exclamation, "Error Login")
            End If
        End If
    End Sub

    Private Sub btnExitonLogin_Click(sender As Object, e As EventArgs) Handles btnExitonLogin.Click
        Application.Exit()
    End Sub

    Private Sub LoginInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDateonLogin.Text = Today
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub timeOnLogin_Tick(sender As Object, e As EventArgs) Handles timeOnLogin.Tick
        txtTimeonLogin.Text = TimeOfDay
    End Sub
End Class