Public Class frmSalesReportMonthly
    Dim monthID As Integer = 0


    Private Sub populateYear()
        SQLstr = String.Format("SELECT DISTINCT YEAR(TransacDate) AS TransacYear FROM viewTransactions")
        sqlQueryCMD(SQLstr)

        cbYear.Items.Clear()
        Do While rdDB.Read
            cbYear.Items.Add(rdDB!TransacYear)
        Loop
        closeDBAll()
        If cbYear.Items.Count > 0 Then
            cbYear.SelectedIndex = 0
        End If
        cbMonth.SelectedIndex = Now.Month - 1
    End Sub

    Private Sub loadDailyTotalSales(ByVal mnt As Integer, ByVal yr As Integer)
        SQLstr = String.Format("SELECT DISTINCT TransacDate, SUM(SubTotal) AS SubTotal FROM viewTransactions " + _
                               "WHERE MONTH(TransacDate) = {0} AND YEAR(TransacDate) = {1} " + _
                               "GROUP By TransacDate", mnt, yr)
        sqlQueryCMD(SQLstr)
        lvTransacSummary.Items.Clear()
        Dim itemx As New ListViewItem
        Dim gTotal As Decimal = 0.0


        Do While rdDB.Read
            itemx = lvTransacSummary.Items.Add(CDate(rdDB!TransacDate).ToString("MMM dd, yyyy"))
            If Not IsDBNull(rdDB!SubTotal) Then
                itemx.SubItems.Add(rdDB!SubTotal)
                gTotal += rdDB!SubTotal
            Else
                itemx.SubItems.Add("")
            End If
        Loop
        closeDBAll()

        lblTotalSales.Text = String.Format("Php {0:n}", gTotal)
    End Sub

    Private Sub frmSalesReportMonthly_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            populateYear()
            loadDailyTotalSales(cbMonth.SelectedIndex + 1, cbYear.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMonth.SelectedIndexChanged
        loadDailyTotalSales(cbMonth.SelectedIndex + 1, cbYear.Text)
    End Sub

    Private Sub cbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbYear.SelectedIndexChanged
        loadDailyTotalSales(cbMonth.SelectedIndex + 1, cbYear.Text)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If lvTransacSummary.Items.Count < 1 Then
            MessageBox.Show("Seems that there are no transactions today", "Print function unavailable!")
            Exit Sub
        End If

        Dim crMonthlySales As New crMonthlySales

        Dim ReportViewer As New frmReportViewer

        crMonthlySales.Refresh()
        crMonthlySales.SetParameterValue(0, cbMonth.SelectedIndex + 1)
        crMonthlySales.SetParameterValue(1, cbYear.Text)
        crMonthlySales.SetParameterValue(2, frmSales.lblUser.Text)
        ReportViewer.rptViewer.ReportSource = crMonthlySales
        ReportViewer.ShowDialog()
    End Sub
End Class