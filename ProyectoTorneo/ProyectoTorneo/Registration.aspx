<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="ProyectoTorneo.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="text-align: center">
                <h1>Login</h1>
            </div>
            <div style="text-align: center">
                <div style="text-align: left; width: 328px; margin-left: 480px;">
                    Username&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Password&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Torneo&nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                    <br />
                    <br />
                    Espectador
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </div>
                
                <asp:Button ID="Button1" runat="server" Text="Button" />
                <br />
                
                <br />
                <asp:Button ID="Button2" runat="server" Text="Button" />
                <br />

            </div>
        </div>
    </form>
</body>
</html>
