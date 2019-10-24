<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TorneoActual.aspx.cs" Inherits="ProyectoTorneo.TorneoActual" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>

        /* Create three equal columns that floats next to each other */
        .column {
          float: left;
          padding: 10px;
          height: 65px;
        }

        .left, .right {
            width: 25%;
            height: 65px;
        }

        .middle {
            width: 45%;
            height: 65px;
        }

        /* Clear floats after the columns */
        .row:after {
          content: "";
          display: table;
          clear: both;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="row">
                <div class ="column left">
                    <asp:Button ID="Button1" runat="server" Text="Regresar" />
                    <br />
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Regresar Login" />
                </div>
                <div class ="column middle" style="text-align:center"><h1>Torneo<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h1></div>
                <div class ="column right" style="text-align: right">
                    <asp:Button ID="Button3" runat="server" Text="Acabar" />
                </div>
            </div>
            <div style="background-image: url('Images/BracketsTorneo.jpg'); height: 660px; width: 1308px; text-align:center;">

            </div>
        </div>
    </form>
</body>
</html>
