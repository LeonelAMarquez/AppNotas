Imports dominio
Imports negocio

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        Dim userNegocio As New UserNegocio()
        Dim usuario As User = userNegocio.Login(email, password)

        If usuario IsNot Nothing Then
            Session("Usuario") = usuario
            Response.Redirect("MenuPrincipal.aspx")
        Else
            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Incorrect email or password');", True)
        End If
    End Sub
End Class
