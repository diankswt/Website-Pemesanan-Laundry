<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Me.tbuname = New System.Windows.Forms.TextBox()
        Me.tbpword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.lblup = New System.Windows.Forms.Label()
        Me.lblum = New System.Windows.Forms.Label()
        Me.lblnotif = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnTitle = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.pnTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbuname
        '
        Me.tbuname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbuname.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbuname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbuname.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbuname.ForeColor = System.Drawing.Color.Gainsboro
        Me.tbuname.Location = New System.Drawing.Point(143, 156)
        Me.tbuname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbuname.Name = "tbuname"
        Me.tbuname.Size = New System.Drawing.Size(354, 40)
        Me.tbuname.TabIndex = 0
        Me.tbuname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbpword
        '
        Me.tbpword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbpword.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpword.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpword.ForeColor = System.Drawing.Color.Gainsboro
        Me.tbpword.Location = New System.Drawing.Point(143, 266)
        Me.tbpword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpword.Name = "tbpword"
        Me.tbpword.Size = New System.Drawing.Size(354, 40)
        Me.tbpword.TabIndex = 1
        Me.tbpword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbpword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(136, 122)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(136, 233)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 33)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'btnlogin
        '
        Me.btnlogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlogin.Location = New System.Drawing.Point(339, 356)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(124, 47)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'lblup
        '
        Me.lblup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblup.AutoSize = True
        Me.lblup.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblup.Location = New System.Drawing.Point(303, 306)
        Me.lblup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblup.Name = "lblup"
        Me.lblup.Size = New System.Drawing.Size(186, 22)
        Me.lblup.TabIndex = 5
        Me.lblup.Text = "*Password is missing"
        Me.lblup.Visible = False
        '
        'lblum
        '
        Me.lblum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblum.AutoSize = True
        Me.lblum.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblum.Location = New System.Drawing.Point(297, 197)
        Me.lblum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblum.Name = "lblum"
        Me.lblum.Size = New System.Drawing.Size(192, 22)
        Me.lblum.TabIndex = 6
        Me.lblum.Text = "*Username is missing"
        Me.lblum.Visible = False
        '
        'lblnotif
        '
        Me.lblnotif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblnotif.AutoSize = True
        Me.lblnotif.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnotif.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblnotif.Location = New System.Drawing.Point(8, 463)
        Me.lblnotif.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnotif.Name = "lblnotif"
        Me.lblnotif.Size = New System.Drawing.Size(0, 22)
        Me.lblnotif.TabIndex = 7
        Me.lblnotif.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(181, 356)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 47)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnTitle)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblnotif)
        Me.Panel1.Controls.Add(Me.lblum)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblup)
        Me.Panel1.Controls.Add(Me.tbuname)
        Me.Panel1.Controls.Add(Me.btnlogin)
        Me.Panel1.Controls.Add(Me.tbpword)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(213, 95)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 494)
        Me.Panel1.TabIndex = 10
        '
        'pnTitle
        '
        Me.pnTitle.BackColor = System.Drawing.Color.Teal
        Me.pnTitle.Controls.Add(Me.lbltitle)
        Me.pnTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnTitle.Name = "pnTitle"
        Me.pnTitle.Size = New System.Drawing.Size(647, 50)
        Me.pnTitle.TabIndex = 20
        '
        'lbltitle
        '
        Me.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.White
        Me.lbltitle.Location = New System.Drawing.Point(273, 10)
        Me.lbltitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(85, 33)
        Me.lbltitle.TabIndex = 19
        Me.lbltitle.Text = "Login"
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(415, 327)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(0, 33)
        Me.lblWelcome.TabIndex = 10
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BackgroundImage = Global.LaundryShopSystem.My.Resources.Resources.background_webcuci_karpet_kantor
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1087, 699)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblWelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnTitle.ResumeLayout(False)
        Me.pnTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbuname As System.Windows.Forms.TextBox
    Friend WithEvents tbpword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents lblup As System.Windows.Forms.Label
    Friend WithEvents lblum As System.Windows.Forms.Label
    Friend WithEvents lblnotif As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pnTitle As System.Windows.Forms.Panel
    Friend WithEvents lbltitle As System.Windows.Forms.Label
End Class
