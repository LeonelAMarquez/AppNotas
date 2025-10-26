<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="challenge._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container mt-5" style="max-width:400px;">
        <h2 class="text-center mb-4">Login</h2>

        <div class="mb-3">
            <label for="txtEmail" class="form-label">Email address</label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Write your Email..."></asp:TextBox>
        </div>

        <div class="mb-3">
            <label for="txtPassword" class="form-label">Password</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Write your Password..."></asp:TextBox>
        </div>
        <div class="text-center">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary w-100" />
        </div>
    </div>
</asp:Content>
