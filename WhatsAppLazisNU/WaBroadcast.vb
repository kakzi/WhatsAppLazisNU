Imports System.Data.OleDb
Imports System.IO
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome

Public Class WaBroadcast
    Dim Driver As IWebDriver
    Dim list As New List(Of String)()
    Dim listNama As New List(Of String)()

    Private Function cekAlert() As Boolean
        Try
            Driver.SwitchTo.Alert()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub addToList()
        list.Clear()
        For i As Integer = 0 To Dgv.Rows.Count - 1
            list.Add(Dgv.Rows(i).Cells("DgvWA").Value)
        Next
        'For i As Integer = 0 To Dgv.Rows.Count - 1
        'list.Add(Dgv.Rows(i).Cells("DgvStatus").Value = "")
        'Next
    End Sub

    Private Sub addToListNama()
        listNama.Clear()
        For i As Integer = 0 To Dgv.Rows.Count - 1
            listNama.Add(Dgv.Rows(i).Cells("DgvNama").Value)
        Next
        'For i As Integer = 0 To Dgv.Rows.Count - 1
        'list.Add(Dgv.Rows(i).Cells("DgvStatus").Value = "")
        'Next
        'yyyyyyy
    End Sub


    Private Sub WaBroadcast_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        txtPathImage.ReadOnly = True
        txtPathFile.ReadOnly = True
        chkImageCaption.Enabled = False
        txtCaption.Enabled = False
        txtPesan.Enabled = True
        btnOpenFile.Enabled = False
        btnOpenImage.Enabled = False
        btnSend.Enabled = False

    End Sub

    Private Sub WaBroadcast_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If btnStart.Text = "Start" Then
            Driver = New ChromeDriver
            Driver.Navigate().GoToUrl("https://web.whatsapp.com/")
            btnStart.Text = "Stop"
            btnSend.Enabled = True
        Else
            Driver.Quit()
            btnStart.Text = "Start"
            btnSend.Enabled = False
        End If
    End Sub


    Private Sub chkGambar_CheckedChanged(sender As Object, e As EventArgs) Handles chkGambar.CheckedChanged
        If chkGambar.Checked = True Then
            btnOpenImage.Enabled = True
            chkImageCaption.Enabled = True
        Else
            txtPathImage.Clear()
            btnOpenImage.Enabled = False
            chkImageCaption.Enabled = False
            chkImageCaption.Checked = False
            picBox.Image = Nothing
        End If
    End Sub

    Private Sub chkImageCaption_CheckedChanged(sender As Object, e As EventArgs) Handles chkImageCaption.CheckedChanged
        If chkImageCaption.Checked = True Then
            txtCaption.Enabled = True
        Else
            txtCaption.Enabled = False
            txtCaption.Clear()

        End If
    End Sub

    Private Sub btnOpenImage_Click(sender As Object, e As EventArgs) Handles btnOpenImage.Click
        OFD.Title = "Pilih file gambar untuk di kirim"
        OFD.Multiselect = False
        OFD.Filter = "Image Files (*.png *.jpg *.bmp)| *.png; *.jpg; *.bmp"

        If OFD.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtPathImage.Text = OFD.FileName

            Dim myFile As String
            For Each myFile In Me.OFD.FileNames
                Dim myStream As FileStream = New FileStream(myFile, FileMode.Open, FileAccess.Read)
                Dim myImageBuffer(myStream.Length) As Byte
                myStream.Read(myImageBuffer, 0, Convert.ToInt32(myStream.Length))
                myStream.Close()
                Dim Streamed As New System.IO.MemoryStream(myImageBuffer)
                picBox.Image = Image.FromStream(Streamed)
                Streamed.Close()
                myImageBuffer = Nothing
            Next
        End If
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        OFD.Title = "Pilih file untuk di kirim"
        OFD.Multiselect = False
        OFD.Filter = "All files (*.*)|*.*"

        If OFD.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtPathFile.Text = OFD.FileName
        End If
    End Sub

    Private Sub btnImportExcel_Click(sender As Object, e As EventArgs) Handles btnImportExcel.Click
        Dim CONN As OleDbConnection
        Dim DA As OleDbDataAdapter
        Dim DS As New DataSet

        On Error Resume Next
        OFD.Title = "Pilih file Excel"
        OFD.Multiselect = False
        OFD.Filter = "(*.xlsx)|*.xlsx|(*.xls)|*.xls|All files(*.*)|*.*"

        If OFD.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            CONN = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source='" & OFD.FileName & "';Extended Properties=Excel 12.0;")

            DA = New OleDbDataAdapter("select * from [Sheet1$]", CONN)
            CONN.Open()
            DS.Clear()
            DA.Fill(DS)
            Dgv.Rows.Clear()

            For i As Integer = 0 To DS.Tables(0).Rows.Count - 1
                Dgv.Rows.Add()
                Dgv.Rows(Dgv.Rows.Count - 1).Cells("DgvWA").Value = DS.Tables(0).Rows(i).Item("Nomor WA")
                Dgv.Rows(Dgv.Rows.Count - 1).Cells("DgvNama").Value = DS.Tables(0).Rows(i).Item("Nama")
            Next
            CONN.Close()

        End If



    End Sub

    Private Sub chkFile_CheckedChanged(sender As Object, e As EventArgs) Handles chkFile.CheckedChanged
        If chkFile.Checked = True Then
            btnOpenFile.Enabled = True
        Else
            txtPathFile.Clear()
            btnOpenFile.Enabled = False
        End If
    End Sub
    Private Sub WhatsAppBroadcast()
        progressBar.Value = 0
        progressBar.Maximum = list.Count
        txtProses.Text = "0 / " & list.Count




        For i As Integer = 0 To list.Count - 1
            'Text 
            Dim text As String = txtPesan.Text
            Dim txtMesagge As String = text.Replace("Nama", Dgv.Rows(i).Cells("DgvNama").Value)
            'Text Image with Caption
            Dim text2 As String = txtCaption.Text
            Dim txtCaptions As String = text2.Replace("Nama", Dgv.Rows(i).Cells("DgvNama").Value)
            'intervalmessage
            Dim interval As Integer = txtInterval.Text * 1000

            Dim URL As String = "https://web.whatsapp.com/send?phone=" & list(i) & "&text=" & txtMesagge & "&source&data&app_absent"
            Driver.Navigate().GoToUrl(URL)

            If cekAlert() = True Then Driver.SwitchTo.Alert.Accept()

            Try
                Threading.Thread.Sleep(interval)
                'CEK JIKA NOMOR TERDAFTAR
                If txtPesan.Text <> Nothing Then
                    Threading.Thread.Sleep(4000)
                    Driver.FindElement(By.CssSelector("span[data-icon='send']")).Click()
                    'Driver.FindElement(By.CssSelector("button[class='_1E0Oz']")).Click()
                End If
                'Kirim gambar
                If chkGambar.Checked = True Then
                    'To send attachments
                    'click to add
                    Driver.FindElement(By.CssSelector("span[data-icon='clip']")).Click()
                    'add file to send by file path
                    Driver.FindElement(By.CssSelector("input[type='file']")).SendKeys(txtPathImage.Text)
                    'click to send
                    'Driver.FindElement(By.CssSelector("span[data-icon='send-light']")).Click()
                    'Driver.FindElement(By.CssSelector("span[data-icon='clip']")).Click()
                    'Driver.FindElement(By.CssSelector("input[accept='image/*,video/mp4,video/3gp,video/quicktime']")).SendKeys(txtPathImage.Text)

                    'kirim gambar dengan caption
                    If chkImageCaption.Checked = True Then
                        Threading.Thread.Sleep(2000)
                        Driver.FindElement(By.CssSelector("div[contenteditable='true']")).SendKeys(txtCaptions)
                    End If

                    Threading.Thread.Sleep(2000)
                    Driver.FindElement(By.CssSelector("span[data-icon='send']")).Click()
                    Threading.Thread.Sleep(4000)
                End If
                'kirim file ya
                If chkFile.Checked = True Then
                    Driver.FindElement(By.CssSelector("span[data-icon='clip']")).Click()
                    'Doc
                    'Driver.FindElement(By.CssSelector("input[accept='*']")).SendKeys(txtPathFile.Text)
                    Driver.FindElement(By.CssSelector("input[type='file' i]")).SendKeys(txtPathFile.Text)
                    Threading.Thread.Sleep(2000)
                    Driver.FindElement(By.CssSelector("span[data-icon='send']")).Click()
                    Threading.Thread.Sleep(4000)

                End If


                'If i = list.Count Then
                'Driver.FindElement(By.CssSelector("span[data-icon='send']")).Click()
                'End If

                Dgv.Rows(i).Cells("DgvStatus").Value = "Success"

            Catch ex As Exception
                Dgv.Rows(i).Cells("DgvStatus").Value = "Failed"
            End Try

            progressBar.Value = i + 1
            txtProses.Text = i + 1 & "/" & list.Count
        Next

    End Sub
    Private Sub BGW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW.DoWork
        Call WhatsAppBroadcast()
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Call addToList()
        Call addToListNama()
        BGW.RunWorkerAsync()
    End Sub


End Class