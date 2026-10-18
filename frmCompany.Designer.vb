<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompany
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
        Me.lvcompany = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbtin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbcn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbca = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.gbcom = New System.Windows.Forms.GroupBox()
        Me.lblnotif = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnTitle = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.gbcom.SuspendLayout()
        Me.pnTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvcompany
        '
        Me.lvcompany.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lvcompany.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvcompany.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvcompany.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvcompany.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lvcompany.FullRowSelect = True
        Me.lvcompany.GridLines = True
        Me.lvcompany.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvcompany.HideSelection = False
        Me.lvcompany.Location = New System.Drawing.Point(23, 119)
        Me.lvcompany.Margin = New System.Windows.Forms.Padding(4)
        Me.lvcompany.Name = "lvcompany"
        Me.lvcompany.Size = New System.Drawing.Size(749, 279)
        Me.lvcompany.TabIndex = 0
        Me.lvcompany.UseCompatibleStateImageBehavior = False
        Me.lvcompany.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Nomor"
        Me.ColumnHeader4.Width = 93
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Perusahaan"
        Me.ColumnHeader2.Width = 148
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Alamat Perusahaan"
        Me.ColumnHeader3.Width = 321
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(25, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nomor"
        '
        'tbtin
        '
        Me.tbtin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbtin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbtin.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtin.ForeColor = System.Drawing.Color.DarkGray
        Me.tbtin.Location = New System.Drawing.Point(32, 75)
        Me.tbtin.Margin = New System.Windows.Forms.Padding(4)
        Me.tbtin.Name = "tbtin"
        Me.tbtin.Size = New System.Drawing.Size(354, 37)
        Me.tbtin.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(27, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama Peusahaan"
        '
        'tbcn
        '
        Me.tbcn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbcn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbcn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcn.ForeColor = System.Drawing.Color.DarkGray
        Me.tbcn.Location = New System.Drawing.Point(33, 151)
        Me.tbcn.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcn.Name = "tbcn"
        Me.tbcn.Size = New System.Drawing.Size(354, 37)
        Me.tbcn.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(419, 41)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Alamat Perusahaan"
        '
        'tbca
        '
        Me.tbca.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbca.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbca.ForeColor = System.Drawing.Color.DarkGray
        Me.tbca.Location = New System.Drawing.Point(424, 75)
        Me.tbca.Margin = New System.Windows.Forms.Padding(4)
        Me.tbca.Multiline = True
        Me.tbca.Name = "tbca"
        Me.tbca.Size = New System.Drawing.Size(418, 114)
        Me.tbca.TabIndex = 10
        '
        'btnadd
        '
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnadd.Location = New System.Drawing.Point(797, 74)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(96, 59)
        Me.btnadd.TabIndex = 12
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnedit.Location = New System.Drawing.Point(797, 140)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(96, 59)
        Me.btnedit.TabIndex = 13
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndelete.Location = New System.Drawing.Point(797, 207)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(96, 59)
        Me.btndelete.TabIndex = 14
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnclear.Location = New System.Drawing.Point(797, 273)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(96, 59)
        Me.btnclear.TabIndex = 15
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'gbcom
        '
        Me.gbcom.Controls.Add(Me.tbtin)
        Me.gbcom.Controls.Add(Me.Label1)
        Me.gbcom.Controls.Add(Me.Label2)
        Me.gbcom.Controls.Add(Me.tbcn)
        Me.gbcom.Controls.Add(Me.Label3)
        Me.gbcom.Controls.Add(Me.tbca)
        Me.gbcom.Enabled = False
        Me.gbcom.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbcom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbcom.Location = New System.Drawing.Point(23, 412)
        Me.gbcom.Margin = New System.Windows.Forms.Padding(4)
        Me.gbcom.Name = "gbcom"
        Me.gbcom.Padding = New System.Windows.Forms.Padding(4)
        Me.gbcom.Size = New System.Drawing.Size(871, 219)
        Me.gbcom.TabIndex = 16
        Me.gbcom.TabStop = False
        Me.gbcom.Text = "Detail Perusahaan"
        '
        'lblnotif
        '
        Me.lblnotif.AutoSize = True
        Me.lblnotif.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnotif.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblnotif.Location = New System.Drawing.Point(19, 644)
        Me.lblnotif.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnotif.Name = "lblnotif"
        Me.lblnotif.Size = New System.Drawing.Size(170, 21)
        Me.lblnotif.TabIndex = 17
        Me.lblnotif.Text = "*Password is missing"
        Me.lblnotif.Visible = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(797, 340)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 59)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pnTitle
        '
        Me.pnTitle.BackColor = System.Drawing.Color.Teal
        Me.pnTitle.Controls.Add(Me.lbltitle)
        Me.pnTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.pnTitle.Name = "pnTitle"
        Me.pnTitle.Size = New System.Drawing.Size(921, 50)
        Me.pnTitle.TabIndex = 22
        '
        'lbltitle
        '
        Me.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.White
        Me.lbltitle.Location = New System.Drawing.Point(264, 11)
        Me.lbltitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(330, 33)
        Me.lbltitle.TabIndex = 19
        Me.lbltitle.Text = "Pengaturan Perusahaan"
        '
        'tbsearch
        '
        Me.tbsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsearch.ForeColor = System.Drawing.Color.DarkGray
        Me.tbsearch.Location = New System.Drawing.Point(23, 74)
        Me.tbsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(749, 37)
        Me.tbsearch.TabIndex = 27
        Me.tbsearch.Text = "Cari ID atau Perusahaan"
        Me.tbsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(917, 677)
        Me.Controls.Add(Me.tbsearch)
        Me.Controls.Add(Me.pnTitle)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbcom)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.lvcompany)
        Me.Controls.Add(Me.lblnotif)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company"
        Me.gbcom.ResumeLayout(False)
        Me.gbcom.PerformLayout()
        Me.pnTitle.ResumeLayout(False)
        Me.pnTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvcompany As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbtin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbcn As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbca As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents gbcom As System.Windows.Forms.GroupBox
    Friend WithEvents lblnotif As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pnTitle As System.Windows.Forms.Panel
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
End Class
