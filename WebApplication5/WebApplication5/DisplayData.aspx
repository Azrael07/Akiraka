<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayData.aspx.cs" Inherits="WebApplication5.DisplayData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="css.css" type="text/css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>
        </div>
    </form>
</body>
</html>
