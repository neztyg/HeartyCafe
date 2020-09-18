Public Class frmLogin

    Private Sub btnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click
        If txtUser.TextLength = 0 Or txtPass.TextLength = 0 Then
            MessageBox.Show("Please enter username and password to continue!", "Invalid entry!")
            Exit Sub
        End If

        SQLstr = String.Format("SELECT AccountID, Name " + _
                               "FROM Account WHERE Username = '{0}' AND Password = '{1}' AND userType = 0", txtUser.Text, txtPass.Text)

        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            MessageBox.Show(String.Format("Hi, {0}!" + vbCr + "You can now use the system.", rdDB!Name))
            frmSales.lblUser.Text = rdDB!Name

            closeDBAll()
            frmSales.Show()
            Me.Close()
        Else
            MessageBox.Show("The username and password is not recognized!" + vbCr + "Please try again!")
        End If
        closeDBAll()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Dim msg = MsgBox("Are you sure to exit the program?", MsgBoxStyle.YesNo, "EXIT PROGRAM")
        If msg = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class