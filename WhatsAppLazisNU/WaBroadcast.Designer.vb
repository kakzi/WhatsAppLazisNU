<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WaBroadcast
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WaBroadcast))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtInterval = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCaption = New System.Windows.Forms.RichTextBox()
        Me.txtPesan = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProses = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.btnReset = New FontAwesome.Sharp.IconButton()
        Me.btnStart = New FontAwesome.Sharp.IconButton()
        Me.btnSend = New FontAwesome.Sharp.IconButton()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.txtPathFile = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkFile = New System.Windows.Forms.CheckBox()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.chkImageCaption = New System.Windows.Forms.CheckBox()
        Me.btnOpenImage = New System.Windows.Forms.Button()
        Me.txtPathImage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkGambar = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnImportExcel = New FontAwesome.Sharp.IconButton()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.DgvNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvWA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BGW = New System.ComponentModel.BackgroundWorker()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtInterval)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtCaption)
        Me.Panel1.Controls.Add(Me.txtPesan)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtProses)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.progressBar)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Controls.Add(Me.btnSend)
        Me.Panel1.Controls.Add(Me.btnOpenFile)
        Me.Panel1.Controls.Add(Me.txtPathFile)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.chkFile)
        Me.Panel1.Controls.Add(Me.picBox)
        Me.Panel1.Controls.Add(Me.chkImageCaption)
        Me.Panel1.Controls.Add(Me.btnOpenImage)
        Me.Panel1.Controls.Add(Me.txtPathImage)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.chkGambar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnImportExcel)
        Me.Panel1.Controls.Add(Me.Dgv)
        Me.Panel1.Location = New System.Drawing.Point(7, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(679, 527)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(556, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 15)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "*Required 5 Second"
        '
        'txtInterval
        '
        Me.txtInterval.BackColor = System.Drawing.Color.Honeydew
        Me.txtInterval.Location = New System.Drawing.Point(485, 12)
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.Size = New System.Drawing.Size(70, 23)
        Me.txtInterval.TabIndex = 69
        Me.txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(336, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 15)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Interval Message in second"
        '
        'txtCaption
        '
        Me.txtCaption.AutoWordSelection = True
        Me.txtCaption.BackColor = System.Drawing.Color.Honeydew
        Me.txtCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCaption.Location = New System.Drawing.Point(336, 236)
        Me.txtCaption.Name = "txtCaption"
        Me.txtCaption.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCaption.Size = New System.Drawing.Size(200, 121)
        Me.txtCaption.TabIndex = 67
        Me.txtCaption.Text = ""
        '
        'txtPesan
        '
        Me.txtPesan.AutoWordSelection = True
        Me.txtPesan.BackColor = System.Drawing.Color.Honeydew
        Me.txtPesan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesan.Location = New System.Drawing.Point(336, 62)
        Me.txtPesan.Name = "txtPesan"
        Me.txtPesan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPesan.Size = New System.Drawing.Size(328, 93)
        Me.txtPesan.TabIndex = 66
        Me.txtPesan.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(424, 467)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(240, 15)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "!Make sure your internet connection is good"
        '
        'txtProses
        '
        Me.txtProses.AutoSize = True
        Me.txtProses.Location = New System.Drawing.Point(311, 496)
        Me.txtProses.Name = "txtProses"
        Me.txtProses.Size = New System.Drawing.Size(30, 15)
        Me.txtProses.TabIndex = 64
        Me.txtProses.Text = "0 / 0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 467)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 15)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "!Sending already in Progress"
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(15, 492)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(649, 23)
        Me.progressBar.TabIndex = 62
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.IconChar = FontAwesome.Sharp.IconChar.Recycle
        Me.btnReset.IconColor = System.Drawing.Color.White
        Me.btnReset.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReset.IconSize = 18
        Me.btnReset.Location = New System.Drawing.Point(449, 421)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(110, 34)
        Me.btnReset.TabIndex = 61
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.IconChar = FontAwesome.Sharp.IconChar.Play
        Me.btnStart.IconColor = System.Drawing.Color.White
        Me.btnStart.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStart.IconSize = 18
        Me.btnStart.Location = New System.Drawing.Point(336, 421)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(107, 34)
        Me.btnStart.TabIndex = 60
        Me.btnStart.Text = "Start"
        Me.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btnSend.IconColor = System.Drawing.Color.White
        Me.btnSend.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSend.IconSize = 24
        Me.btnSend.Location = New System.Drawing.Point(565, 421)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(99, 34)
        Me.btnSend.TabIndex = 59
        Me.btnSend.Text = "Send"
        Me.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(615, 392)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(49, 23)
        Me.btnOpenFile.TabIndex = 58
        Me.btnOpenFile.Text = "Select"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'txtPathFile
        '
        Me.txtPathFile.BackColor = System.Drawing.Color.Honeydew
        Me.txtPathFile.Location = New System.Drawing.Point(336, 392)
        Me.txtPathFile.Name = "txtPathFile"
        Me.txtPathFile.Size = New System.Drawing.Size(273, 23)
        Me.txtPathFile.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(590, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "File location"
        '
        'chkFile
        '
        Me.chkFile.AutoSize = True
        Me.chkFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkFile.Location = New System.Drawing.Point(336, 367)
        Me.chkFile.Name = "chkFile"
        Me.chkFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFile.Size = New System.Drawing.Size(71, 19)
        Me.chkFile.TabIndex = 55
        Me.chkFile.Text = "Send file"
        Me.chkFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkFile.UseVisualStyleBackColor = True
        '
        'picBox
        '
        Me.picBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picBox.Location = New System.Drawing.Point(542, 235)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(122, 122)
        Me.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox.TabIndex = 54
        Me.picBox.TabStop = False
        '
        'chkImageCaption
        '
        Me.chkImageCaption.AutoSize = True
        Me.chkImageCaption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkImageCaption.Location = New System.Drawing.Point(336, 211)
        Me.chkImageCaption.Name = "chkImageCaption"
        Me.chkImageCaption.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkImageCaption.Size = New System.Drawing.Size(130, 19)
        Me.chkImageCaption.TabIndex = 53
        Me.chkImageCaption.Text = "Image with Caption"
        Me.chkImageCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkImageCaption.UseVisualStyleBackColor = True
        '
        'btnOpenImage
        '
        Me.btnOpenImage.Location = New System.Drawing.Point(615, 182)
        Me.btnOpenImage.Name = "btnOpenImage"
        Me.btnOpenImage.Size = New System.Drawing.Size(49, 23)
        Me.btnOpenImage.TabIndex = 52
        Me.btnOpenImage.Text = "Select"
        Me.btnOpenImage.UseVisualStyleBackColor = True
        '
        'txtPathImage
        '
        Me.txtPathImage.BackColor = System.Drawing.Color.Honeydew
        Me.txtPathImage.Location = New System.Drawing.Point(336, 182)
        Me.txtPathImage.Name = "txtPathImage"
        Me.txtPathImage.Size = New System.Drawing.Size(273, 23)
        Me.txtPathImage.TabIndex = 51
        Me.txtPathImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(580, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Image location"
        '
        'chkGambar
        '
        Me.chkGambar.AutoSize = True
        Me.chkGambar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkGambar.Location = New System.Drawing.Point(336, 157)
        Me.chkGambar.Name = "chkGambar"
        Me.chkGambar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkGambar.Size = New System.Drawing.Size(88, 19)
        Me.chkGambar.TabIndex = 49
        Me.chkGambar.Text = "Send image"
        Me.chkGambar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkGambar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(335, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Type your Message"
        '
        'btnImportExcel
        '
        Me.btnImportExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportExcel.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnImportExcel.ForeColor = System.Drawing.Color.White
        Me.btnImportExcel.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnImportExcel.IconColor = System.Drawing.Color.Black
        Me.btnImportExcel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnImportExcel.Location = New System.Drawing.Point(15, 421)
        Me.btnImportExcel.Name = "btnImportExcel"
        Me.btnImportExcel.Size = New System.Drawing.Size(302, 34)
        Me.btnImportExcel.TabIndex = 47
        Me.btnImportExcel.Text = "Import from Excel"
        Me.btnImportExcel.UseVisualStyleBackColor = False
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.AllowUserToResizeColumns = False
        Me.Dgv.AllowUserToResizeRows = False
        Me.Dgv.BackgroundColor = System.Drawing.Color.Honeydew
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvNama, Me.DgvWA, Me.DgvStatus})
        Me.Dgv.Location = New System.Drawing.Point(15, 15)
        Me.Dgv.MultiSelect = False
        Me.Dgv.Name = "Dgv"
        Me.Dgv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Dgv.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv.RowTemplate.Height = 25
        Me.Dgv.Size = New System.Drawing.Size(302, 400)
        Me.Dgv.TabIndex = 46
        '
        'DgvNama
        '
        Me.DgvNama.HeaderText = "Nama"
        Me.DgvNama.Name = "DgvNama"
        '
        'DgvWA
        '
        Me.DgvWA.HeaderText = "Nomor WA"
        Me.DgvWA.Name = "DgvWA"
        '
        'DgvStatus
        '
        Me.DgvStatus.HeaderText = "Status"
        Me.DgvStatus.Name = "DgvStatus"
        '
        'BGW
        '
        '
        'WaBroadcast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(693, 543)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WaBroadcast"
        Me.Text = "WaBroadcast"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCaption As RichTextBox
    Friend WithEvents txtPesan As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtProses As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents btnReset As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStart As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSend As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents txtPathFile As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkFile As CheckBox
    Friend WithEvents picBox As PictureBox
    Friend WithEvents chkImageCaption As CheckBox
    Friend WithEvents btnOpenImage As Button
    Friend WithEvents txtPathImage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkGambar As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnImportExcel As FontAwesome.Sharp.IconButton
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents DgvNama As DataGridViewTextBoxColumn
    Friend WithEvents DgvWA As DataGridViewTextBoxColumn
    Friend WithEvents DgvStatus As DataGridViewTextBoxColumn
    Friend WithEvents BGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents txtInterval As TextBox
    Friend WithEvents Label5 As Label
End Class
