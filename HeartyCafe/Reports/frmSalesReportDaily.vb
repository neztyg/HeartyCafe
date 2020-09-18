Public Class frmSalesReportDaily

    Private Sub loadTransacsByDate(ByVal dateVal As Date)
        SQLstr = String.Format("SELECT TransacID, Category, ProductName, SizeDesc, Price AS UnitPrice, Qty, Price*Qty AS SubTotal " + _
                       "FROM viewTransactions WHERE CONVERT(date,TransacDate) = CONVERT(date, '{0}')", dateVal)

        sqlQueryCMD(SQLstr)

        Dim salesTotal As Decimal = 0.0
        Dim itemx As New ListViewItem

        lvTransacSummary.Items.Clear()
        Do While rdDB.Read
            itemx = lvTransacSummary.Items.Add(rdDB!Category)
            itemx.SubItems.Add(rdDB!ProductName)
            itemx.SubItems.Add(rdDB!SizeDesc)
            itemx.SubItems.Add(rdDB!Qty)
            itemx.SubItems.Add(rdDB!UnitPrice)
            itemx.SubItems.Add(rdDB!SubTotal)

            salesTotal += rdDB!SubTotal
        Loop
        closeDBAll()

        lblTotalSales.Text = String.Format("Php {0:n}", salesTotal)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        If lvTransacSummary.Items.Count < 1 Then
            MessageBox.Show("Seems that there are no transactions today", "Print function unavailable!")
            Exit Sub
        End If

        Dim crDailySales As New crDailySales
        Dim crSubTotalSales As New crTotalSalesDaily
        Dim crQtyCounter As New crQtyCounterBYsize

        Dim ReportViewer As New frmReportViewer

        crDailySales.Refresh()
        crSubTotalSales.Refresh()
        crQtyCounter.Refresh()

        crDailySales.SetParameterValue(0, dtpTransacDate.Value)
        crDailySales.SetParameterValue(1, frmSales.lblUser.Text.ToUpper)
        crDailySales.SetParameterValue(2, dtpTransacDate.Value)
        crDailySales.SetParameterValue(3, dtpTransacDate.Value)

        ReportViewer.rptViewer.ReportSource = crDailySales
        ReportViewer.ShowDialog()
    End Sub

    Private Sub dtpTransacDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTransacDate.ValueChanged
        Try
            loadTransacsByDate(dtpTransacDate.Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmSalesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            loadTransacsByDate(dtpTransacDate.Value)
        Catch ex As Exception

        End Try
    End Sub
End Class