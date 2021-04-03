
Public Class HomeScreen
    Private Sub btnWaBroadcast_Click(sender As Object, e As EventArgs) Handles btnWaBroadcast.Click
        btnWaBroadcast.BackColor = Color.FromArgb(0, 171, 68)
        btnDashboard.BackColor = Color.FromArgb(0, 148, 59)
        btnHelp.BackColor = Color.FromArgb(0, 148, 59)
        btnInfo.BackColor = Color.FromArgb(0, 148, 59)
        btnTOS.BackColor = Color.FromArgb(0, 148, 59)
        With WaBroadcast
            .TopLevel = False
            panelMenu.Controls.Add(WaBroadcast)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub HomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDashboard.BackColor = Color.FromArgb(0, 171, 68)
        With Dashboard
            .TopLevel = False
            panelMenu.Controls.Add(Dashboard)
            .BringToFront()
            .Show()
        End With
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ExitDialog.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        btnDashboard.BackColor = Color.FromArgb(0, 171, 68)
        btnWaBroadcast.BackColor = Color.FromArgb(0, 148, 59)
        btnHelp.BackColor = Color.FromArgb(0, 148, 59)
        btnInfo.BackColor = Color.FromArgb(0, 148, 59)
        btnTOS.BackColor = Color.FromArgb(0, 148, 59)
        With Dashboard
            .TopLevel = False
            panelMenu.Controls.Add(Dashboard)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        btnHelp.BackColor = Color.FromArgb(0, 171, 68)
        btnWaBroadcast.BackColor = Color.FromArgb(0, 148, 59)
        btnDashboard.BackColor = Color.FromArgb(0, 148, 59)
        btnInfo.BackColor = Color.FromArgb(0, 148, 59)
        btnTOS.BackColor = Color.FromArgb(0, 148, 59)
        With Help
            .TopLevel = False
            panelMenu.Controls.Add(Help)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        btnInfo.BackColor = Color.FromArgb(0, 171, 68)
        btnWaBroadcast.BackColor = Color.FromArgb(0, 148, 59)
        btnDashboard.BackColor = Color.FromArgb(0, 148, 59)
        btnHelp.BackColor = Color.FromArgb(0, 148, 59)
        btnTOS.BackColor = Color.FromArgb(0, 148, 59)
        With Info
            .TopLevel = False
            panelMenu.Controls.Add(Info)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnTOS_Click(sender As Object, e As EventArgs) Handles btnTOS.Click
        btnTOS.BackColor = Color.FromArgb(0, 171, 68)
        btnWaBroadcast.BackColor = Color.FromArgb(0, 148, 59)
        btnInfo.BackColor = Color.FromArgb(0, 148, 59)
        btnDashboard.BackColor = Color.FromArgb(0, 148, 59)
        btnHelp.BackColor = Color.FromArgb(0, 148, 59)
        With Tos
            .TopLevel = False
            panelMenu.Controls.Add(Tos)
            .BringToFront()
            .Show()
        End With
    End Sub


End Class
