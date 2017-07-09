<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSports
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
        Dim Player_NumberLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Parent_Name_s_Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSports))
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim Zip_CodeLabel As System.Windows.Forms.Label
        Dim Telephone_NumberLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLittleLeague = New System.Windows.Forms.Label()
        Me.btnAges = New System.Windows.Forms.Button()
        Me.LittleLeagueDataSet = New Week4Day2Sports.LittleLeagueDataSet()
        Me.TeamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamTableAdapter = New Week4Day2Sports.LittleLeagueDataSetTableAdapters.TeamTableAdapter()
        Me.TableAdapterManager = New Week4Day2Sports.LittleLeagueDataSetTableAdapters.TableAdapterManager()
        Me.TeamBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TeamBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Player_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Parent_Name_s_TextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.Zip_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Telephone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.lbl12YearOlds = New System.Windows.Forms.Label()
        Me.lbl13YearOlds = New System.Windows.Forms.Label()
        Me.lbl14YearOlds = New System.Windows.Forms.Label()
        Me.lblAverageAges = New System.Windows.Forms.Label()
        Player_NumberLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Parent_Name_s_Label = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        Zip_CodeLabel = New System.Windows.Forms.Label()
        Telephone_NumberLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LittleLeagueDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TeamBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Player_NumberLabel
        '
        Player_NumberLabel.AutoSize = True
        Player_NumberLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Player_NumberLabel.Location = New System.Drawing.Point(239, 79)
        Player_NumberLabel.Name = "Player_NumberLabel"
        Player_NumberLabel.Size = New System.Drawing.Size(90, 15)
        Player_NumberLabel.TabIndex = 4
        Player_NumberLabel.Text = "Player Number:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(258, 115)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(70, 15)
        First_NameLabel.TabIndex = 6
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(257, 152)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(68, 15)
        Last_NameLabel.TabIndex = 8
        Last_NameLabel.Text = "Last Name:"
        '
        'Parent_Name_s_Label
        '
        Parent_Name_s_Label.AutoSize = True
        Parent_Name_s_Label.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Parent_Name_s_Label.Location = New System.Drawing.Point(235, 188)
        Parent_Name_s_Label.Name = "Parent_Name_s_Label"
        Parent_Name_s_Label.Size = New System.Drawing.Size(94, 15)
        Parent_Name_s_Label.TabIndex = 10
        Parent_Name_s_Label.Text = "Parent Name(s):"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Week4Day2Sports.My.Resources.Resources.baseball_fever_1875_team_lg
        Me.PictureBox1.Location = New System.Drawing.Point(0, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblLittleLeague
        '
        Me.lblLittleLeague.AutoSize = True
        Me.lblLittleLeague.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLittleLeague.Location = New System.Drawing.Point(296, 29)
        Me.lblLittleLeague.Name = "lblLittleLeague"
        Me.lblLittleLeague.Size = New System.Drawing.Size(253, 29)
        Me.lblLittleLeague.TabIndex = 1
        Me.lblLittleLeague.Text = "Little League Players"
        '
        'btnAges
        '
        Me.btnAges.BackColor = System.Drawing.Color.Sienna
        Me.btnAges.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAges.ForeColor = System.Drawing.Color.White
        Me.btnAges.Location = New System.Drawing.Point(252, 262)
        Me.btnAges.Name = "btnAges"
        Me.btnAges.Size = New System.Drawing.Size(113, 41)
        Me.btnAges.TabIndex = 2
        Me.btnAges.Text = "Ages"
        Me.btnAges.UseVisualStyleBackColor = False
        '
        'LittleLeagueDataSet
        '
        Me.LittleLeagueDataSet.DataSetName = "LittleLeagueDataSet"
        Me.LittleLeagueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeamBindingSource
        '
        Me.TeamBindingSource.DataMember = "Team"
        Me.TeamBindingSource.DataSource = Me.LittleLeagueDataSet
        '
        'TeamTableAdapter
        '
        Me.TeamTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TeamTableAdapter = Me.TeamTableAdapter
        Me.TableAdapterManager.UpdateOrder = Week4Day2Sports.LittleLeagueDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TeamBindingNavigator
        '
        Me.TeamBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TeamBindingNavigator.BindingSource = Me.TeamBindingSource
        Me.TeamBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TeamBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TeamBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TeamBindingNavigatorSaveItem})
        Me.TeamBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TeamBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TeamBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TeamBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TeamBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TeamBindingNavigator.Name = "TeamBindingNavigator"
        Me.TeamBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TeamBindingNavigator.Size = New System.Drawing.Size(617, 25)
        Me.TeamBindingNavigator.TabIndex = 3
        Me.TeamBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TeamBindingNavigatorSaveItem
        '
        Me.TeamBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TeamBindingNavigatorSaveItem.Image = CType(resources.GetObject("TeamBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TeamBindingNavigatorSaveItem.Name = "TeamBindingNavigatorSaveItem"
        Me.TeamBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TeamBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Player_NumberTextBox
        '
        Me.Player_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Player Number", True))
        Me.Player_NumberTextBox.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player_NumberTextBox.Location = New System.Drawing.Point(333, 76)
        Me.Player_NumberTextBox.Name = "Player_NumberTextBox"
        Me.Player_NumberTextBox.Size = New System.Drawing.Size(100, 21)
        Me.Player_NumberTextBox.TabIndex = 5
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "First Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(333, 112)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.First_NameTextBox.TabIndex = 7
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(333, 149)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(152, 21)
        Me.Last_NameTextBox.TabIndex = 9
        '
        'Parent_Name_s_TextBox
        '
        Me.Parent_Name_s_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Parent Name(s)", True))
        Me.Parent_Name_s_TextBox.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parent_Name_s_TextBox.Location = New System.Drawing.Point(333, 185)
        Me.Parent_Name_s_TextBox.Name = "Parent_Name_s_TextBox"
        Me.Parent_Name_s_TextBox.Size = New System.Drawing.Size(152, 21)
        Me.Parent_Name_s_TextBox.TabIndex = 11
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(446, 78)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(51, 15)
        AddressLabel.TabIndex = 12
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(500, 75)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 21)
        Me.AddressTextBox.TabIndex = 13
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(467, 114)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(31, 15)
        CityLabel.TabIndex = 14
        CityLabel.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "City", True))
        Me.CityTextBox.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(500, 111)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 21)
        Me.CityTextBox.TabIndex = 15
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StateLabel.Location = New System.Drawing.Point(509, 152)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(36, 15)
        StateLabel.TabIndex = 16
        StateLabel.Text = "State:"
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "State", True))
        Me.StateTextBox.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateTextBox.Location = New System.Drawing.Point(550, 148)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(50, 21)
        Me.StateTextBox.TabIndex = 17
        '
        'Zip_CodeLabel
        '
        Zip_CodeLabel.AutoSize = True
        Zip_CodeLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Zip_CodeLabel.Location = New System.Drawing.Point(491, 188)
        Zip_CodeLabel.Name = "Zip_CodeLabel"
        Zip_CodeLabel.Size = New System.Drawing.Size(55, 15)
        Zip_CodeLabel.TabIndex = 18
        Zip_CodeLabel.Text = "Zip Code:"
        '
        'Zip_CodeTextBox
        '
        Me.Zip_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Zip Code", True))
        Me.Zip_CodeTextBox.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zip_CodeTextBox.Location = New System.Drawing.Point(550, 185)
        Me.Zip_CodeTextBox.Name = "Zip_CodeTextBox"
        Me.Zip_CodeTextBox.Size = New System.Drawing.Size(49, 21)
        Me.Zip_CodeTextBox.TabIndex = 19
        '
        'Telephone_NumberLabel
        '
        Telephone_NumberLabel.AutoSize = True
        Telephone_NumberLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telephone_NumberLabel.Location = New System.Drawing.Point(217, 224)
        Telephone_NumberLabel.Name = "Telephone_NumberLabel"
        Telephone_NumberLabel.Size = New System.Drawing.Size(109, 15)
        Telephone_NumberLabel.TabIndex = 20
        Telephone_NumberLabel.Text = "Telephone Number:"
        '
        'Telephone_NumberTextBox
        '
        Me.Telephone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Telephone Number", True))
        Me.Telephone_NumberTextBox.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telephone_NumberTextBox.Location = New System.Drawing.Point(333, 221)
        Me.Telephone_NumberTextBox.Name = "Telephone_NumberTextBox"
        Me.Telephone_NumberTextBox.Size = New System.Drawing.Size(100, 21)
        Me.Telephone_NumberTextBox.TabIndex = 21
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Location = New System.Drawing.Point(465, 223)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(30, 15)
        AgeLabel.TabIndex = 22
        AgeLabel.Text = "Age:"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Age", True))
        Me.AgeTextBox.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(500, 220)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 21)
        Me.AgeTextBox.TabIndex = 23
        '
        'lbl12YearOlds
        '
        Me.lbl12YearOlds.AutoSize = True
        Me.lbl12YearOlds.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12YearOlds.ForeColor = System.Drawing.Color.Brown
        Me.lbl12YearOlds.Location = New System.Drawing.Point(210, 320)
        Me.lbl12YearOlds.Name = "lbl12YearOlds"
        Me.lbl12YearOlds.Size = New System.Drawing.Size(197, 15)
        Me.lbl12YearOlds.TabIndex = 24
        Me.lbl12YearOlds.Text = "Total number of 12-year-old players"
        Me.lbl12YearOlds.Visible = False
        '
        'lbl13YearOlds
        '
        Me.lbl13YearOlds.AutoSize = True
        Me.lbl13YearOlds.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13YearOlds.ForeColor = System.Drawing.Color.Brown
        Me.lbl13YearOlds.Location = New System.Drawing.Point(210, 345)
        Me.lbl13YearOlds.Name = "lbl13YearOlds"
        Me.lbl13YearOlds.Size = New System.Drawing.Size(197, 15)
        Me.lbl13YearOlds.TabIndex = 25
        Me.lbl13YearOlds.Text = "Total number of 13-year-old players"
        Me.lbl13YearOlds.Visible = False
        '
        'lbl14YearOlds
        '
        Me.lbl14YearOlds.AutoSize = True
        Me.lbl14YearOlds.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl14YearOlds.ForeColor = System.Drawing.Color.Brown
        Me.lbl14YearOlds.Location = New System.Drawing.Point(210, 370)
        Me.lbl14YearOlds.Name = "lbl14YearOlds"
        Me.lbl14YearOlds.Size = New System.Drawing.Size(197, 15)
        Me.lbl14YearOlds.TabIndex = 26
        Me.lbl14YearOlds.Text = "Total number of 14-year-old players"
        Me.lbl14YearOlds.Visible = False
        '
        'lblAverageAges
        '
        Me.lblAverageAges.AutoSize = True
        Me.lblAverageAges.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageAges.ForeColor = System.Drawing.Color.Brown
        Me.lblAverageAges.Location = New System.Drawing.Point(210, 395)
        Me.lblAverageAges.Name = "lblAverageAges"
        Me.lblAverageAges.Size = New System.Drawing.Size(144, 15)
        Me.lblAverageAges.TabIndex = 27
        Me.lblAverageAges.Text = "Average age of all players"
        Me.lblAverageAges.Visible = False
        '
        'frmSports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 429)
        Me.Controls.Add(Me.lblAverageAges)
        Me.Controls.Add(Me.lbl14YearOlds)
        Me.Controls.Add(Me.lbl13YearOlds)
        Me.Controls.Add(Me.lbl12YearOlds)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Telephone_NumberLabel)
        Me.Controls.Add(Me.Telephone_NumberTextBox)
        Me.Controls.Add(Zip_CodeLabel)
        Me.Controls.Add(Me.Zip_CodeTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Parent_Name_s_Label)
        Me.Controls.Add(Me.Parent_Name_s_TextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Player_NumberLabel)
        Me.Controls.Add(Me.Player_NumberTextBox)
        Me.Controls.Add(Me.TeamBindingNavigator)
        Me.Controls.Add(Me.btnAges)
        Me.Controls.Add(Me.lblLittleLeague)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmSports"
        Me.Text = "National Sports League co-ed Championships"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LittleLeagueDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TeamBindingNavigator.ResumeLayout(False)
        Me.TeamBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLittleLeague As System.Windows.Forms.Label
    Friend WithEvents btnAges As System.Windows.Forms.Button
    Friend WithEvents LittleLeagueDataSet As Week4Day2Sports.LittleLeagueDataSet
    Friend WithEvents TeamBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeamTableAdapter As Week4Day2Sports.LittleLeagueDataSetTableAdapters.TeamTableAdapter
    Friend WithEvents TableAdapterManager As Week4Day2Sports.LittleLeagueDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TeamBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TeamBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Player_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Parent_Name_s_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zip_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telephone_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lbl12YearOlds As System.Windows.Forms.Label
    Friend WithEvents lbl13YearOlds As System.Windows.Forms.Label
    Friend WithEvents lbl14YearOlds As System.Windows.Forms.Label
    Friend WithEvents lblAverageAges As System.Windows.Forms.Label

End Class
