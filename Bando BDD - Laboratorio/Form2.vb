Public Class Form2
    Public signo, condition As String
    Public confirm As Boolean

    Private Sub bttnConfirm_Click(sender As Object, e As EventArgs) Handles bttnConfirm.Click
        If txt.Text.Trim = String.Empty Then
            MsgBox("Error. Cannot leave blank spaces.", vbOK)
        Else
            signo = If(RbttnSuma.Checked, "+", "-")
            condition = If(RbttnSelected.Checked, "WHERE idClient =" + Form1.TBoxidClient.Text, "")
            confirm = True

            Form1.adjust()
            Form1.Enabled = True
            Me.Hide()
        End If
    End Sub

    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        confirm = False

        Form1.Enabled = True
        Me.Hide()
    End Sub
End Class