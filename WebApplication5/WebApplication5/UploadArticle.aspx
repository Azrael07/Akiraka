<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadArticle.aspx.cs" Inherits="WebApplication5.UploadArticle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
    <title></title>
     <link href="css.css" rel="stylesheet" />
    <style type="text/css">
        #TextArea2 {
            height: 359px;
            width: 1788px;
        }
        #TextArea1 {
            width: 1777px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" method="post" enctype="multipart/form-data">
        <div>
          <div id="uploadform">
            <asp:Label ID="Label3" runat="server" Text="Title"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox11" runat="server" TextMode="multiline"  Width="1308px" Height="17px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Date"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox22" runat="server" ></asp:TextBox>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Article]"></asp:SqlDataSource>
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <br />
              <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="170px">
                  <asp:ListItem Value="1">Home</asp:ListItem>
                  <asp:ListItem Value="2">Broadcast</asp:ListItem>
                  <asp:ListItem Value="3">Infographics</asp:ListItem>
                  <asp:ListItem Value="4">Report</asp:ListItem>
              </asp:DropDownList>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Article"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox33" runat="server" Height="301px" Width="1304px" TextMode="multiline"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Upload Image"></asp:Label>
            <br />
            <asp:FileUpload ID="contact_picture" runat="server"/>
              <br />
              <br />
            <br />
            <asp:Button ID="Button11" runat="server" Text="Submit" Align="left" OnClick="Button1_Click" Height="33px" Width="132px"/>
            <br />
            <br />
        </div>
            </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
