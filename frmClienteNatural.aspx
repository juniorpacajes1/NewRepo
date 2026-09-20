<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmClienteNatural.aspx.cs" Inherits="PresentacionWeb.frmClienteNatural" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td style="width: 344px">
                <asp:Label ID="Label12" runat="server" Text="Registro de cliente naturales"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 344px">
                <asp:Label ID="Label1" runat="server" Text="Codigo de cliente"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbid" runat="server" BackColor="#CCCCCC" Enabled="False">Autonumerico</asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 344px">
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbNombreCliente" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 344px">
                <asp:Label ID="Label3" runat="server" Text="Apellido paterno"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbApellidoPaterno" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 344px">
                <asp:Label ID="Label4" runat="server" Text="Apellido materno"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbApellidoMaterno" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 344px">
                <asp:Label ID="Label13" runat="server" Text="Genero"></asp:Label>
            </td>
            <td>
                <asp:RadioButton ID="rbFemenino" runat="server" Text="Femenino" />
                <asp:RadioButton ID="rbMasculino" runat="server" Text="Masculino" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 344px">
                <asp:Label ID="Label5" runat="server" Text="Documento de identidad"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbDocumentoIdentidad" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Height="27px" Width="49px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 344px">
                <asp:Label ID="Label6" runat="server" Text="Fecha de nacimiento"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbFechaNacimiento" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 344px">
                <asp:Label ID="Label7" runat="server" Text="Direccion"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbDireccion" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 344px">
                <asp:Label ID="Label8" runat="server" Text="Telefono"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbTelefono" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 344px">
                <asp:Label ID="Label9" runat="server" Text="Nit"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbNit" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 344px">
                <asp:Label ID="Label10" runat="server" Text="Rubro"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="cbRubro" runat="server" Width="357px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 344px">
                <asp:Label ID="Label11" runat="server" Text="Zona/Barrio"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="cbBarrio" runat="server" Width="356px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 344px">
                <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
