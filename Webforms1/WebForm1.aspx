<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Webforms1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="input" runat="server"></asp:TextBox>

        <asp:DropDownList ID="dd1" runat="server">
            <asp:ListItem Value="">(Select)</asp:ListItem>
            <asp:ListItem>mm</asp:ListItem>
            <asp:ListItem>cm</asp:ListItem>
            <asp:ListItem>dm</asp:ListItem>
            <asp:ListItem>m</asp:ListItem>
            <asp:ListItem>km</asp:ListItem>
            <asp:ListItem>mil</asp:ListItem>
        </asp:DropDownList>
        
        <asp:Label ID="toLabel" runat="server">to</asp:Label>

        <asp:DropDownList ID="dd2" runat="server">
            <asp:ListItem Value="">(Select)</asp:ListItem>
            <asp:ListItem>mm</asp:ListItem>
            <asp:ListItem>cm</asp:ListItem>
            <asp:ListItem>dm</asp:ListItem>
            <asp:ListItem>m</asp:ListItem>
            <asp:ListItem>km</asp:ListItem>
            <asp:ListItem>mil</asp:ListItem>
        </asp:DropDownList>
        
        <asp:Button runat="server" id="ConvertButton" Text="Convert This" OnClick="ConvertButton_Click"/>

        <asp:Label ID="output" runat="server"></asp:Label>
    </form>
</body>
</html>
