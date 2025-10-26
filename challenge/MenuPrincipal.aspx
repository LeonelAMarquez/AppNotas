<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.vb" Inherits="challenge.MenuPrincipal" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-4">
        <h2 class="text-center mb-4">My Notes</h2>

        <div class="d-flex justify-content-between align-items-center mb-3">
            <div class="d-flex align-items-center">
                <label class="me-2 fw-bold">Filter by:</label>
                <div class="dropdown">
                    <button class="btn btn-secondary dropdown-toggle" type="button" data-bs-toggle="dropdown" aria-expanded="false">
                        Tags
                    </button>
                    <ul class="dropdown-menu">
                        <li><asp:LinkButton ID="btnFutbol" runat="server" CssClass="dropdown-item" CommandArgument="1" OnClick="FiltrarNotas_Click">Football</asp:LinkButton></li>
                        <li><asp:LinkButton ID="btnFacultad" runat="server" CssClass="dropdown-item" CommandArgument="2" OnClick="FiltrarNotas_Click">University</asp:LinkButton></li>
                        <li><asp:LinkButton ID="btnFamilia" runat="server" CssClass="dropdown-item" CommandArgument="3" OnClick="FiltrarNotas_Click">Family</asp:LinkButton></li>
                        <li><asp:LinkButton ID="btnTodos" runat="server" CssClass="dropdown-item" CommandArgument="0" OnClick="FiltrarNotas_Click">All</asp:LinkButton></li>
                    </ul>
                </div>

            </div>
            <a href="NuevaNota.aspx" type="button" class="btn btn-success">New</a>
        </div>

        <asp:GridView ID="dgvNotes" runat="server" CssClass="table table-bordered table-hover text-center" AutoGenerateColumns="False">
            <Columns>
               
                <asp:BoundField DataField="Contenido" HeaderText="Content" />
                <asp:BoundField DataField="TagNombre" HeaderText="Tag" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

