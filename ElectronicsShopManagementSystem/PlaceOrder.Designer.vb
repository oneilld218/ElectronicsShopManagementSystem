<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlaceOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlaceOrder))
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Home = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.id = New System.Windows.Forms.Label()
        Me.itemname = New System.Windows.Forms.TextBox()
        Me.qtty = New System.Windows.Forms.TextBox()
        Me.totalprice = New System.Windows.Forms.TextBox()
        Me.unitprice = New System.Windows.Forms.TextBox()
        Me.dated = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Place_Order_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Place_Order_TableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Place_Order_TableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.deletTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElectronicsShopManagementSystemDataSet3 = New ElectronicsShopManagementSystem.ElectronicsShopManagementSystemDataSet3()
        Me.Place_Order_TableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Place_Order_TableTableAdapter = New ElectronicsShopManagementSystem.ElectronicsShopManagementSystemDataSet3TableAdapters.Place_Order_TableTableAdapter()
        Me.TableAdapterManager = New ElectronicsShopManagementSystem.ElectronicsShopManagementSystemDataSet3TableAdapters.TableAdapterManager()
        Me.Place_Order_TableDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Place_Order_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Place_Order_TableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Place_Order_TableBindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ElectronicsShopManagementSystemDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Place_Order_TableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Place_Order_TableDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(473, 252)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(209, 21)
        Me.LinkLabel3.TabIndex = 23
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "EMPLOYEE DETAIL"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(473, 196)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(152, 21)
        Me.LinkLabel2.TabIndex = 22
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "PLACE ORDER"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(473, 140)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(208, 21)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "CUSTOMER DETAIL "
        '
        'Home
        '
        Me.Home.AutoSize = True
        Me.Home.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home.Location = New System.Drawing.Point(473, 84)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(70, 21)
        Me.Home.TabIndex = 20
        Me.Home.TabStop = True
        Me.Home.Text = "HOME"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.Location = New System.Drawing.Point(473, 308)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(91, 21)
        Me.LinkLabel4.TabIndex = 24
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "LOGOUT"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.Black
        Me.id.Location = New System.Drawing.Point(185, 49)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(21, 18)
        Me.id.TabIndex = 41
        Me.id.Text = "id"
        '
        'itemname
        '
        Me.itemname.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemname.ForeColor = System.Drawing.Color.Black
        Me.itemname.Location = New System.Drawing.Point(185, 123)
        Me.itemname.Name = "itemname"
        Me.itemname.Size = New System.Drawing.Size(200, 25)
        Me.itemname.TabIndex = 40
        '
        'qtty
        '
        Me.qtty.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtty.ForeColor = System.Drawing.Color.Black
        Me.qtty.Location = New System.Drawing.Point(185, 166)
        Me.qtty.Name = "qtty"
        Me.qtty.Size = New System.Drawing.Size(200, 25)
        Me.qtty.TabIndex = 38
        '
        'totalprice
        '
        Me.totalprice.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalprice.ForeColor = System.Drawing.Color.Black
        Me.totalprice.Location = New System.Drawing.Point(185, 252)
        Me.totalprice.Name = "totalprice"
        Me.totalprice.ReadOnly = True
        Me.totalprice.Size = New System.Drawing.Size(200, 25)
        Me.totalprice.TabIndex = 37
        '
        'unitprice
        '
        Me.unitprice.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unitprice.ForeColor = System.Drawing.Color.Black
        Me.unitprice.Location = New System.Drawing.Point(185, 209)
        Me.unitprice.Name = "unitprice"
        Me.unitprice.Size = New System.Drawing.Size(200, 25)
        Me.unitprice.TabIndex = 36
        '
        'dated
        '
        Me.dated.AutoSize = True
        Me.dated.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dated.ForeColor = System.Drawing.Color.Black
        Me.dated.Location = New System.Drawing.Point(61, 90)
        Me.dated.Name = "dated"
        Me.dated.Size = New System.Drawing.Size(38, 18)
        Me.dated.TabIndex = 35
        Me.dated.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(61, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 18)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Unit Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(61, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 18)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Qty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(61, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Bill No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Swis721 BlkEx BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(266, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "PLACE ORDER"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(61, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 18)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Item Name"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(287, 307)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 31)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(185, 307)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 31)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Place"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Place_Order_TableBindingSource
        '
        '
        'Place_Order_TableBindingNavigator
        '
        Me.Place_Order_TableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Place_Order_TableBindingNavigator.BindingSource = Me.Place_Order_TableBindingSource
        Me.Place_Order_TableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Place_Order_TableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Place_Order_TableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Place_Order_TableBindingNavigatorSaveItem})
        Me.Place_Order_TableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Place_Order_TableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Place_Order_TableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Place_Order_TableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Place_Order_TableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Place_Order_TableBindingNavigator.Name = "Place_Order_TableBindingNavigator"
        Me.Place_Order_TableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Place_Order_TableBindingNavigator.Size = New System.Drawing.Size(984, 25)
        Me.Place_Order_TableBindingNavigator.TabIndex = 49
        Me.Place_Order_TableBindingNavigator.Text = "BindingNavigator1"
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
        'Place_Order_TableBindingNavigatorSaveItem
        '
        Me.Place_Order_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Place_Order_TableBindingNavigatorSaveItem.Image = CType(resources.GetObject("Place_Order_TableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Place_Order_TableBindingNavigatorSaveItem.Name = "Place_Order_TableBindingNavigatorSaveItem"
        Me.Place_Order_TableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Place_Order_TableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.deletTextBox)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.LinkLabel4)
        Me.GroupBox2.Controls.Add(Me.LinkLabel3)
        Me.GroupBox2.Controls.Add(Me.LinkLabel2)
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.Home)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dated)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.unitprice)
        Me.GroupBox2.Controls.Add(Me.id)
        Me.GroupBox2.Controls.Add(Me.totalprice)
        Me.GroupBox2.Controls.Add(Me.itemname)
        Me.GroupBox2.Controls.Add(Me.qtty)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox2.Location = New System.Drawing.Point(231, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(730, 385)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Total Price"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'deletTextBox
        '
        Me.deletTextBox.Location = New System.Drawing.Point(185, 50)
        Me.deletTextBox.Name = "deletTextBox"
        Me.deletTextBox.Size = New System.Drawing.Size(33, 20)
        Me.deletTextBox.TabIndex = 50
        Me.deletTextBox.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(185, 85)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 49
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "item_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "item_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'qty
        '
        Me.qty.DataPropertyName = "qty"
        Me.qty.HeaderText = "qty"
        Me.qty.Name = "qty"
        '
        'unit_price
        '
        Me.unit_price.DataPropertyName = "unit_price"
        Me.unit_price.HeaderText = "unit_price"
        Me.unit_price.Name = "unit_price"
        '
        'total_price
        '
        Me.total_price.DataPropertyName = "total_price"
        Me.total_price.HeaderText = "total_price"
        Me.total_price.Name = "total_price"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Id"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'item_name
        '
        Me.item_name.DataPropertyName = "item_name"
        Me.item_name.HeaderText = "item_name"
        Me.item_name.Name = "item_name"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "qty"
        Me.DataGridViewTextBoxColumn7.HeaderText = "qty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "unit_price"
        Me.DataGridViewTextBoxColumn8.HeaderText = "unit_price"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "total_price"
        Me.DataGridViewTextBoxColumn9.HeaderText = "total_price"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'ElectronicsShopManagementSystemDataSet3
        '
        Me.ElectronicsShopManagementSystemDataSet3.DataSetName = "ElectronicsShopManagementSystemDataSet3"
        Me.ElectronicsShopManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Place_Order_TableBindingSource1
        '
        Me.Place_Order_TableBindingSource1.DataMember = "Place_Order_Table"
        Me.Place_Order_TableBindingSource1.DataSource = Me.ElectronicsShopManagementSystemDataSet3
        '
        'Place_Order_TableTableAdapter
        '
        Me.Place_Order_TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AddElectronics_TableTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_TableTableAdapter = Nothing
        Me.TableAdapterManager.Employee_TableTableAdapter = Nothing
        Me.TableAdapterManager.Place_Order_TableTableAdapter = Me.Place_Order_TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = ElectronicsShopManagementSystem.ElectronicsShopManagementSystemDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Place_Order_TableDataGridView1
        '
        Me.Place_Order_TableDataGridView1.AutoGenerateColumns = False
        Me.Place_Order_TableDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Place_Order_TableDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.Place_Order_TableDataGridView1.DataSource = Me.Place_Order_TableBindingSource1
        Me.Place_Order_TableDataGridView1.Location = New System.Drawing.Point(270, 486)
        Me.Place_Order_TableDataGridView1.Name = "Place_Order_TableDataGridView1"
        Me.Place_Order_TableDataGridView1.Size = New System.Drawing.Size(643, 220)
        Me.Place_Order_TableDataGridView1.TabIndex = 52
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "item_name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "item_name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "qty"
        Me.DataGridViewTextBoxColumn12.HeaderText = "qty"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "unit_price"
        Me.DataGridViewTextBoxColumn13.HeaderText = "unit_price"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "total_price"
        Me.DataGridViewTextBoxColumn14.HeaderText = "total_price"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn15.HeaderText = "date"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'PlaceOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = Global.ElectronicsShopManagementSystem.My.Resources.Resources.e_shopping_keyboard_web_thumb_large
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 717)
        Me.Controls.Add(Me.Place_Order_TableDataGridView1)
        Me.Controls.Add(Me.Place_Order_TableBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "PlaceOrder"
        Me.Text = "Electronics Shop Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Place_Order_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Place_Order_TableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Place_Order_TableBindingNavigator.ResumeLayout(False)
        Me.Place_Order_TableBindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ElectronicsShopManagementSystemDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Place_Order_TableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Place_Order_TableDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Home As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents id As Label
    Friend WithEvents itemname As TextBox
    Friend WithEvents qtty As TextBox
    Friend WithEvents totalprice As TextBox
    Friend WithEvents unitprice As TextBox
    Friend WithEvents dated As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Place_Order_TableBindingSource As BindingSource
    Friend WithEvents Place_Order_TableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Place_Order_TableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents unit_price As DataGridViewTextBoxColumn
    Friend WithEvents total_price As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents item_name As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents deletTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ElectronicsShopManagementSystemDataSet3 As ElectronicsShopManagementSystemDataSet3
    Friend WithEvents Place_Order_TableBindingSource1 As BindingSource
    Friend WithEvents Place_Order_TableTableAdapter As ElectronicsShopManagementSystemDataSet3TableAdapters.Place_Order_TableTableAdapter
    Friend WithEvents TableAdapterManager As ElectronicsShopManagementSystemDataSet3TableAdapters.TableAdapterManager
    Friend WithEvents Place_Order_TableDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
End Class
