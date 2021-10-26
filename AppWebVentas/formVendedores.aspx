<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formVendedores.aspx.cs" Inherits="AppWebVentas.formVendedores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 233px;
        }
        .auto-style3 {
            height: 236px;
            width: 342px;
        }
        .auto-style4 {
            width: 154px;
        }
        .auto-style5 {
            width: 88px;
        }
        .auto-style6 {
            width: 79px;
        }
        .auto-style7 {
            width: 79px;
            height: 55px;
        }
        .auto-style8 {
            width: 154px;
            height: 55px;
        }
        .auto-style9 {
            width: 88px;
            height: 55px;
        }
        .auto-style10 {
            height: 55px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        Id</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        Nombre</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">Apellido</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtComision" runat="server" style="margin-right: 0px"></asp:TextBox>
                    </td>
                    <td class="auto-style4">Comision</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6" aria-autocomplete="none">
                        <asp:TextBox ID="txtDni" runat="server" style="margin-right: 0px"></asp:TextBox>
                    </td>
                    <td class="auto-style4">DNI</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Button ID="btnTraerPorComision" runat="server" Height="28px" OnClick="btnTraerPorComision_Click" Text="Traer por Comision" Width="123px" />
                    </td>
                    <td class="auto-style8">
                        <asp:Button ID="btnTraerPorId" runat="server" Height="28px" OnClick="btnTraerPorId_Click" Text="Traer por Id" Width="105px" />
                    </td>
                    <td class="auto-style9"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style10"></td>
                </tr>
            </table>
            <br />
            <br />
            <br />
        </div>
        <asp:GridView ID="gridVendedores" runat="server" Width="341px">
        </asp:GridView>
    </form>
</body>
</html>
