﻿Public Class Info
    Private Sub Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Info_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub


End Class