<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeScreen))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnTOS = New FontAwesome.Sharp.IconButton()
        Me.IconButton8 = New FontAwesome.Sharp.IconButton()
        Me.btnInfo = New FontAwesome.Sharp.IconButton()
        Me.btnHelp = New FontAwesome.Sharp.IconButton()
        Me.btnWaBroadcast = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.txtPukul = New System.Windows.Forms.Label()
        Me.txtTanggal = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNamaUser = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New FontAwesome.Sharp.IconPictureBox()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BGW = New System.ComponentModel.BackgroundWorker()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.txtPukul)
        Me.Panel1.Controls.Add(Me.txtTanggal)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 642)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel6.Controls.Add(Me.btnTOS)
        Me.Panel6.Controls.Add(Me.IconButton8)
        Me.Panel6.Controls.Add(Me.btnInfo)
        Me.Panel6.Controls.Add(Me.btnHelp)
        Me.Panel6.Controls.Add(Me.btnWaBroadcast)
        Me.Panel6.Controls.Add(Me.btnDashboard)
        Me.Panel6.Location = New System.Drawing.Point(0, 132)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(202, 510)
        Me.Panel6.TabIndex = 31
        '
        'btnTOS
        '
        Me.btnTOS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnTOS.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTOS.FlatAppearance.BorderSize = 0
        Me.btnTOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTOS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTOS.ForeColor = System.Drawing.Color.White
        Me.btnTOS.IconChar = FontAwesome.Sharp.IconChar.Readme
        Me.btnTOS.IconColor = System.Drawing.Color.White
        Me.btnTOS.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTOS.IconSize = 25
        Me.btnTOS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTOS.Location = New System.Drawing.Point(0, 156)
        Me.btnTOS.Name = "btnTOS"
        Me.btnTOS.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnTOS.Size = New System.Drawing.Size(202, 39)
        Me.btnTOS.TabIndex = 10
        Me.btnTOS.Text = "Term of Service"
        Me.btnTOS.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnTOS.UseVisualStyleBackColor = False
        '
        'IconButton8
        '
        Me.IconButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IconButton8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.IconButton8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.IconButton8.FlatAppearance.BorderSize = 0
        Me.IconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButton8.ForeColor = System.Drawing.Color.White
        Me.IconButton8.IconChar = FontAwesome.Sharp.IconChar.SyncAlt
        Me.IconButton8.IconColor = System.Drawing.Color.White
        Me.IconButton8.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton8.IconSize = 25
        Me.IconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton8.Location = New System.Drawing.Point(0, 473)
        Me.IconButton8.Name = "IconButton8"
        Me.IconButton8.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.IconButton8.Size = New System.Drawing.Size(202, 37)
        Me.IconButton8.TabIndex = 9
        Me.IconButton8.Text = "Check for Updates"
        Me.IconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton8.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInfo.FlatAppearance.BorderSize = 0
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnInfo.ForeColor = System.Drawing.Color.White
        Me.btnInfo.IconChar = FontAwesome.Sharp.IconChar.Info
        Me.btnInfo.IconColor = System.Drawing.Color.White
        Me.btnInfo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInfo.IconSize = 25
        Me.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInfo.Location = New System.Drawing.Point(0, 117)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnInfo.Size = New System.Drawing.Size(202, 39)
        Me.btnInfo.TabIndex = 8
        Me.btnInfo.Text = "Info"
        Me.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnHelp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHelp.ForeColor = System.Drawing.Color.White
        Me.btnHelp.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHeart
        Me.btnHelp.IconColor = System.Drawing.Color.White
        Me.btnHelp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHelp.IconSize = 25
        Me.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHelp.Location = New System.Drawing.Point(0, 78)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnHelp.Size = New System.Drawing.Size(202, 39)
        Me.btnHelp.TabIndex = 7
        Me.btnHelp.Text = "Help"
        Me.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnWaBroadcast
        '
        Me.btnWaBroadcast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnWaBroadcast.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnWaBroadcast.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnWaBroadcast.FlatAppearance.BorderSize = 0
        Me.btnWaBroadcast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWaBroadcast.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnWaBroadcast.ForeColor = System.Drawing.Color.White
        Me.btnWaBroadcast.IconChar = FontAwesome.Sharp.IconChar.Whatsapp
        Me.btnWaBroadcast.IconColor = System.Drawing.Color.White
        Me.btnWaBroadcast.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnWaBroadcast.IconSize = 25
        Me.btnWaBroadcast.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWaBroadcast.Location = New System.Drawing.Point(0, 39)
        Me.btnWaBroadcast.Name = "btnWaBroadcast"
        Me.btnWaBroadcast.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnWaBroadcast.Size = New System.Drawing.Size(202, 39)
        Me.btnWaBroadcast.TabIndex = 3
        Me.btnWaBroadcast.Text = "WhatsApp Broadcast"
        Me.btnWaBroadcast.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnWaBroadcast.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Rss
        Me.btnDashboard.IconColor = System.Drawing.Color.White
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 25
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(202, 39)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'txtPukul
        '
        Me.txtPukul.AutoSize = True
        Me.txtPukul.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtPukul.ForeColor = System.Drawing.Color.White
        Me.txtPukul.Location = New System.Drawing.Point(89, 575)
        Me.txtPukul.Name = "txtPukul"
        Me.txtPukul.Size = New System.Drawing.Size(0, 15)
        Me.txtPukul.TabIndex = 29
        '
        'txtTanggal
        '
        Me.txtTanggal.AutoSize = True
        Me.txtTanggal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtTanggal.ForeColor = System.Drawing.Color.White
        Me.txtTanggal.Location = New System.Drawing.Point(89, 550)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(0, 15)
        Me.txtTanggal.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtNamaUser)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(202, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(693, 62)
        Me.Panel2.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(585, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Sign Out"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Poppins", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(53, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Pendiri Nahdlatul Ulama"
        '
        'txtNamaUser
        '
        Me.txtNamaUser.AutoSize = True
        Me.txtNamaUser.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtNamaUser.Location = New System.Drawing.Point(51, 14)
        Me.txtNamaUser.Name = "txtNamaUser"
        Me.txtNamaUser.Size = New System.Drawing.Size(124, 22)
        Me.txtNamaUser.TabIndex = 2
        Me.txtNamaUser.Text = "KH. Hasyim Asy'ari"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(19, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.White
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.btnLogout.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.Location = New System.Drawing.Point(643, 17)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(32, 32)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.TabStop = False
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMenu.Location = New System.Drawing.Point(202, 62)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(693, 543)
        Me.panelMenu.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(202, 605)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(693, 37)
        Me.Panel3.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(632, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Versi 1.0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(291, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Made with love by Team Baitul Maal BMT NU Ngasem"
        '
        'HomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(895, 642)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HomeScreen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelMenu As Panel
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPukul As Label
    Friend WithEvents txtTanggal As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnInfo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHelp As FontAwesome.Sharp.IconButton
    Friend WithEvents btnWaBroadcast As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton8 As FontAwesome.Sharp.IconButton
    Friend WithEvents txtNamaUser As Label
    Friend WithEvents btnTOS As FontAwesome.Sharp.IconButton
End Class
