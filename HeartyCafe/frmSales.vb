Public Class frmSales
    Dim WithEvents timer1 As New Windows.Forms.Timer

    Protected Friend Sub loadUnservedOrders()
        SQLstr = String.Format("SELECT TransacID, Category, ProductName, SizeDesc, TransacNum, TransacDate, Qty," + _
                         "isDinein, isServed, isPaid, SoldTo, Remarks FROM viewTransactions " + _
                 "WHERE CONVERT(date, TransacDate) = CONVERT(date, '{0}') AND isServed = 0", Now.ToShortDateString)
        sqlQueryCMD(SQLstr)

        Dim itemx As New ListViewItem
        lvOrders.Items.Clear()
        Do While rdDB.Read
            itemx = lvOrders.Items.Add(rdDB!TransacID)
            itemx.SubItems.Add(rdDB!TransacNum.ToString.Substring(6, 3))
            itemx.SubItems.Add(rdDB!ProductName)
            itemx.SubItems.Add(rdDB!SizeDesc)
            itemx.SubItems.Add(rdDB!Qty)
            If rdDB!isDinein = True Then
                itemx.SubItems.Add("Dine In")
            Else
                itemx.SubItems.Add("Take out")
            End If
            itemx.SubItems.Add(rdDB!SoldTo)
            If rdDB!isPaid = True Then
                itemx.BackColor = Color.LightGreen
            End If

        Loop
        closeDBAll()
    End Sub


    Private Sub serveOrder(ByVal transacID As Integer)
        SQLstr = String.Format("UPDATE Transactions SET isServed = 1 WHERE TransacID = {0}", transacID)
        sqlNonQueryCMD(SQLstr)
        loadServedOrders()
    End Sub
    Protected Friend Sub loadServedOrders()
        SQLstr = String.Format("SELECT TransacID, Category, ProductName, SizeDesc, TransacNum, TransacDate, Qty," + _
                         "isDinein, isServed, isPaid, SoldTo, Remarks FROM viewTransactions " + _
                 "WHERE CONVERT(date, TransacDate) = CONVERT(date, '{0}') AND isServed = 1", Now.ToShortDateString)
        sqlQueryCMD(SQLstr)

        Dim itemx As New ListViewItem
        lvServed.Items.Clear()
        Do While rdDB.Read
            itemx = lvServed.Items.Add(rdDB!TransacID)
            itemx.SubItems.Add(rdDB!TransacNum.ToString.Substring(6, 3))
            itemx.SubItems.Add(rdDB!ProductName)
            itemx.SubItems.Add(rdDB!SizeDesc)
            itemx.SubItems.Add(rdDB!Qty)
            If rdDB!isDinein = True Then
                itemx.SubItems.Add("Dine In")
            Else
                itemx.SubItems.Add("Take out")
            End If
            itemx.SubItems.Add(rdDB!SoldTo)
            If rdDB!isPaid = True Then
                itemx.BackColor = Color.LightGreen
            End If
        Loop
        closeDBAll()
    End Sub



    Protected Friend Sub loadClientOrders(ByVal transNum, ByVal client)
        'MessageBox.Show(transNum)
        SQLstr = String.Format("SELECT TransacID, TransacNum, SoldTo, Category, ProductName, SizeDesc, TransacNum, TransacDate, Qty," + _
                                      "Price, isDinein, isServed, isPaid, SoldTo, Remarks FROM viewTransactions " + _
                               "WHERE TransacNum = {0} AND " + _
                                     "SoldTo = '{1}' ", _
                                        transNum,
                                        client)
        sqlQueryCMD(SQLstr)
        'MessageBox.Show(transNum)
        Dim itemx As New ListViewItem
        Dim SubTotal As Double = 0.0
        Dim TotalDue As Double = 0.0
        lvCustomerOrder.Items.Clear()
        Do While rdDB.Read
            itemx = lvCustomerOrder.Items.Add(rdDB!TransacID)
            itemx.SubItems.Add(rdDB!ProductName)
            itemx.SubItems.Add(rdDB!SizeDesc)
            itemx.SubItems.Add(rdDB!Qty)
            If rdDB!isDinein = True Then
                itemx.SubItems.Add("Dine In")
            Else
                itemx.SubItems.Add("Take out")
            End If
            itemx.SubItems.Add(rdDB!Price)

            If rdDB!isPaid = True Then
                itemx.BackColor = Color.LightGreen
            End If

            If rdDB!isPaid = False Then
                SubTotal = Val(rdDB!Qty) * Val(rdDB!Price)
                itemx.SubItems.Add(SubTotal)
                TotalDue += SubTotal
            End If
        Loop
        lblOrderNum.Text = transNum.ToString.Substring(6, 3)
        lblClient.Text = client
        txtTotalDue.Text = TotalDue
        closeDBAll()
    End Sub

    Protected Friend Function transacNum() As Integer
        SQLstr = String.Format("SELECT TOP(1) Substring(Str(TransacNum), 8, 3) AS lstOrder FROM Transactions WHERE CONVERT(date, TransacDate) = CONVERT(date,'{0}') ORDER BY TransacNum DESC", Now.ToShortDateString)
        sqlQueryCMD(SQLstr)
        Dim cnt As String = ""
        If rdDB.HasRows Then
            rdDB.Read()
            cnt = CStr(Val(rdDB!lstOrder) + 1)
        Else
            cnt = 1
        End If
        closeDBAll()
        'If cnt = 0 Then
        '    cnt = 1
        'End If
        Dim yr As String = Now.Year.ToString.Substring(Len(Now.Year) / 2, 2)
        Dim mot As String = Now.Month.ToString
        If mot.Length = 1 Then
            mot = "0" + mot
        End If
        Dim day As String = Now.Day.ToString
        If day.Length = 1 Then
            day = "0" + day
        End If
        If cnt.ToString.Length = 1 Then
            cnt = "00" + cnt
        ElseIf cnt.ToString.Length = 2 Then
            cnt = "0" + cnt
        End If

        cnt = String.Format("{0}{1}{2}{3}", yr, mot, day, cnt)

        Return cnt
    End Function


    Protected Friend Sub cancelOrder(ByVal id As Integer)
        SQLstr = String.Format("DELETE FROM Transactions WHERE TransacID = {0}", id)
        sqlNonQueryCMD(SQLstr)
    End Sub

    Protected Friend Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timer1.Start()
        lblDate.Text = Now.ToLongDateString
        loadUnservedOrders()
        loadServedOrders()
    End Sub




    Private Sub timer1_tick() Handles timer1.Tick
        lblTime.Text = Now.ToLongTimeString
        If txtTotalDue.TextLength = 0 Then
            txtAmountPaid.Enabled = False
        Else
            txtAmountPaid.Enabled = True
        End If
        If Math.Floor(Val(txtAmountPaid.Text)) >= Math.Floor(Val(txtTotalDue.Text)) Then
            btnCheckout.Enabled = True
        Else
            btnCheckout.Enabled = False
        End If


    End Sub

    Private Sub lvOrders_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvOrders.MouseDoubleClick
        If lvOrders.SelectedItems.Count = 1 Then
            'SQLstr = String.Format("SELECT TransacID, Category, ProductName, SizeDesc, TransacNum, TransacDate, Qty," + _
            '                              "isDinein, isServed, isPaid, SoldTo, Remarks FROM viewTransactions " + _
            '                       "WHERE TransacNum = {0}", transacNum.ToString.Substring(0, 6) & lvOrders.SelectedItems(0).SubItems(0).Text)
            'sqlQueryCMD(SQLstr)

            loadClientOrders(transacNum.ToString.Substring(0, 6) & lvOrders.SelectedItems(0).SubItems(1).Text,
                             lvOrders.SelectedItems(0).SubItems(6).Text)
        End If
    End Sub

    Private Sub btnOrderQueue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrderQueue.Click
        lvCustomerOrder.Items.Clear()
        lblClient.Text = String.Empty
        lblOrderNum.Text = String.Empty

        Dim frmProdList As New frmNewOrder
        frmProdList.lblTransacNum.Text = transacNum().ToString.Substring(6, 3)
        frmProdList.ShowDialog()
        frmProdList.Dispose()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub txtAmountPaid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmountPaid.KeyPress
        NumericTypeOnly(sender, e)
    End Sub

    Private Sub txtAmountPaid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmountPaid.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCheckout_Click(sender, e)
        End If
    End Sub

    Private Sub lvOrders_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvOrders.KeyDown
        If lvOrders.SelectedItems.Count >= 1 Then
            If e.KeyCode = Keys.Enter Then
                MessageBox.Show("Value")
            End If
        End If
    End Sub

    Private Sub btnCheckout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckout.Click
        If lvCustomerOrder.Items.Count > 0 Then
            For x As Integer = 0 To lvCustomerOrder.Items.Count - 1
                SQLstr = String.Format("UPDATE Transactions SET isPaid = 1 WHERE TransacID = {0} AND isPaid = 0", lvCustomerOrder.Items(x).SubItems(0).Text)
                sqlNonQueryCMD(SQLstr)
            Next
            loadServedOrders()
            loadUnservedOrders()
            loadClientOrders(transacNum.ToString.Substring(0, 6) + lblOrderNum.Text, lblClient.Text)

            txtTotalDue.Clear()
            txtAmountPaid.Clear()
            txtChange.Clear()

            MessageBox.Show("The list of items has been paid.")
        End If
    End Sub

    Private Sub lnkAddOrder_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAddOrder.LinkClicked
        If lblClient.Text.Length > 0 And lblOrderNum.Text.Length = 3 Then
            Dim frmNewOrder As New frmNewOrder

            frmNewOrder.lblTransacNum.Text = lblOrderNum.Text
            frmNewOrder.txtCustomer.Text = lblClient.Text
            frmNewOrder.ShowDialog()
        End If
    End Sub

    Private Sub txtAmountPaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountPaid.TextChanged
        If txtTotalDue.Text.Length <> 0 Then
            txtChange.Text = Val(txtAmountPaid.Text) - Val(txtTotalDue.Text)
        End If
    End Sub

    Private Sub lnkClear_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkClear.LinkClicked
        lvCustomerOrder.Items.Clear()
        lblClient.Text = ""
        lblOrderNum.Text = ""
    End Sub

    Private Sub ServedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServedToolStripMenuItem.Click
        If lvOrders.SelectedItems.Count = 1 Then
            SQLstr = String.Format("SELECT isPaid FROM Transactions WHERE TransacID = {0}", lvOrders.SelectedItems(0).SubItems(0).Text)
            sqlQueryCMD(SQLstr)

            If rdDB.HasRows Then
                rdDB.Read()
                If Not rdDB!isPaid Then
                    closeDBAll()
                    MessageBox.Show("Order must be paid before serving", "Pay before serving!")
                    Exit Sub
                Else
                    closeDBAll()
                End If
            End If
            serveOrder(lvOrders.SelectedItems(0).SubItems(0).Text)
            loadUnservedOrders()
        End If
    End Sub

    Private Sub CancelOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelOrderToolStripMenuItem.Click
        If lvCustomerOrder.SelectedItems.Count = 1 Then
            frmAdminAuth.ShowDialog()
        End If
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReportToolStripMenuItem.Click
        Dim dailySales As New frmSalesReportDaily
        frmReportViewer.rptViewer.Zoom(70)
        dailySales.ShowDialog()
    End Sub

    Private Sub MonthlySalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlySalesReportToolStripMenuItem.Click
        Dim monthlySales As New frmSalesReportMonthly
        frmReportViewer.rptViewer.Zoom(70)
        monthlySales.ShowDialog()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub
End Class
