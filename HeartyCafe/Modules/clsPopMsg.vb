Public Class clsPopMsg

    Protected Friend Sub savedSuccess(ByVal itemSaved As String)
        MessageBox.Show(String.Format("New {0} has been saved successfully!", itemSaved), "Save Success")
    End Sub

    Protected Friend Sub updateSuccess(ByVal itemSaved As String)
        MessageBox.Show(String.Format("{0} has been updated successfully!", itemSaved), "Update Success")
    End Sub

End Class
