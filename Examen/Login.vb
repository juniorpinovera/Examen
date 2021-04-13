Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If txtUser.Text = "admin" And txtPass.Text = "admin" Then
            Principal.Show()
            Me.Hide()

            txtUser.Text = ""
            txtPass.Text = ""
            txtUser.Select()

        End If


    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged
        btnAceptar.PerformClick()
    End Sub
End Class