Public Class frmAdminAuth
    Private Function AuthAdmin() As Boolean
        SQLstr = String.Format("SELECT AccountID, Name " + _
                               "FROM Account WHERE Password = '{0}' AND userType = 1", txtPass.Text)
        Dim val As Boolean = False
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            closeDBAll()
            Return True
        Else
            closeDBAll()
            Return False
        End If
    End Function

    Dim errCount As Integer = 3
    Private Sub btnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click
        If AuthAdmin() Then
            frmSales.cancelOrder(frmSales.lvCustomerOrder.SelectedItems(0).SubItems(0).Text)
            MessageBox.Show("Order will be removed permanently" + vbCr + "Do you confirm?", "DELETE ORDER")
            frmSales.loadClientOrders("123456" + frmSales.lblOrderNum.Text, frmSales.lblClient.Text)
            frmSales.loadUnservedOrders()
            txtPass.Clear()
            Me.Close()
        Else
            If errCount = 0 Then
                MessageBox.Show("Password is not ADMIN and have no authority on this function!", "Restricted Access!")
                txtPass.Clear()
                Me.Close()
            Else
                MessageBox.Show(String.Format("You only have {0} retry left.", errCount))
                errCount -= 1
                txtPass.Clear()
                txtPass.Focus()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim msg = MsgBox("Are you sure to exit the program?", MsgBoxStyle.YesNo, "EXIT PROGRAM")
        If msg = MsgBoxResult.Yes Then
            frmSales.Close()
            Me.Close()
        Else
            Me.Hide()
            frmSales.frmSales_Load(sender, e)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class