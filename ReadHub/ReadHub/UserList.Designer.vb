﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserList
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
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        userPanel = New Panel()
        Panel3 = New Panel()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        borrowButton = New FontAwesome.Sharp.IconButton()
        archiveButton = New FontAwesome.Sharp.IconButton()
        userButton = New FontAwesome.Sharp.IconButton()
        bookButton = New FontAwesome.Sharp.IconButton()
        dashButton = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        ComboBox1 = New ComboBox()
        modButton1 = New FontAwesome.Sharp.IconButton()
        regButton1 = New FontAwesome.Sharp.IconButton()
        barButton = New FontAwesome.Sharp.IconButton()
        Label3 = New Label()
        Label2 = New Label()
        facultyTable = New DataGridView()
        studTable = New DataGridView()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        TextBox13 = New TextBox()
        TextBox14 = New TextBox()
        TextBox15 = New TextBox()
        TextBox16 = New TextBox()
        TextBox17 = New TextBox()
        TextBox18 = New TextBox()
        TextBox19 = New TextBox()
        TextBox20 = New TextBox()
        TextBox21 = New TextBox()
        TextBox22 = New TextBox()
        ComboBox2 = New ComboBox()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton3 = New FontAwesome.Sharp.IconButton()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        userPanel.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(facultyTable, ComponentModel.ISupportInitialize).BeginInit()
        CType(studTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(340, 182)
        Panel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bebas Neue", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(126, 58)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 64)
        Label1.TabIndex = 1
        Label1.Text = "READHUB"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(44, 50)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(73, 83)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' userPanel
        ' 
        userPanel.BackColor = SystemColors.Highlight
        userPanel.Controls.Add(Panel3)
        userPanel.Controls.Add(borrowButton)
        userPanel.Controls.Add(archiveButton)
        userPanel.Controls.Add(userButton)
        userPanel.Controls.Add(bookButton)
        userPanel.Controls.Add(dashButton)
        userPanel.Controls.Add(Panel1)
        userPanel.Dock = DockStyle.Left
        userPanel.Location = New Point(0, 0)
        userPanel.Margin = New Padding(4, 5, 4, 5)
        userPanel.Name = "userPanel"
        userPanel.Size = New Size(340, 1050)
        userPanel.TabIndex = 13
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(IconButton1)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 977)
        Panel3.Margin = New Padding(4, 5, 4, 5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(340, 73)
        Panel3.TabIndex = 12
        ' 
        ' IconButton1
        ' 
        IconButton1.Dock = DockStyle.Fill
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton1.ForeColor = Color.White
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(0, 0)
        IconButton1.Margin = New Padding(4, 5, 4, 5)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(340, 73)
        IconButton1.TabIndex = 6
        IconButton1.Text = "LOGOUT"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' borrowButton
        ' 
        borrowButton.Cursor = Cursors.Hand
        borrowButton.Dock = DockStyle.Top
        borrowButton.FlatAppearance.BorderSize = 0
        borrowButton.FlatStyle = FlatStyle.Flat
        borrowButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        borrowButton.ForeColor = Color.White
        borrowButton.IconChar = FontAwesome.Sharp.IconChar.None
        borrowButton.IconColor = Color.Black
        borrowButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        borrowButton.Location = New Point(0, 510)
        borrowButton.Margin = New Padding(4, 5, 4, 5)
        borrowButton.Name = "borrowButton"
        borrowButton.Size = New Size(340, 82)
        borrowButton.TabIndex = 11
        borrowButton.Text = "BORROWED BOOKS"
        borrowButton.UseVisualStyleBackColor = True
        ' 
        ' archiveButton
        ' 
        archiveButton.Cursor = Cursors.Hand
        archiveButton.Dock = DockStyle.Top
        archiveButton.FlatAppearance.BorderSize = 0
        archiveButton.FlatStyle = FlatStyle.Flat
        archiveButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        archiveButton.ForeColor = Color.White
        archiveButton.IconChar = FontAwesome.Sharp.IconChar.None
        archiveButton.IconColor = Color.Black
        archiveButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        archiveButton.Location = New Point(0, 428)
        archiveButton.Margin = New Padding(4, 5, 4, 5)
        archiveButton.Name = "archiveButton"
        archiveButton.Size = New Size(340, 82)
        archiveButton.TabIndex = 10
        archiveButton.Text = "ARCHIVES"
        archiveButton.UseVisualStyleBackColor = True
        ' 
        ' userButton
        ' 
        userButton.Cursor = Cursors.Hand
        userButton.Dock = DockStyle.Top
        userButton.FlatAppearance.BorderSize = 0
        userButton.FlatStyle = FlatStyle.Flat
        userButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        userButton.ForeColor = Color.White
        userButton.IconChar = FontAwesome.Sharp.IconChar.None
        userButton.IconColor = Color.Black
        userButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        userButton.Location = New Point(0, 346)
        userButton.Margin = New Padding(4, 5, 4, 5)
        userButton.Name = "userButton"
        userButton.Size = New Size(340, 82)
        userButton.TabIndex = 9
        userButton.Text = "USER'S LIST"
        userButton.UseVisualStyleBackColor = True
        ' 
        ' bookButton
        ' 
        bookButton.Cursor = Cursors.Hand
        bookButton.Dock = DockStyle.Top
        bookButton.FlatAppearance.BorderSize = 0
        bookButton.FlatStyle = FlatStyle.Flat
        bookButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        bookButton.ForeColor = Color.White
        bookButton.IconChar = FontAwesome.Sharp.IconChar.None
        bookButton.IconColor = Color.Black
        bookButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        bookButton.Location = New Point(0, 264)
        bookButton.Margin = New Padding(4, 5, 4, 5)
        bookButton.Name = "bookButton"
        bookButton.Size = New Size(340, 82)
        bookButton.TabIndex = 8
        bookButton.Text = "BOOK LIST"
        bookButton.UseVisualStyleBackColor = True
        ' 
        ' dashButton
        ' 
        dashButton.Cursor = Cursors.Hand
        dashButton.Dock = DockStyle.Top
        dashButton.FlatAppearance.BorderSize = 0
        dashButton.FlatStyle = FlatStyle.Flat
        dashButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        dashButton.ForeColor = Color.White
        dashButton.IconChar = FontAwesome.Sharp.IconChar.None
        dashButton.IconColor = Color.Black
        dashButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        dashButton.Location = New Point(0, 182)
        dashButton.Margin = New Padding(4, 5, 4, 5)
        dashButton.Name = "dashButton"
        dashButton.Size = New Size(340, 82)
        dashButton.TabIndex = 7
        dashButton.Text = "DASHBOARD"
        dashButton.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TextBox12)
        Panel2.Controls.Add(TextBox13)
        Panel2.Controls.Add(TextBox14)
        Panel2.Controls.Add(TextBox15)
        Panel2.Controls.Add(TextBox16)
        Panel2.Controls.Add(TextBox17)
        Panel2.Controls.Add(TextBox18)
        Panel2.Controls.Add(TextBox19)
        Panel2.Controls.Add(TextBox20)
        Panel2.Controls.Add(TextBox21)
        Panel2.Controls.Add(TextBox22)
        Panel2.Controls.Add(ComboBox2)
        Panel2.Controls.Add(IconButton2)
        Panel2.Controls.Add(IconButton3)
        Panel2.Controls.Add(TextBox11)
        Panel2.Controls.Add(TextBox10)
        Panel2.Controls.Add(TextBox9)
        Panel2.Controls.Add(TextBox8)
        Panel2.Controls.Add(TextBox7)
        Panel2.Controls.Add(TextBox6)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(modButton1)
        Panel2.Controls.Add(regButton1)
        Panel2.Controls.Add(barButton)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(facultyTable)
        Panel2.Controls.Add(studTable)
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(340, 0)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1156, 1050)
        Panel2.TabIndex = 14
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Tomato
        ComboBox1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.ItemHeight = 22
        ComboBox1.Items.AddRange(New Object() {"Active", "Inactive", "Suspended", "Graduated", "Transferred"})
        ComboBox1.Location = New Point(845, 453)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(251, 30)
        ComboBox1.TabIndex = 32
        ComboBox1.Tag = ""
        ComboBox1.Text = "STATUS"
        ' 
        ' modButton1
        ' 
        modButton1.BackColor = Color.Tomato
        modButton1.Cursor = Cursors.Hand
        modButton1.FlatAppearance.BorderSize = 0
        modButton1.FlatStyle = FlatStyle.Flat
        modButton1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        modButton1.IconChar = FontAwesome.Sharp.IconChar.None
        modButton1.IconColor = Color.Black
        modButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        modButton1.Location = New Point(989, 407)
        modButton1.Margin = New Padding(4, 5, 4, 5)
        modButton1.Name = "modButton1"
        modButton1.Size = New Size(107, 38)
        modButton1.TabIndex = 27
        modButton1.Text = "MODIFY"
        modButton1.UseVisualStyleBackColor = False
        ' 
        ' regButton1
        ' 
        regButton1.BackColor = Color.Tomato
        regButton1.Cursor = Cursors.Hand
        regButton1.FlatAppearance.BorderSize = 0
        regButton1.FlatStyle = FlatStyle.Flat
        regButton1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        regButton1.IconChar = FontAwesome.Sharp.IconChar.None
        regButton1.IconColor = Color.Black
        regButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        regButton1.Location = New Point(845, 407)
        regButton1.Margin = New Padding(4, 5, 4, 5)
        regButton1.Name = "regButton1"
        regButton1.Size = New Size(136, 38)
        regButton1.TabIndex = 25
        regButton1.Text = "REGISTER"
        regButton1.UseVisualStyleBackColor = False
        ' 
        ' barButton
        ' 
        barButton.Cursor = Cursors.Hand
        barButton.FlatAppearance.BorderSize = 0
        barButton.FlatStyle = FlatStyle.Flat
        barButton.IconChar = FontAwesome.Sharp.IconChar.Navicon
        barButton.IconColor = Color.Black
        barButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        barButton.IconSize = 25
        barButton.Location = New Point(1089, 20)
        barButton.Margin = New Padding(4, 5, 4, 5)
        barButton.Name = "barButton"
        barButton.Size = New Size(50, 62)
        barButton.TabIndex = 24
        barButton.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(67, 523)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 25)
        Label3.TabIndex = 15
        Label3.Text = "FACULTY"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(67, 126)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 25)
        Label2.TabIndex = 14
        Label2.Text = "STUDENTS"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' facultyTable
        ' 
        facultyTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        facultyTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        facultyTable.GridColor = Color.White
        facultyTable.Location = New Point(67, 561)
        facultyTable.Margin = New Padding(4, 5, 4, 5)
        facultyTable.Name = "facultyTable"
        facultyTable.RowHeadersWidth = 62
        facultyTable.RowTemplate.Height = 25
        facultyTable.Size = New Size(770, 314)
        facultyTable.TabIndex = 13
        ' 
        ' studTable
        ' 
        studTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        studTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        studTable.GridColor = Color.White
        studTable.Location = New Point(67, 169)
        studTable.Margin = New Padding(4, 5, 4, 5)
        studTable.Name = "studTable"
        studTable.RowHeadersWidth = 62
        studTable.RowTemplate.Height = 25
        studTable.Size = New Size(770, 314)
        studTable.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(530, 32)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 25)
        Label4.TabIndex = 11
        Label4.Text = "USERS"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(846, 283)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(122, 31)
        TextBox1.TabIndex = 34
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(974, 283)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(122, 31)
        TextBox2.TabIndex = 35
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(846, 246)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(122, 31)
        TextBox3.TabIndex = 36
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(974, 246)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(122, 31)
        TextBox4.TabIndex = 37
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(846, 206)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(122, 31)
        TextBox5.TabIndex = 38
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(974, 206)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(122, 31)
        TextBox6.TabIndex = 39
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(846, 169)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(122, 31)
        TextBox7.TabIndex = 40
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(974, 169)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(122, 31)
        TextBox8.TabIndex = 41
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(846, 320)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(122, 31)
        TextBox9.TabIndex = 42
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(974, 320)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(122, 31)
        TextBox10.TabIndex = 43
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(846, 357)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(122, 31)
        TextBox11.TabIndex = 44
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(846, 749)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(122, 31)
        TextBox12.TabIndex = 58
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(974, 712)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(122, 31)
        TextBox13.TabIndex = 57
        ' 
        ' TextBox14
        ' 
        TextBox14.Location = New Point(846, 712)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(122, 31)
        TextBox14.TabIndex = 56
        ' 
        ' TextBox15
        ' 
        TextBox15.Location = New Point(974, 561)
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(122, 31)
        TextBox15.TabIndex = 55
        ' 
        ' TextBox16
        ' 
        TextBox16.Location = New Point(846, 561)
        TextBox16.Name = "TextBox16"
        TextBox16.Size = New Size(122, 31)
        TextBox16.TabIndex = 54
        ' 
        ' TextBox17
        ' 
        TextBox17.Location = New Point(974, 598)
        TextBox17.Name = "TextBox17"
        TextBox17.Size = New Size(122, 31)
        TextBox17.TabIndex = 53
        ' 
        ' TextBox18
        ' 
        TextBox18.Location = New Point(846, 598)
        TextBox18.Name = "TextBox18"
        TextBox18.Size = New Size(122, 31)
        TextBox18.TabIndex = 52
        ' 
        ' TextBox19
        ' 
        TextBox19.Location = New Point(974, 638)
        TextBox19.Name = "TextBox19"
        TextBox19.Size = New Size(122, 31)
        TextBox19.TabIndex = 51
        ' 
        ' TextBox20
        ' 
        TextBox20.Location = New Point(846, 638)
        TextBox20.Name = "TextBox20"
        TextBox20.Size = New Size(122, 31)
        TextBox20.TabIndex = 50
        ' 
        ' TextBox21
        ' 
        TextBox21.Location = New Point(974, 675)
        TextBox21.Name = "TextBox21"
        TextBox21.Size = New Size(122, 31)
        TextBox21.TabIndex = 49
        ' 
        ' TextBox22
        ' 
        TextBox22.Location = New Point(846, 675)
        TextBox22.Name = "TextBox22"
        TextBox22.Size = New Size(122, 31)
        TextBox22.TabIndex = 48
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.Tomato
        ComboBox2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.ItemHeight = 22
        ComboBox2.Items.AddRange(New Object() {"Active", "Inactive", "Suspended", "Graduated", "Transferred"})
        ComboBox2.Location = New Point(845, 845)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(251, 30)
        ComboBox2.TabIndex = 47
        ComboBox2.Tag = ""
        ComboBox2.Text = "STATUS"
        ' 
        ' IconButton2
        ' 
        IconButton2.BackColor = Color.Tomato
        IconButton2.Cursor = Cursors.Hand
        IconButton2.FlatAppearance.BorderSize = 0
        IconButton2.FlatStyle = FlatStyle.Flat
        IconButton2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton2.IconColor = Color.Black
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.Location = New Point(989, 799)
        IconButton2.Margin = New Padding(4, 5, 4, 5)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(107, 38)
        IconButton2.TabIndex = 46
        IconButton2.Text = "MODIFY"
        IconButton2.UseVisualStyleBackColor = False
        ' 
        ' IconButton3
        ' 
        IconButton3.BackColor = Color.Tomato
        IconButton3.Cursor = Cursors.Hand
        IconButton3.FlatAppearance.BorderSize = 0
        IconButton3.FlatStyle = FlatStyle.Flat
        IconButton3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton3.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton3.IconColor = Color.Black
        IconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton3.Location = New Point(845, 799)
        IconButton3.Margin = New Padding(4, 5, 4, 5)
        IconButton3.Name = "IconButton3"
        IconButton3.Size = New Size(136, 38)
        IconButton3.TabIndex = 45
        IconButton3.Text = "REGISTER"
        IconButton3.UseVisualStyleBackColor = False
        ' 
        ' UserList
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1496, 1050)
        Controls.Add(Panel2)
        Controls.Add(userPanel)
        Margin = New Padding(4, 5, 4, 5)
        Name = "UserList"
        Text = "UserList"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        userPanel.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(facultyTable, ComponentModel.ISupportInitialize).EndInit()
        CType(studTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents userPanel As Panel
    Friend WithEvents borrowButton As FontAwesome.Sharp.IconButton
    Friend WithEvents archiveButton As FontAwesome.Sharp.IconButton
    Friend WithEvents userButton As FontAwesome.Sharp.IconButton
    Friend WithEvents bookButton As FontAwesome.Sharp.IconButton
    Friend WithEvents dashButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents facultyTable As DataGridView
    Friend WithEvents studTable As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents barButton As FontAwesome.Sharp.IconButton
    Friend WithEvents modButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents regButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
End Class
