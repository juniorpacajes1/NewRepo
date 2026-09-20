<%@ Page Title="Kardex de cliente" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmKardexCliente.aspx.cs" Inherits="PresentacionWeb.FrmKardexCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Kardex de cliente</h2>
    <asp:Panel ID="pnlCliente" runat="server">
        <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
    </asp:Panel>
    <br />
    <asp:GridView ID="gvKardex" runat="server" AutoGenerateColumns="true"></asp:GridView>
</asp:Content>
