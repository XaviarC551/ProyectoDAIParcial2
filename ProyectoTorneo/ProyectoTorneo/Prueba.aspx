<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba.aspx.cs" Inherits="ReporteFlexibleIntento2.Prueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Reporte Flexible<br />
            <br />
            Columnas:<asp:CheckBoxList ID="CheckBoxList1" runat="server">
            </asp:CheckBoxList>
            <br />
            Filtros:<br />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" />
&nbsp;Filtrar por usuario:
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" />
&nbsp;Filtrar por Torneo:
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Crear Reporte" />
            <br />
            <br />
            <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
