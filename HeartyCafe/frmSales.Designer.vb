<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlySalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lnkClear = New System.Windows.Forms.LinkLabel()
        Me.lnkAddOrder = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblOrderNum = New System.Windows.Forms.Label()
        Me.pnlOrderMenu = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOrderQueue = New System.Windows.Forms.Button()
        Me.lvCustomerOrder = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsOrderOpts = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CancelOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTotalDue = New System.Windows.Forms.TextBox()
        Me.lvOrders = New System.Windows.Forms.ListView()
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsUnserved = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ServedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lvServed = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmsServedOrders = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlOrderMenu.SuspendLayout()
        Me.cmsOrderOpts.SuspendLayout()
        Me.cmsUnserved.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.cmsServedOrders.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumVioletRed
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 124)
        Me.Panel1.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Image = Global.HeartyCafe.My.Resources.Resources.Xmark
        Me.btnClose.Location = New System.Drawing.Point(1313, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(50, 49)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.ForeColor = System.Drawing.Color.Linen
        Me.lblUser.Location = New System.Drawing.Point(412, 79)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(46, 17)
        Me.lblUser.TabIndex = 3
        Me.lblUser.Text = "USER"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblTime.Location = New System.Drawing.Point(410, 25)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(74, 31)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "Time"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblDate.Location = New System.Drawing.Point(410, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 22)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SeaShell
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesReportToolStripMenuItem, Me.ToolStripMenuItem2, Me.MonthlySalesReportToolStripMenuItem, Me.ToolStripMenuItem3, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(407, 100)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(959, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.SalesReportToolStripMenuItem.Text = "Daily Sales Report"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem2.Text = "|"
        '
        'MonthlySalesReportToolStripMenuItem
        '
        Me.MonthlySalesReportToolStripMenuItem.Name = "MonthlySalesReportToolStripMenuItem"
        Me.MonthlySalesReportToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.MonthlySalesReportToolStripMenuItem.Text = "Monthly Sales Report"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.HeartyCafe.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(407, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.lnkClear)
        Me.Panel2.Controls.Add(Me.lnkAddOrder)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblClient)
        Me.Panel2.Controls.Add(Me.lblOrderNum)
        Me.Panel2.Controls.Add(Me.pnlOrderMenu)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnOrderQueue)
        Me.Panel2.Controls.Add(Me.lvCustomerOrder)
        Me.Panel2.Controls.Add(Me.txtTotalDue)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 124)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(481, 625)
        Me.Panel2.TabIndex = 0
        '
        'lnkClear
        '
        Me.lnkClear.AutoSize = True
        Me.lnkClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkClear.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkClear.LinkColor = System.Drawing.Color.DarkGreen
        Me.lnkClear.Location = New System.Drawing.Point(430, 116)
        Me.lnkClear.Name = "lnkClear"
        Me.lnkClear.Size = New System.Drawing.Size(43, 18)
        Me.lnkClear.TabIndex = 8
        Me.lnkClear.TabStop = True
        Me.lnkClear.Text = "Clear"
        '
        'lnkAddOrder
        '
        Me.lnkAddOrder.AutoSize = True
        Me.lnkAddOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkAddOrder.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkAddOrder.LinkColor = System.Drawing.Color.DarkGreen
        Me.lnkAddOrder.Location = New System.Drawing.Point(382, 118)
        Me.lnkAddOrder.Name = "lnkAddOrder"
        Me.lnkAddOrder.Size = New System.Drawing.Size(45, 18)
        Me.lnkAddOrder.TabIndex = 8
        Me.lnkAddOrder.TabStop = True
        Me.lnkAddOrder.Text = "Add..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(230, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "ORDER #:"
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClient.Location = New System.Drawing.Point(137, 118)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(0, 17)
        Me.lblClient.TabIndex = 7
        '
        'lblOrderNum
        '
        Me.lblOrderNum.AutoSize = True
        Me.lblOrderNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNum.Location = New System.Drawing.Point(302, 118)
        Me.lblOrderNum.Name = "lblOrderNum"
        Me.lblOrderNum.Size = New System.Drawing.Size(0, 17)
        Me.lblOrderNum.TabIndex = 7
        '
        'pnlOrderMenu
        '
        Me.pnlOrderMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOrderMenu.BackColor = System.Drawing.Color.SlateGray
        Me.pnlOrderMenu.Controls.Add(Me.Label4)
        Me.pnlOrderMenu.Controls.Add(Me.Label5)
        Me.pnlOrderMenu.Controls.Add(Me.Label3)
        Me.pnlOrderMenu.Controls.Add(Me.txtChange)
        Me.pnlOrderMenu.Controls.Add(Me.txtAmountPaid)
        Me.pnlOrderMenu.Controls.Add(Me.btnCheckout)
        Me.pnlOrderMenu.Location = New System.Drawing.Point(12, 431)
        Me.pnlOrderMenu.Name = "pnlOrderMenu"
        Me.pnlOrderMenu.Size = New System.Drawing.Size(458, 180)
        Me.pnlOrderMenu.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(125, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CHANGE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PAYMENT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(84, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "AMOUNT PAID:"
        '
        'txtChange
        '
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(213, 67)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(233, 38)
        Me.txtChange.TabIndex = 1
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPaid.Location = New System.Drawing.Point(213, 23)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(233, 38)
        Me.txtAmountPaid.TabIndex = 0
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.SeaGreen
        Me.btnCheckout.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCheckout.Location = New System.Drawing.Point(213, 111)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(234, 64)
        Me.btnCheckout.TabIndex = 2
        Me.btnCheckout.Text = "CHECKOUT"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ORDER LIST FOR:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TOTAL DUE:"
        '
        'btnOrderQueue
        '
        Me.btnOrderQueue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderQueue.Location = New System.Drawing.Point(12, 19)
        Me.btnOrderQueue.Name = "btnOrderQueue"
        Me.btnOrderQueue.Size = New System.Drawing.Size(458, 84)
        Me.btnOrderQueue.TabIndex = 0
        Me.btnOrderQueue.Text = "New Order"
        Me.btnOrderQueue.UseVisualStyleBackColor = True
        '
        'lvCustomerOrder
        '
        Me.lvCustomerOrder.CheckBoxes = True
        Me.lvCustomerOrder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader21})
        Me.lvCustomerOrder.ContextMenuStrip = Me.cmsOrderOpts
        Me.lvCustomerOrder.FullRowSelect = True
        Me.lvCustomerOrder.GridLines = True
        Me.lvCustomerOrder.Location = New System.Drawing.Point(12, 138)
        Me.lvCustomerOrder.Name = "lvCustomerOrder"
        Me.lvCustomerOrder.Size = New System.Drawing.Size(458, 219)
        Me.lvCustomerOrder.TabIndex = 1
        Me.lvCustomerOrder.UseCompatibleStateImageBehavior = False
        Me.lvCustomerOrder.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ID"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Item"
        Me.ColumnHeader7.Width = 144
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Size"
        Me.ColumnHeader8.Width = 61
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Quantity"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Dine"
        Me.ColumnHeader10.Width = 59
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Price"
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Subtotal"
        Me.ColumnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader21.Width = 66
        '
        'cmsOrderOpts
        '
        Me.cmsOrderOpts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CancelOrderToolStripMenuItem})
        Me.cmsOrderOpts.Name = "cmsUnserved"
        Me.cmsOrderOpts.Size = New System.Drawing.Size(144, 26)
        '
        'CancelOrderToolStripMenuItem
        '
        Me.CancelOrderToolStripMenuItem.Name = "CancelOrderToolStripMenuItem"
        Me.CancelOrderToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CancelOrderToolStripMenuItem.Text = "Cancel Order"
        '
        'txtTotalDue
        '
        Me.txtTotalDue.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTotalDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDue.Location = New System.Drawing.Point(237, 363)
        Me.txtTotalDue.Name = "txtTotalDue"
        Me.txtTotalDue.ReadOnly = True
        Me.txtTotalDue.Size = New System.Drawing.Size(233, 38)
        Me.txtTotalDue.TabIndex = 1
        Me.txtTotalDue.TabStop = False
        Me.txtTotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lvOrders
        '
        Me.lvOrders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader20, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader17, Me.ColumnHeader14})
        Me.lvOrders.ContextMenuStrip = Me.cmsUnserved
        Me.lvOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvOrders.FullRowSelect = True
        Me.lvOrders.GridLines = True
        Me.lvOrders.Location = New System.Drawing.Point(3, 19)
        Me.lvOrders.Name = "lvOrders"
        Me.lvOrders.Size = New System.Drawing.Size(879, 353)
        Me.lvOrders.TabIndex = 5
        Me.lvOrders.UseCompatibleStateImageBehavior = False
        Me.lvOrders.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "ID"
        Me.ColumnHeader20.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ORDER #"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 105
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ITEM"
        Me.ColumnHeader2.Width = 354
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Size"
        Me.ColumnHeader4.Width = 85
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Qty"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 88
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Dine"
        Me.ColumnHeader17.Width = 90
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Customer"
        Me.ColumnHeader14.Width = 109
        '
        'cmsUnserved
        '
        Me.cmsUnserved.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServedToolStripMenuItem})
        Me.cmsUnserved.Name = "cmsUnserved"
        Me.cmsUnserved.Size = New System.Drawing.Size(113, 26)
        '
        'ServedToolStripMenuItem
        '
        Me.ServedToolStripMenuItem.Name = "ServedToolStripMenuItem"
        Me.ServedToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ServedToolStripMenuItem.Text = "Served!"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvOrders)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(481, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(885, 375)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "UNSERVED ORDERS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lvServed)
        Me.GroupBox2.Location = New System.Drawing.Point(481, 499)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(885, 238)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SERVED ORDERS"
        '
        'lvServed
        '
        Me.lvServed.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader22})
        Me.lvServed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvServed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvServed.FullRowSelect = True
        Me.lvServed.GridLines = True
        Me.lvServed.Location = New System.Drawing.Point(3, 19)
        Me.lvServed.Name = "lvServed"
        Me.lvServed.Size = New System.Drawing.Size(879, 216)
        Me.lvServed.TabIndex = 6
        Me.lvServed.UseCompatibleStateImageBehavior = False
        Me.lvServed.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "ID"
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "ORDER #"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 105
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "ITEM"
        Me.ColumnHeader15.Width = 354
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Size"
        Me.ColumnHeader16.Width = 85
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Qty"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader18.Width = 88
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Dine"
        Me.ColumnHeader19.Width = 90
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Customer"
        Me.ColumnHeader22.Width = 109
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumVioletRed
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(481, 739)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(885, 10)
        Me.Panel3.TabIndex = 0
        '
        'cmsServedOrders
        '
        Me.cmsServedOrders.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.cmsServedOrders.Name = "cmsUnserved"
        Me.cmsServedOrders.Size = New System.Drawing.Size(126, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.ToolStripMenuItem1.Text = "Returned!"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem3.Text = "|"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlOrderMenu.ResumeLayout(False)
        Me.pnlOrderMenu.PerformLayout()
        Me.cmsOrderOpts.ResumeLayout(False)
        Me.cmsUnserved.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.cmsServedOrders.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents pnlOrderMenu As System.Windows.Forms.Panel
    Friend WithEvents btnCheckout As System.Windows.Forms.Button
    Friend WithEvents lvOrders As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOrderQueue As System.Windows.Forms.Button
    Friend WithEvents lvCustomerOrder As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDue As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountPaid As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblClient As System.Windows.Forms.Label
    Friend WithEvents lblOrderNum As System.Windows.Forms.Label
    Friend WithEvents cmsUnserved As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ServedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsOrderOpts As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lnkAddOrder As System.Windows.Forms.LinkLabel
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lnkClear As System.Windows.Forms.LinkLabel
    Friend WithEvents CancelOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvServed As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents cmsServedOrders As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthlySalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
