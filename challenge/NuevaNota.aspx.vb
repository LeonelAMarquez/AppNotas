Imports dominio
Imports negocio

Public Class NuevaNota
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ViewState("TagId") = 0
        End If
    End Sub

    Protected Sub btnFutbol_Click(sender As Object, e As EventArgs) Handles btnFutbol.Click, btnFacultad.Click, btnFamilia.Click
        Dim boton As LinkButton = CType(sender, LinkButton)
        ViewState("TagId") = Convert.ToInt32(boton.CommandArgument)
        lblTagSeleccionado.Text = boton.Text
    End Sub

    Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Convert.ToInt32(ViewState("TagId")) = 0 Then
            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Por favor seleccioná un tag antes de guardar.');", True)
            Exit Sub
        End If

        Dim nuevaNota As New Note()
        nuevaNota.TagId = Convert.ToInt32(ViewState("TagId"))
        nuevaNota.Contenido = txtContenido.Text
        nuevaNota.Titulo = ""
        nuevaNota.UserId = 1

        Dim negocioNotas As New NoteNegocio()
        negocioNotas.agregar(nuevaNota)

        Response.Redirect("MenuPrincipal.aspx")
    End Sub
End Class

