<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginInterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginInterface))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExitonLogin = New FontAwesome.Sharp.IconButton()
        Me.txtDateonLogin = New System.Windows.Forms.Label()
        Me.timeOnLogin = New System.Windows.Forms.Timer(Me.components)
        Me.txtTimeonLogin = New System.Windows.Forms.Label()
        Me.txtAbout = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(35, 172)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(152, 23)
        Me.txtUsername.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(35, 226)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(152, 23)
        Me.txtPassword.TabIndex = 7
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(83, 266)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(104, 35)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnExitonLogin
        '
        Me.btnExitonLogin.BackColor = System.Drawing.Color.White
        Me.btnExitonLogin.FlatAppearance.BorderSize = 0
        Me.btnExitonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitonLogin.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.btnExitonLogin.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnExitonLogin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExitonLogin.IconSize = 30
        Me.btnExitonLogin.Location = New System.Drawing.Point(35, 266)
        Me.btnExitonLogin.Name = "btnExitonLogin"
        Me.btnExitonLogin.Size = New System.Drawing.Size(42, 35)
        Me.btnExitonLogin.TabIndex = 10
        Me.btnExitonLogin.UseVisualStyleBackColor = False
        '
        'txtDateonLogin
        '
        Me.txtDateonLogin.AutoSize = True
        Me.txtDateonLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtDateonLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtDateonLogin.ForeColor = System.Drawing.Color.White
        Me.txtDateonLogin.Location = New System.Drawing.Point(35, 113)
        Me.txtDateonLogin.Name = "txtDateonLogin"
        Me.txtDateonLogin.Size = New System.Drawing.Size(49, 15)
        Me.txtDateonLogin.TabIndex = 11
        Me.txtDateonLogin.Text = "Tanggal"
        '
        'timeOnLogin
        '
        Me.timeOnLogin.Enabled = True
        '
        'txtTimeonLogin
        '
        Me.txtTimeonLogin.AutoSize = True
        Me.txtTimeonLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtTimeonLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtTimeonLogin.ForeColor = System.Drawing.Color.White
        Me.txtTimeonLogin.Location = New System.Drawing.Point(138, 113)
        Me.txtTimeonLogin.Name = "txtTimeonLogin"
        Me.txtTimeonLogin.Size = New System.Drawing.Size(34, 15)
        Me.txtTimeonLogin.TabIndex = 12
        Me.txtTimeonLogin.Text = "Time"
        '
        'txtAbout
        '
        Me.txtAbout.AutoSize = True
        Me.txtAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtAbout.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAbout.ForeColor = System.Drawing.Color.White
        Me.txtAbout.Location = New System.Drawing.Point(41, 315)
        Me.txtAbout.Name = "txtAbout"
        Me.txtAbout.Size = New System.Drawing.Size(136, 15)
        Me.txtAbout.TabIndex = 13
        Me.txtAbout.Text = "WhatsApp Broadcast V.1"
        '
        'LoginInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(220, 353)
        Me.Controls.Add(Me.txtAbout)
        Me.Controls.Add(Me.txtTimeonLogin)
        Me.Controls.Add(Me.txtDateonLogin)
        Me.Controls.Add(Me.btnExitonLogin)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginInterface"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExitonLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents txtDateonLogin As Label
    Friend WithEvents timeOnLogin As Timer
    Friend WithEvents txtTimeonLogin As Label
    Friend WithEvents txtAbout As Label
End Class
