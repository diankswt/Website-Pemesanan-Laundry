<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployee))
        Me.lvEmployee = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbnum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbadd = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.gbemp = New System.Windows.Forms.GroupBox()
        Me.cbostatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblnotif = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnTitle = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.gbemp.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvEmployee
        '
        Me.lvEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader6})
        Me.lvEmployee.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvEmployee.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lvEmployee.FullRowSelect = True
        Me.lvEmployee.GridLines = True
        Me.lvEmployee.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvEmployee.HideSelection = False
        Me.lvEmployee.Location = New System.Drawing.Point(25, 132)
        Me.lvEmployee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lvEmployee.Name = "lvEmployee"
        Me.lvEmployee.Size = New System.Drawing.Size(749, 279)
        Me.lvEmployee.TabIndex = 0
        Me.lvEmployee.UseCompatibleStateImageBehavior = False
        Me.lvEmployee.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 93
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "No. Telp"
        Me.ColumnHeader2.Width = 148
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Alamat"
        Me.ColumnHeader3.Width = 169
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Jenis Kelamin"
        Me.ColumnHeader5.Width = 86
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Status"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Foto"
        Me.ColumnHeader6.Width = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(212, 132)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nama Karyawan"
        '
        'tbname
        '
        Me.tbname.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbname.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbname.ForeColor = System.Drawing.Color.DarkGray
        Me.tbname.Location = New System.Drawing.Point(219, 166)
        Me.tbname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(275, 37)
        Me.tbname.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(501, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nomor"
        '
        'tbnum
        '
        Me.tbnum.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbnum.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnum.ForeColor = System.Drawing.Color.DarkGray
        Me.tbnum.Location = New System.Drawing.Point(511, 80)
        Me.tbnum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbnum.Name = "tbnum"
        Me.tbnum.Size = New System.Drawing.Size(171, 37)
        Me.tbnum.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(504, 137)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Alamat Karyawan"
        '
        'tbadd
        '
        Me.tbadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbadd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbadd.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbadd.ForeColor = System.Drawing.Color.DarkGray
        Me.tbadd.Location = New System.Drawing.Point(511, 166)
        Me.tbadd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbadd.Name = "tbadd"
        Me.tbadd.Size = New System.Drawing.Size(335, 37)
        Me.tbadd.TabIndex = 10
        '
        'btnadd
        '
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnadd.Location = New System.Drawing.Point(799, 86)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnedit.Location = New System.Drawing.Point(799, 153)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btndelete.Location = New System.Drawing.Point(799, 219)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnclear.Location = New System.Drawing.Point(799, 286)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(96, 59)
        Me.btnclear.TabIndex = 15
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'gbemp
        '
        Me.gbemp.Controls.Add(Me.cbostatus)
        Me.gbemp.Controls.Add(Me.Label5)
        Me.gbemp.Controls.Add(Me.pic)
        Me.gbemp.Controls.Add(Me.Button2)
        Me.gbemp.Controls.Add(Me.cbogender)
        Me.gbemp.Controls.Add(Me.Label4)
        Me.gbemp.Controls.Add(Me.tbname)
        Me.gbemp.Controls.Add(Me.Label1)
        Me.gbemp.Controls.Add(Me.Label2)
        Me.gbemp.Controls.Add(Me.tbnum)
        Me.gbemp.Controls.Add(Me.Label3)
        Me.gbemp.Controls.Add(Me.tbadd)
        Me.gbemp.Enabled = False
        Me.gbemp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbemp.Location = New System.Drawing.Point(24, 437)
        Me.gbemp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbemp.Name = "gbemp"
        Me.gbemp.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbemp.Size = New System.Drawing.Size(871, 234)
        Me.gbemp.TabIndex = 16
        Me.gbemp.TabStop = False
        Me.gbemp.Text = "Detail Karyawan"
        '
        'cbostatus
        '
        Me.cbostatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbostatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbostatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"Actived", "Dismissed", "Suspended"})
        Me.cbostatus.Location = New System.Drawing.Point(700, 80)
        Me.cbostatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.Size = New System.Drawing.Size(145, 31)
        Me.cbostatus.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(695, 46)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 23)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Status"
        '
        'pic
        '
        Me.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic.ErrorImage = Nothing
        Me.pic.Image = CType(resources.GetObject("pic.Image"), System.Drawing.Image)
        Me.pic.Location = New System.Drawing.Point(23, 46)
        Me.pic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(183, 159)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic.TabIndex = 22
        Me.pic.TabStop = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(219, 54)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 62)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Browse Image"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbogender
        '
        Me.cbogender.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbogender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbogender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cbogender.Location = New System.Drawing.Point(348, 80)
        Me.cbogender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(145, 31)
        Me.cbogender.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(343, 46)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Gender"
        '
        'lblnotif
        '
        Me.lblnotif.AutoSize = True
        Me.lblnotif.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnotif.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblnotif.Location = New System.Drawing.Point(21, 682)
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
        Me.Button1.Location = New System.Drawing.Point(799, 352)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.pnTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnTitle.Name = "pnTitle"
        Me.pnTitle.Size = New System.Drawing.Size(921, 50)
        Me.pnTitle.TabIndex = 20
        '
        'lbltitle
        '
        Me.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.White
        Me.lbltitle.Location = New System.Drawing.Point(284, 11)
        Me.lbltitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(309, 33)
        Me.lbltitle.TabIndex = 19
        Me.lbltitle.Text = "Pengaturan Karyawan"
        '
        'tbsearch
        '
        Me.tbsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsearch.ForeColor = System.Drawing.Color.DarkGray
        Me.tbsearch.Location = New System.Drawing.Point(25, 86)
        Me.tbsearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(749, 37)
        Me.tbsearch.TabIndex = 28
        Me.tbsearch.Text = "Cari Karyawan DIsini"
        Me.tbsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(921, 719)
        Me.Controls.Add(Me.tbsearch)
        Me.Controls.Add(Me.pnTitle)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbemp)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.lvEmployee)
        Me.Controls.Add(Me.lblnotif)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company"
        Me.gbemp.ResumeLayout(False)
        Me.gbemp.PerformLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnTitle.ResumeLayout(False)
        Me.pnTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvEmployee As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbnum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbadd As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents gbemp As System.Windows.Forms.GroupBox
    Friend WithEvents lblnotif As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pnTitle As System.Windows.Forms.Panel
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents cbostatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
End Class
