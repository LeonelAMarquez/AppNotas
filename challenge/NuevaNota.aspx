<%@ Page Title="Nueva Nota" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevaNota.aspx.vb" Inherits="challenge.NuevaNota" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-4">
        <h2 class="text-center mb-4">New Note</h2>

        <div class="d-flex align-items-center mb-3">
            <label class="me-2 fw-bold">Select Tag:</label>
            <div class="dropdown">
                <button class="btn btn-secondary dropdown-toggle" type="button" data-bs-toggle="dropdown" aria-expanded="false" id="btnTagSeleccionado" runat="server">
                    <asp:Label ID="lblTagSeleccionado" runat="server" Text="Tag"></asp:Label>
                </button>
                <ul class="dropdown-menu">
                    <li><asp:LinkButton ID="btnFutbol" runat="server" CssClass="dropdown-item" CommandArgument="1">Football</asp:LinkButton></li>
                    <li><asp:LinkButton ID="btnFacultad" runat="server" CssClass="dropdown-item" CommandArgument="2">University</asp:LinkButton></li>
                    <li><asp:LinkButton ID="btnFamilia" runat="server" CssClass="dropdown-item" CommandArgument="3">Family</asp:LinkButton></li>
                </ul>
            </div>
        </div>

        <div class="mb-3">
            <label for="txtContenido" class="form-label fw-bold">Content:</label>
            <asp:TextBox ID="txtContenido" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="10" Placeholder="Write your note here..." Style="width: 90%; height: 300px; resize: none;"></asp:TextBox>
        </div>

        <div class="text-center mt-3">
            <a href="MenuPrincipal.aspx" class="btn btn-danger me-2">Return</a>
            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-success" Text="Save" />
        </div>
    </div>
</asp:Content>

