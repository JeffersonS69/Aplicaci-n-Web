<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="personaAgregar.aspx.cs" Inherits="IUWEBTH.personaAgregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                Listado de Personas<br />
            </div>
            <table class="auto-style1">
                <tr>
                    <td>Ingrese Cedula</td>
                    <td>
                        <asp:TextBox ID="txtcedula" runat="server" MaxLength="10"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Ingrese Nombre</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Ingrese Apellido</td>
                    <td>
                        <asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Ingrese Fecha</td>
                    <td>
                        <asp:TextBox ID="txtfecha" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Ingrese Peso</td>
                    <td>
                        <asp:TextBox ID="txtpeso" runat="server" MaxLength="6"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMenaje" runat="server" Enabled="False" ForeColor="#66FF66"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" Width="78px" />
                        <asp:LinkButton ID="LinkListarPersonas" runat="server" PostBackUrl="~/frmPersonas.aspx">Listar personas</asp:LinkButton>
                    </td>
                </tr>
            </table>
            <p>
                &nbsp;</p>
        </div>
    </form>
</body>
</html>
