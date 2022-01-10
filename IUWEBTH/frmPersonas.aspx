<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPersonas.aspx.cs" Inherits="IUWEBTH.frmPersonas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                Listado de personas
                <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" style="height: 26px" Text="Mostrar" />
                <asp:LinkButton ID="LinkIngresarDatos" runat="server" PostBackUrl="~/personaAgregar.aspx">Ingresar Datos</asp:LinkButton>
            </div>
            <p>
                &nbsp;</p>
            <asp:GridView ID="GridViewPersonas" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
