Public Class frmNewOrder

    Private Sub loadCategories()
        SQLstr = String.Format("SELECT Category FROM Category")
        sqlQueryCMD(SQLstr)

        cbCategory.Items.Clear()
        Do While rdDB.Read
            cbCategory.Items.Add(rdDB!Category)
        Loop
        closeDBAll()
        cbCategory.SelectedIndex = 0
    End Sub

    Private Sub loadProducts(ByVal categID As Integer)
        SQLstr = String.Format("SELECT ProductID, ProductName, ProdDesc FROM Product WHERE CategID = {0}", categID)
        sqlQueryCMD(SQLstr)

        lvProducts.Items.Clear()
        Dim itemx As New ListViewItem
        Do While rdDB.Read
            itemx = lvProducts.Items.Add(rdDB!ProductID)
            itemx.SubItems.Add(rdDB!ProductName)
            itemx.SubItems.Add(rdDB!ProdDesc)
        Loop
        closeDBAll()
    End Sub

    Function GetCategoryID(ByVal categName As String) As Integer
        Dim categID As Integer = 0
        SQLstr = String.Format("SELECT CategID FROM Category WHERE Category = '{0}'", categName)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            GetCategoryID = rdDB!CategID
        Else
            GetCategoryID = 0
        End If
        closeDBAll()
        Return GetCategoryID
    End Function

    Private Sub loadSizes()
        SQLstr = String.Format("SELECT SizeDesc FROM viewProductList WHERE ProductID = {0}", productID)
        sqlQueryCMD(SQLstr)
        cbSizes.Items.Clear()
        Do While rdDB.Read
            cbSizes.Items.Add(rdDB!SizeDesc)
        Loop
        closeDBAll()
    End Sub

    Private Sub getProductDetails(ByVal prodID As Integer)
        SQLstr = String.Format("SELECT Product.ProductName, Product.ProdDesc, Category.Category FROM Product INNER JOIN Category ON Product.CategID = Category.CategID WHERE Product.ProductID = {0}", prodID)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows() Then
            rdDB.Read()
            productID = prodID
            lblCategory.Text = String.Format("PRODUCT: {0}", rdDB!Category)
            lblProduct.Text = rdDB!ProductName
            lblProductDesc.Text = rdDB!ProdDesc
        End If
        closeDBAll()
    End Sub

    Private Sub getProductPrice()
        SQLstr = String.Format("SELECT ProdSpecID, Price FROM viewProductList WHERE ProductName = '{0}' AND SizeDesc = '{1}'", lblProduct.Text, cbSizes.Text)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            prodBasePrice = rdDB!Price
            lblPrice.Text = prodBasePrice
        End If
        closeDBAll()
        lblPrice.Text = Val(prodBasePrice) * Val(nudQty.Value)
    End Sub

    Private Sub getProdPriceNOsize(ByVal prodID As Integer)
        SQLstr = String.Format("SELECT ProdSpecID, Price FROM viewProductList WHERE ProductName = '{0}' AND SizeDesc = '{1}'", lblProduct.Text, cbSizes.Text)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            prodBasePrice = rdDB!Price
            lblPrice.Text = prodBasePrice
        End If
        closeDBAll()
        lblPrice.Text = Val(prodBasePrice) * Val(nudQty.Value)
    End Sub

    Private Sub loadBestSeller()

    End Sub

    Sub clearSelectionDetails()
        productID = 0

        lblProduct.Text = ""
        lblPrice.Text = ""
        lblProductDesc.Text = ""
        cbSizes.Items.Clear()
        cbSizes.Text = ""
        nudQty.Value = 1
        rbDineIn.Checked = True
    End Sub

    Function sizeID(ByVal sizeDesc As ComboBox) As Integer
        SQLstr = String.Format("SELECT SizeID FROM Size WHERE SizeDesc = '{0}'", sizeDesc.Text)
        sqlQueryCMD(SQLstr)
        Dim sz As Integer = 0
        If rdDB.HasRows Then
            rdDB.Read()
            sz = rdDB!SizeID
        End If
        closeDBAll()
        Return sz
    End Function

    Sub getprodSpecID()
        Dim size As Integer = sizeID(cbSizes)

        SQLstr = String.Format("SELECT ProdSpecID FROM ProductSpec WHERE ProductID = {0} AND SizeID = {1}", productID, size)
        sqlQueryCMD(SQLstr)
        If rdDB.HasRows Then
            rdDB.Read()
            prodSpecID = rdDB!ProdSpecID
        Else
            prodSpecID = 0
        End If
        closeDBAll()
    End Sub


    Dim clientName As String = "Customer"
    Dim transacDate As String
    Dim transacNum As String


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
        frmSales.txtAmountPaid.Focus()
    End Sub


    Protected Friend Sub frmProductList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        transacDate = frmSales.transacNum().ToString.Substring(0, 6)
        transacNum = frmSales.transacNum().ToString.Substring(6, 3)

        'lblTransacNum.Text = transacNum
        loadCategories()

        clientName += String.Format(" {0}", CInt(lblTransacNum.Text))
        txtCustomer.Text = clientName '+ String.Format(" {0}", CInt(lblTransacNum.Text))
        'If frmSales.lblClient.Text <> "" Then
        '    txtCustomer.Text = clientName + String.Format(" {0}", CInt(lblTransacNum.Text))
        'End If
    End Sub

    Private Sub cbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCategory.SelectedIndexChanged
        categoryID = GetCategoryID(cbCategory.Text)
        loadProducts(categoryID)
    End Sub

    Private Sub lvProducts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvProducts.SelectedIndexChanged
        If lvProducts.SelectedItems.Count = 1 Then
            getProductDetails(lvProducts.SelectedItems(0).SubItems(0).Text)
            loadSizes()
            If cbSizes.Items.Count > 0 Then
                cbSizes.SelectedIndex = 0
            Else
                cbSizes.Text = ""
                lblPrice.Text = ""
                nudQty.Value = 1
            End If
        End If
    End Sub


    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Dim msgDial = MsgBox(String.Format("Order: {0}" + vbCrLf + "Qty: {1}", lvProducts.SelectedItems(0).SubItems(1).Text, nudQty.Value), MsgBoxStyle.YesNo, "CONFIRM ORDER!?")

        If msgDial = MsgBoxResult.No Then
            MessageBox.Show("Order cancelled!", "Cancelled!")
            Exit Sub
        End If

        SQLstr = String.Format("INSERT INTO Transactions(ProdSpecID, TransacNum, TransacDate, Qty, " + _
                                                        "isDinein, isServed, isPaid, SoldTo, SubTotal) " + _
                                            "VALUES({0}, {1}, '{2}', {3}, '{4}', 0, 0, '{5}', {6})", _
                                                    prodSpecID, transacDate & lblTransacNum.Text, Now, nudQty.Value, rbDineIn.Checked, txtCustomer.Text, lblPrice.Text)
        sqlNonQueryCMD(SQLstr)
        'frmSales.loadUnservedOrders()

        'SQLstr = String.Format("INSERT INTO Order(TransacID, Qty")

        Dim msg = MsgBox("Order has been saved," + vbCr + "Do you want to add another order for the same client?", MsgBoxStyle.YesNo, "Order saved!")
        If msg = MsgBoxResult.Yes Then
            frmSales.loadUnservedOrders()
            frmSales.loadClientOrders(transacDate & lblTransacNum.Text, txtCustomer.Text)
            clearSelectionDetails()
        Else
            frmSales.loadUnservedOrders()
            frmSales.loadClientOrders(transacDate & lblTransacNum.Text, txtCustomer.Text)
            btnClose_Click(sender, e)
        End If
    End Sub

    Private Sub cbSizes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSizes.SelectedIndexChanged
        getProductPrice()
        getprodSpecID()
    End Sub

    Dim prodBasePrice As Double = 0.0

    Private Sub nudQty_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudQty.ValueChanged
        lblPrice.Text = Val(prodBasePrice) * Val(nudQty.Value)
    End Sub

    Private Sub txtCustomer_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCustomer.MouseClick
        txtCustomer.SelectAll()
    End Sub

End Class