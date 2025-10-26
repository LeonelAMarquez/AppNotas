Imports dominio
Imports negocio

Public Class NuevaNota
    Inherits System.Web.UI.Page

    Dim negocioNotas As New NoteNegocio()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ViewState("TagId") = 0

            If Request.QueryString("id") IsNot Nothing Then
                Dim id As Integer = Convert.ToInt32(Request.QueryString("id"))
                CargarNota(id)
            End If

        End If
    End Sub

    Private Sub CargarNota(id As Integer)
        Dim nota As Note = negocioNotas.obtenerPorId(id)

        If nota IsNot Nothing Then
            txtContenido.Text = nota.Contenido
            ViewState("TagId") = nota.TagId
            ViewState("NotaId") = nota.Id

            Select Case nota.TagId
                Case 1
                    lblTagSeleccionado.Text = "Fútbol"
                Case 2
                    lblTagSeleccionado.Text = "Facultad"
                Case 3
                    lblTagSeleccionado.Text = "Familia"
            End Select

            ViewState("NotaId") = nota.Id
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

        If ViewState("NotaId") IsNot Nothing Then
            nuevaNota.Id = Convert.ToInt32(ViewState("NotaId"))
            negocioNotas.actualizar(nuevaNota)
        Else
            negocioNotas.agregar(nuevaNota)
        End If

        Response.Redirect("MenuPrincipal.aspx")
    End Sub
End Class

