<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="Content/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div style="width:500px; margin:0 auto; margin-top:20px; margin-bottom:20px;">
            <h3>Register<asp:HiddenField ID="HiddenField_Id" runat="server" OnValueChanged="HiddenField1_ValueChanged" />
            </h3>
            <br />
            <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Phone Number"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Contacts]"></asp:SqlDataSource>
            <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Email Address"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Home Address"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem Value="Male">Male</asp:ListItem>
                    <asp:ListItem>&nbsp;&nbsp;Female</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <br />
            <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="Relationship"></asp:Label>
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                    <asp:ListItem>Please Select</asp:ListItem>
                    <asp:ListItem>Colleague</asp:ListItem>
                    <asp:ListItem>Family</asp:ListItem>
                    <asp:ListItem>Friend</asp:ListItem>
                </asp:DropDownList>
            </div>
            <br />
            <div class="form-group">
            <asp:Label ID="Label7" runat="server" Text="Date of Birth"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
            </div>
            <br />
            <asp:Button ID="Button1" runat="server" Text="edit" CssClass="form-control" OnClick="Button1_Click" Width="236px" />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="39px" ImageUrl="~/Images/Contols_-_Add_On-35-512.png" OnClick="ImageButton1_Click" OnClientClick="return confirm('Delete this record?');" Width="54px" />
        </div>
    </form>
</body>
</html>
