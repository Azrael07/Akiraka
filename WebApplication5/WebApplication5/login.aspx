<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication5.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="loginform">
            <asp:Label ID="Label4" runat="server" Text="Administrator Login"></asp:Label>
                <br />
                <br />
                <br />
            <br />
            <br />
            &nbsp;<asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" align="center" Height="22px" Width="206px"></asp:TextBox>
                <br />
            <br />
            <br />
            &nbsp;<asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" TextMode="Password" runat="server" align="center" Height="22px" Width="205px"></asp:TextBox>
                <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Height="30px" OnClick="Button2_Click" Text="Sign up" Width="145px" />
&nbsp;<asp:Button ID="Button1" runat="server" Text="login" OnClick="Button1_Click" align="center" Width="145px" Height="30px"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
                </div>
        </div>
       
    </form>
</body>
</html>
