Imports negocio
Imports dominio
Imports System.Web.UI.WebControls

Public Class MenuPrincipal
    Inherits System.Web.UI.Page

    Dim negocioNotas As New NoteNegocio()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarNotas()
        End If
    End Sub

    Private Sub CargarNotas(Optional ByVal tagId As Integer = 0)
        Dim lista = negocioNotas.listarConSP()

        If tagId <> 0 Then
            lista = lista.Where(Function(n) n.TagId = tagId).ToList()
        End If

        dgvNotes.DataSource = lista
        dgvNotes.DataBind()
    End Sub

    Protected Sub FiltrarNotas_Click(sender As Object, e As EventArgs)
        Dim btn As LinkButton = CType(sender, LinkButton)
        Dim tagId As Integer = Convert.ToInt32(btn.CommandArgument)
        CargarNotas(tagId)
    End Sub

    Protected Sub btnDelete_Click(sender As Object, e As EventArgs)
        For Each row As GridViewRow In dgvNotes.Rows
            Dim chk As CheckBox = CType(row.FindControl("chkSelect"), CheckBox)
            Dim hdnId As HiddenField = CType(row.FindControl("hdnId"), HiddenField)

            If chk IsNot Nothing AndAlso chk.Checked Then
                Dim id As Integer = Convert.ToInt32(hdnId.Value)
                negocioNotas.eliminar(id)
            End If
        Next

        CargarNotas()
    End Sub

    Protected Sub btnEdit_Click(sender As Object, e As EventArgs)
        For Each row As GridViewRow In dgvNotes.Rows
            Dim chk As CheckBox = CType(row.FindControl("chkSelect"), CheckBox)
            Dim hdnId As HiddenField = CType(row.FindControl("hdnId"), HiddenField)

            If chk IsNot Nothing AndAlso chk.Checked Then
                Dim id As Integer = Convert.ToInt32(hdnId.Value)
                Response.Redirect("NuevaNota.aspx?id=" & id)
            End If
        Next
    End Sub

End Class