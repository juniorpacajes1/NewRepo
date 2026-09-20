<%@ Page Title="Listado de clientes naturales" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmListadoClientes.aspx.cs" Inherits="PresentacionWeb.FrmListadoClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Listado de clientes naturales</h2>
    <asp:Button ID="btnImprimir" runat="server" Text="Imprimir" OnClientClick="window.print(); return false;" />
    <br /><br />
    <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="false" CssClass="table table-striped">
        <Columns>
            <asp:BoundField DataField="idcliente" HeaderText="Código" />
            <asp:BoundField DataField="NombreCliente" HeaderText="Nombre" />
            <asp:BoundField DataField="DocumentoIdentidad" HeaderText="Documento" />
            <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
            <asp:BoundField DataField="NombreRubro" HeaderText="Rubro" />
            <asp:BoundField DataField="NombreBarrio" HeaderText="Barrio" />
            <asp:HyperLinkField DataNavigateUrlFields="idcliente" DataNavigateUrlFormatString="FrmKardexCliente.aspx?id={0}" Text="Kardex" HeaderText="Kardex" />
        </Columns>
    </asp:GridView>
</asp:Content>
