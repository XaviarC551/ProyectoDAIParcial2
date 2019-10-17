<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registra.aspx.cs" Inherits="ProyectoTorneo.Registra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <h1>Ingrese su información</h1>
            <div>

                Nombre:&nbsp;
                <asp:TextBox ID="TextBoxNombre" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                <br />
                Usuario:&nbsp;
                <asp:TextBox ID="TextBoxUsuario" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                <br />
                Contraseña:&nbsp;
                <asp:TextBox ID="TextBoxPassword" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="ButtonRegistrar" runat="server" OnClick="ButtonRegistrar_Click" Text="Registrar" />

            </div>
        </div>
    </form>
</body>
</html>
