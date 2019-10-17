<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoadingTorneo.aspx.cs" Inherits="ProyectoTorneo.LoadingTorneo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <h1>
                <asp:Button ID="ButtonRegresar" runat="server" OnClick="ButtonRegresar_Click" Text="Regresar" />
                Torneo
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </h1>
            
            <div>

                <h2>Jugadores</h2>
                <asp:ListBox ID="ListBox1" runat="server" Width="300px"></asp:ListBox>

                <br />

                <br />
                <asp:Button ID="ButtonEliminaJugador" runat="server" OnClick="ButtonEliminaJugador_Click" Text="Eliminar Jugador" />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Comenzar" OnClick="Button1_Click" />

            </div>
        </div>
    </form>
</body>
</html>
