Public Class clsPrintReport

    Protected Friend Sub printDailySales(ByVal lvContainer As System.Windows.Forms.ListView)
        Dim report As New crDailySales
        Dim viewer As New frmReportViewer
        Dim fields As New rptVariables
        Dim itemx As New ArrayList

        report = New crDailySales

        For x As Integer = 0 To lvContainer.Items.Count - 1 Step 1
            'Dim itemx As ArrayList =
            'fields = New rptVariables
            'With fields
            '    .CategDesc = itemx.SubItems(0).Text
            '    .ProductName = itemx.SubItems(1).Text
            '    .SizeDesc = itemx.SubItems()
            'End With

        Next

        report.Refresh()

        viewer.rptViewer.ReportSource = report
        viewer.ShowDialog()
    End Sub
End Class
