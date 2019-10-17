<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoTorneo.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <h1>Login</h1>
            <div>

                Username:&nbsp;
                <asp:TextBox ID="TextBoxUsuario" runat="server" autocomplete="off"></asp:TextBox>
                <br />
                <br />
                Contraseña:&nbsp;
                <asp:TextBox ID="TextBoxPassword" runat="server" AutoCompleteType="Disabled" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                Torneo:&nbsp;
                <asp:DropDownList ID="DropDownListTorneos" runat="server">
                </asp:DropDownList>
                <br />
                <br />
                Espectador:&nbsp;
                <asp:CheckBox ID="CheckBoxEsEspectador" runat="server" />
                <br />
                <br />
                <br />
                <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
                <br />
                <br /> 
                <asp:Button ID="ButtonRegistrar" runat="server" Text="Registrar Usuario" OnClick="ButtonRegistrar_Click" />

                <br />

                <br />
                <asp:Button ID="ButtonRegistrarTorneo" runat="server" Text="Registrar Torneo" OnClick="ButtonRegistrarTorneo_Click" />
                <br />
                <br />
                <asp:Label ID="LabelDatosCorrectos" runat="server"></asp:Label>

            </div>
        </div>

    </form>
</body>
</html>
