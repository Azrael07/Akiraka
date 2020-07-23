<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication5.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css.css" type="text/css" rel="stylesheet" />

</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button1" runat="server" Height="29px" OnClick="Button1_Click" Text="Search" Width="68px" />
            <br />
            <br />
            <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
