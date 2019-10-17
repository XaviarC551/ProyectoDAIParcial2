<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistraTorneo.aspx.cs" Inherits="ProyectoTorneo.RegistraTorneo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <h1>Registrar Torneo</h1>
            <div>

                Nombre del Torneo<br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="ButtonRegistrarTorneo" runat="server" OnClick="ButtonRegistrarTorneo_Click" Text="Registrar" />

            </div>
        </div>
    </form>
</body>
</html>
