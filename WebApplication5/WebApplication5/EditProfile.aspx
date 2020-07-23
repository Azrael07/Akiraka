<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="WebApplication5.EditProfile" %>

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
                <br />
                <asp:Label ID="Label4" runat="server" Text="Register"></asp:Label>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [users]"></asp:SqlDataSource>
                <asp:HiddenField ID="HiddenField1" runat="server" />
                <br />
                <br />
                <br />
                <br />
            <br />
                <asp:Label ID="Label7" runat="server" Text="Full Name"></asp:Label>
                &nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="215px"></asp:TextBox>
                <br />
            <br />
                <asp:Label ID="Label8" runat="server" Text="Username"></asp:Label>
                &nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" Height="30px" Width="215px"></asp:TextBox>
                <br />
            <br />
                <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
                &nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Height="30px" Width="215px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="215px"></asp:TextBox>
                <br />
                <br />
                <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Edit" Height="40px" Width="169px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Height="40px" OnClick="Button2_Click" Text="Delete" Width="168px" />
                </div>
        </div>
    </form>
</body>
</html>
