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
        searchBoxFaculty = New TextBox()
        facultyTable = New DataGridView()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewLinkColumn()
        Column14 = New DataGridViewLinkColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewLinkColumn()
        Column17 = New DataGridViewTextBoxColumn()
        Status_IDEM = New DataGridViewTextBoxColumn()
        searchBoxStud = New TextBox()
        IconButton6 = New FontAwesome.Sharp.IconButton()
        IconButton7 = New FontAwesome.Sharp.IconButton()
        IconButton5 = New FontAwesome.Sharp.IconButton()
        IconButton4 = New FontAwesome.Sharp.IconButton()
        P2 = New TextBox()
        SID2 = New TextBox()
        AC2 = New TextBox()
        FN2 = New TextBox()
        UID2 = New TextBox()
        BTID2 = New TextBox()
        E2 = New TextBox()
        CN2 = New TextBox()
        A2 = New TextBox()
        DID2 = New TextBox()
        ComboBox2 = New ComboBox()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton3 = New FontAwesome.Sharp.IconButton()
        P1 = New TextBox()
        S1 = New TextBox()
        AC1 = New TextBox()
        FN1 = New TextBox()
        UID1 = New TextBox()
        BT1 = New TextBox()
        E1 = New TextBox()
        CN1 = New TextBox()
        A1 = New TextBox()
        C1 = New TextBox()
        PID1 = New TextBox()
        ComboBox1 = New ComboBox()
        modButton1 = New FontAwesome.Sharp.IconButton()
        regButton1 = New FontAwesome.Sharp.IconButton()
        barButton = New FontAwesome.Sharp.IconButton()
        Label3 = New Label()
        Label2 = New Label()
        studTable = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewLinkColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewLinkColumn()
        Column8 = New DataGridViewLinkColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Status_ID = New DataGridViewLinkColumn()
        Label4 = New Label()
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
        Panel2.Controls.Add(searchBoxFaculty)
        Panel2.Controls.Add(facultyTable)
        Panel2.Controls.Add(searchBoxStud)
        Panel2.Controls.Add(IconButton6)
        Panel2.Controls.Add(IconButton7)
        Panel2.Controls.Add(IconButton5)
        Panel2.Controls.Add(IconButton4)
        Panel2.Controls.Add(P2)
        Panel2.Controls.Add(SID2)
        Panel2.Controls.Add(AC2)
        Panel2.Controls.Add(FN2)
        Panel2.Controls.Add(UID2)
        Panel2.Controls.Add(BTID2)
        Panel2.Controls.Add(E2)
        Panel2.Controls.Add(CN2)
        Panel2.Controls.Add(A2)
        Panel2.Controls.Add(DID2)
        Panel2.Controls.Add(ComboBox2)
        Panel2.Controls.Add(IconButton2)
        Panel2.Controls.Add(IconButton3)
        Panel2.Controls.Add(P1)
        Panel2.Controls.Add(S1)
        Panel2.Controls.Add(AC1)
        Panel2.Controls.Add(FN1)
        Panel2.Controls.Add(UID1)
        Panel2.Controls.Add(BT1)
        Panel2.Controls.Add(E1)
        Panel2.Controls.Add(CN1)
        Panel2.Controls.Add(A1)
        Panel2.Controls.Add(C1)
        Panel2.Controls.Add(PID1)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(modButton1)
        Panel2.Controls.Add(regButton1)
        Panel2.Controls.Add(barButton)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(studTable)
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(340, 0)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1156, 1050)
        Panel2.TabIndex = 14
        ' 
        ' searchBoxFaculty
        ' 
        searchBoxFaculty.Location = New Point(50, 593)
        searchBoxFaculty.Margin = New Padding(4, 5, 4, 5)
        searchBoxFaculty.Name = "searchBoxFaculty"
        searchBoxFaculty.PlaceholderText = "Faculty ID"
        searchBoxFaculty.Size = New Size(291, 31)
        searchBoxFaculty.TabIndex = 66
        ' 
        ' facultyTable
        ' 
        facultyTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        facultyTable.BackgroundColor = Color.White
        facultyTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        facultyTable.Columns.AddRange(New DataGridViewColumn() {Column10, Column11, Column12, Column13, Column14, Column15, Column16, Column17, Status_IDEM})
        facultyTable.GridColor = Color.White
        facultyTable.Location = New Point(53, 693)
        facultyTable.Margin = New Padding(4, 5, 4, 5)
        facultyTable.Name = "facultyTable"
        facultyTable.ReadOnly = True
        facultyTable.RowHeadersVisible = False
        facultyTable.RowHeadersWidth = 62
        facultyTable.RowTemplate.Height = 25
        facultyTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        facultyTable.Size = New Size(1054, 280)
        facultyTable.TabIndex = 65
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column10.HeaderText = "Faculty ID"
        Column10.MinimumWidth = 8
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 125
        ' 
        ' Column11
        ' 
        Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column11.HeaderText = "Fullname"
        Column11.MinimumWidth = 8
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 119
        ' 
        ' Column12
        ' 
        Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column12.HeaderText = "Email"
        Column12.MinimumWidth = 8
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        Column12.Width = 90
        ' 
        ' Column13
        ' 
        Column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column13.HeaderText = "Borrower Type ID"
        Column13.MinimumWidth = 8
        Column13.Name = "Column13"
        Column13.ReadOnly = True
        Column13.Width = 155
        ' 
        ' Column14
        ' 
        Column14.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column14.HeaderText = "Address"
        Column14.MinimumWidth = 8
        Column14.Name = "Column14"
        Column14.ReadOnly = True
        Column14.Width = 83
        ' 
        ' Column15
        ' 
        Column15.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column15.HeaderText = "Contact Number"
        Column15.MinimumWidth = 8
        Column15.Name = "Column15"
        Column15.ReadOnly = True
        Column15.Width = 179
        ' 
        ' Column16
        ' 
        Column16.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column16.HeaderText = "Department ID"
        Column16.MinimumWidth = 8
        Column16.Name = "Column16"
        Column16.ReadOnly = True
        Column16.Width = 136
        ' 
        ' Column17
        ' 
        Column17.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column17.HeaderText = "Account Created"
        Column17.MinimumWidth = 8
        Column17.Name = "Column17"
        Column17.ReadOnly = True
        Column17.Width = 179
        ' 
        ' Status_IDEM
        ' 
        Status_IDEM.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Status_IDEM.HeaderText = "Status ID"
        Status_IDEM.MinimumWidth = 8
        Status_IDEM.Name = "Status_IDEM"
        Status_IDEM.ReadOnly = True
        Status_IDEM.Width = 119
        ' 
        ' searchBoxStud
        ' 
        searchBoxStud.Location = New Point(51, 95)
        searchBoxStud.Name = "searchBoxStud"
        searchBoxStud.PlaceholderText = "Student ID"
        searchBoxStud.Size = New Size(290, 31)
        searchBoxStud.TabIndex = 64
        ' 
        ' IconButton6
        ' 
        IconButton6.BackColor = Color.Tomato
        IconButton6.Cursor = Cursors.Hand
        IconButton6.FlatAppearance.BorderSize = 0
        IconButton6.FlatStyle = FlatStyle.Flat
        IconButton6.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton6.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton6.IconColor = Color.Black
        IconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton6.Location = New Point(691, 647)
        IconButton6.Margin = New Padding(4, 5, 4, 5)
        IconButton6.Name = "IconButton6"
        IconButton6.Size = New Size(160, 38)
        IconButton6.TabIndex = 62
        IconButton6.Text = "SELECT ROW"
        IconButton6.UseVisualStyleBackColor = False
        ' 
        ' IconButton7
        ' 
        IconButton7.BackColor = Color.Tomato
        IconButton7.Cursor = Cursors.Hand
        IconButton7.FlatAppearance.BorderSize = 0
        IconButton7.FlatStyle = FlatStyle.Flat
        IconButton7.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton7.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton7.IconColor = Color.Black
        IconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton7.Location = New Point(987, 647)
        IconButton7.Margin = New Padding(4, 5, 4, 5)
        IconButton7.Name = "IconButton7"
        IconButton7.Size = New Size(120, 38)
        IconButton7.TabIndex = 61
        IconButton7.Text = "REFRESH"
        IconButton7.UseVisualStyleBackColor = False
        ' 
        ' IconButton5
        ' 
        IconButton5.BackColor = Color.Tomato
        IconButton5.Cursor = Cursors.Hand
        IconButton5.FlatAppearance.BorderSize = 0
        IconButton5.FlatStyle = FlatStyle.Flat
        IconButton5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton5.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton5.IconColor = Color.Black
        IconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton5.Location = New Point(690, 153)
        IconButton5.Margin = New Padding(4, 5, 4, 5)
        IconButton5.Name = "IconButton5"
        IconButton5.Size = New Size(160, 38)
        IconButton5.TabIndex = 60
        IconButton5.Text = "SELECT ROW"
        IconButton5.UseVisualStyleBackColor = False
        ' 
        ' IconButton4
        ' 
        IconButton4.BackColor = Color.Tomato
        IconButton4.Cursor = Cursors.Hand
        IconButton4.FlatAppearance.BorderSize = 0
        IconButton4.FlatStyle = FlatStyle.Flat
        IconButton4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton4.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton4.IconColor = Color.Black
        IconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton4.Location = New Point(986, 153)
        IconButton4.Margin = New Padding(4, 5, 4, 5)
        IconButton4.Name = "IconButton4"
        IconButton4.Size = New Size(120, 38)
        IconButton4.TabIndex = 59
        IconButton4.Text = "REFRESH"
        IconButton4.UseVisualStyleBackColor = False
        ' 
        ' P2
        ' 
        P2.Location = New Point(901, 982)
        P2.Name = "P2"
        P2.Size = New Size(100, 31)
        P2.TabIndex = 58
        P2.Text = "password"
        ' 
        ' SID2
        ' 
        SID2.Location = New Point(1007, 982)
        SID2.Name = "SID2"
        SID2.Size = New Size(100, 31)
        SID2.TabIndex = 57
        SID2.Text = "Status_ID"
        ' 
        ' AC2
        ' 
        AC2.Location = New Point(796, 982)
        AC2.Name = "AC2"
        AC2.Size = New Size(100, 31)
        AC2.TabIndex = 56
        AC2.Text = "Account_Created"
        ' 
        ' FN2
        ' 
        FN2.Location = New Point(160, 982)
        FN2.Name = "FN2"
        FN2.Size = New Size(100, 31)
        FN2.TabIndex = 55
        FN2.Text = "Fullname"
        ' 
        ' UID2
        ' 
        UID2.Location = New Point(53, 982)
        UID2.Name = "UID2"
        UID2.Size = New Size(100, 31)
        UID2.TabIndex = 54
        UID2.Text = "User_ID"
        ' 
        ' BTID2
        ' 
        BTID2.Location = New Point(371, 982)
        BTID2.Name = "BTID2"
        BTID2.Size = New Size(100, 31)
        BTID2.TabIndex = 53
        BTID2.Text = "BorrowerType_ID"
        ' 
        ' E2
        ' 
        E2.Location = New Point(266, 982)
        E2.Name = "E2"
        E2.Size = New Size(100, 31)
        E2.TabIndex = 52
        E2.Text = "Email"
        ' 
        ' CN2
        ' 
        CN2.Location = New Point(583, 982)
        CN2.Name = "CN2"
        CN2.Size = New Size(100, 31)
        CN2.TabIndex = 51
        CN2.Text = "Contact Number"
        ' 
        ' A2
        ' 
        A2.Location = New Point(477, 982)
        A2.Name = "A2"
        A2.Size = New Size(100, 31)
        A2.TabIndex = 50
        A2.Text = "Address"
        ' 
        ' DID2
        ' 
        DID2.Location = New Point(690, 982)
        DID2.Name = "DID2"
        DID2.Size = New Size(100, 31)
        DID2.TabIndex = 48
        DID2.Text = "Department_ID"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.Tomato
        ComboBox2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.ItemHeight = 22
        ComboBox2.Items.AddRange(New Object() {"Active", "Inactive", "Suspended", "Graduated", "Transferred"})
        ComboBox2.Location = New Point(430, 647)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(123, 30)
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
        IconButton2.Location = New Point(860, 647)
        IconButton2.Margin = New Padding(4, 5, 4, 5)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(121, 38)
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
        IconButton3.Location = New Point(560, 647)
        IconButton3.Margin = New Padding(4, 5, 4, 5)
        IconButton3.Name = "IconButton3"
        IconButton3.Size = New Size(123, 38)
        IconButton3.TabIndex = 45
        IconButton3.Text = "REGISTER"
        IconButton3.UseVisualStyleBackColor = False
        ' 
        ' P1
        ' 
        P1.Location = New Point(1006, 488)
        P1.Name = "P1"
        P1.Size = New Size(100, 31)
        P1.TabIndex = 44
        P1.Text = "password"
        ' 
        ' S1
        ' 
        S1.Location = New Point(914, 488)
        S1.Name = "S1"
        S1.Size = New Size(85, 31)
        S1.TabIndex = 43
        S1.Text = "Status_ID"
        ' 
        ' AC1
        ' 
        AC1.Location = New Point(824, 488)
        AC1.Name = "AC1"
        AC1.Size = New Size(85, 31)
        AC1.TabIndex = 42
        AC1.Text = "Account_Created"
        ' 
        ' FN1
        ' 
        FN1.Location = New Point(143, 488)
        FN1.Name = "FN1"
        FN1.Size = New Size(85, 31)
        FN1.TabIndex = 41
        FN1.Text = "Fullname"
        ' 
        ' UID1
        ' 
        UID1.Location = New Point(51, 488)
        UID1.Name = "UID1"
        UID1.Size = New Size(85, 31)
        UID1.TabIndex = 40
        UID1.Text = "User_ID"
        ' 
        ' BT1
        ' 
        BT1.Location = New Point(326, 488)
        BT1.Name = "BT1"
        BT1.Size = New Size(85, 31)
        BT1.TabIndex = 39
        BT1.Text = "BorrowerType_ID"
        ' 
        ' E1
        ' 
        E1.Location = New Point(234, 488)
        E1.Name = "E1"
        E1.Size = New Size(85, 31)
        E1.TabIndex = 38
        E1.Text = "Email"
        ' 
        ' CN1
        ' 
        CN1.Location = New Point(550, 488)
        CN1.Name = "CN1"
        CN1.Size = New Size(85, 31)
        CN1.TabIndex = 37
        CN1.Text = "Contact Number"
        ' 
        ' A1
        ' 
        A1.Location = New Point(416, 488)
        A1.Name = "A1"
        A1.Size = New Size(128, 31)
        A1.TabIndex = 36
        A1.Text = "Address"
        ' 
        ' C1
        ' 
        C1.Location = New Point(733, 488)
        C1.Name = "C1"
        C1.Size = New Size(85, 31)
        C1.TabIndex = 35
        C1.Text = "Campus_ID"
        ' 
        ' PID1
        ' 
        PID1.Location = New Point(641, 488)
        PID1.Name = "PID1"
        PID1.Size = New Size(85, 31)
        PID1.TabIndex = 34
        PID1.Text = "Program_ID"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Tomato
        ComboBox1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.ItemHeight = 22
        ComboBox1.Items.AddRange(New Object() {"Active", "Inactive", "Suspended", "Graduated", "Transferred"})
        ComboBox1.Location = New Point(429, 153)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(123, 30)
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
        modButton1.Location = New Point(859, 153)
        modButton1.Margin = New Padding(4, 5, 4, 5)
        modButton1.Name = "modButton1"
        modButton1.Size = New Size(121, 38)
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
        regButton1.Location = New Point(559, 153)
        regButton1.Margin = New Padding(4, 5, 4, 5)
        regButton1.Name = "regButton1"
        regButton1.Size = New Size(123, 38)
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
        Label3.Location = New Point(53, 652)
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
        Label2.Location = New Point(66, 158)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 25)
        Label2.TabIndex = 14
        Label2.Text = "STUDENTS"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' studTable
        ' 
        studTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        studTable.BackgroundColor = Color.White
        studTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        studTable.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Status_ID})
        studTable.GridColor = Color.White
        studTable.Location = New Point(51, 202)
        studTable.Margin = New Padding(4, 5, 4, 5)
        studTable.Name = "studTable"
        studTable.ReadOnly = True
        studTable.RowHeadersVisible = False
        studTable.RowHeadersWidth = 62
        studTable.RowTemplate.Height = 25
        studTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        studTable.Size = New Size(1054, 280)
        studTable.TabIndex = 12
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "User ID"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Fullname"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Email"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Borrower Type ID"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Resizable = DataGridViewTriState.True
        Column4.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Address"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Contact Number"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Program ID"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Campus ID"
        Column8.MinimumWidth = 8
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Account Created"
        Column9.MinimumWidth = 8
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        ' 
        ' Status_ID
        ' 
        Status_ID.HeaderText = "Status ID"
        Status_ID.MinimumWidth = 8
        Status_ID.Name = "Status_ID"
        Status_ID.ReadOnly = True
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Bebas Neue", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(66, 20)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 48)
        Label4.TabIndex = 11
        Label4.Text = "USERS"
        Label4.TextAlign = ContentAlignment.MiddleCenter
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
        StartPosition = FormStartPosition.CenterScreen
        Text = "s"
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
    Friend WithEvents studTable As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents barButton As FontAwesome.Sharp.IconButton
    Friend WithEvents modButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents regButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents P1 As TextBox
    Friend WithEvents S1 As TextBox
    Friend WithEvents AC1 As TextBox
    Friend WithEvents FN1 As TextBox
    Friend WithEvents BT1 As TextBox
    Friend WithEvents E1 As TextBox
    Friend WithEvents CN1 As TextBox
    Friend WithEvents A1 As TextBox
    Friend WithEvents C1 As TextBox
    Friend WithEvents PID1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents P2 As TextBox
    Friend WithEvents SID2 As TextBox
    Friend WithEvents AC2 As TextBox
    Friend WithEvents FN2 As TextBox
    Friend WithEvents UID2 As TextBox
    Friend WithEvents BTID2 As TextBox
    Friend WithEvents E2 As TextBox
    Friend WithEvents CN2 As TextBox
    Friend WithEvents A2 As TextBox
    Friend WithEvents DID2 As TextBox
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents UID1 As TextBox
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents searchBoxStud As TextBox
    Friend WithEvents facultyTable As DataGridView
    Friend WithEvents searchBoxFaculty As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewLinkColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewLinkColumn
    Friend WithEvents Column8 As DataGridViewLinkColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Status_ID As DataGridViewLinkColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewLinkColumn
    Friend WithEvents Column14 As DataGridViewLinkColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewLinkColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Status_IDEM As DataGridViewTextBoxColumn
End Class
