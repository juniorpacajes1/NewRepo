<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmRubro.aspx.cs" Inherits="PresentacionWeb.frmRubro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="width: 200px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 200px">
                <asp:Label ID="Label1" runat="server" Text="Rubro"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbNombreRubro" runat="server" Width="268px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 200px">
                <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
            </td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 200px">
                <asp:Label ID="Label3" runat="server" Text="Buscar"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbBuscar" runat="server"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 200px">
                &nbsp;</td>
            <td>
                <asp:GridView ID="dgwRubro" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 200px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
