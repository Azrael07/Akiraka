<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="WebApplication5.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
     <link href="css.css" rel="stylesheet" />
    <style type="text/css">
        #regform {
            height: 510px;
            width: 457px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id ="regform">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [users]"></asp:SqlDataSource>
                <br />
                <asp:Label ID="Label4" runat="server" Text="Register"></asp:Label>
                <br />
                <br />
            <br />
                <asp:Label ID="Label7" runat="server" Text="Full Name"></asp:Label>
                &nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="215px"></asp:TextBox>
                <br />
            <br />
                <asp:Label ID="Label8" runat="server" Text="Username"></asp:Label>
                &nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" Height="30px" Width="215px"></asp:TextBox>
                <br />
            <br />
                <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
                &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Height="30px" Width="215px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="215px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label9" runat="server" Text="Phone"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox5" runat="server" Height="30px" Width="215px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label10" runat="server" Text="Role"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox6" runat="server" Height="30px" Width="215px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label11" runat="server" Text="ID"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:TextBox ID="TextBox7" runat="server" Height="30px" Width="215px"></asp:TextBox>
                <br />
                <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" Height="40px" Width="169px" />
                </div>
        </div>
    </form>
</body>
</html>
