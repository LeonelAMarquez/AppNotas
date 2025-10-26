Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If email = "test@mail.com" AndAlso password = "pass1234" Then
            Session("Usuario") = email
            Response.Redirect("MenuPrincipal.aspx")
        Else
            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Incorrect email or password');", True)
        End If
    End Sub
End Class