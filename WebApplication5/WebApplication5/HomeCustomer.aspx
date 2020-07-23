<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeCustomer.aspx.cs" Inherits="WebApplication5.HomeCustomer" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <link href="mycss.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="headercolor">
        <header id="header">
        <h1 style="height: 50px">Revelare<asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click1" Height="36px" ImageUrl="~/Images/1096890.png" Width="36px" ImageAlign ="right" BorderStyle="None"/>
        </h1>
            
            </header>
        <header id ="SideHeader"> <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LOGOUT</asp:LinkButton>
            <asp:Label ID="LoginNotify" runat="server" visble=false Font-Names="Calibri" ForeColor="#3399FF"></asp:Label>
            <asp:ImageButton ID="ImageButton2" runat="server" Height="25px" ImageUrl="~/Images/avatar-380-456332.png" OnClick="ImageButton2_Click" Width="24px" Visible="False" />
            </header></div>

    <nav id ="nav">
        <ul>
            <li><a href="HomeCustomer.aspx">Home</a></li>
            <li><a href="Broadcast.aspx">Broadcast</a></li>
            <li><a href="Infographics.aspx">Infographics</a></li>
            <li><a href="Report.aspx">Report</a></li>
            <!--<li><a href="Webform1.aspx">login</a></li>-->
            </ul>
    </nav>

        
    
        <aside id="side">
            <h1>&nbsp;</h1>
      <%--  <a href="#">
            <p>Craft</p>
        </a>
        <a href="#">
            <p>Crafting magic</p>
        </a>--%>
    </aside>
    
    
        <div id="con">
            <div id="main">
            
                <br />
        </div>
            </div>



        <div id="card">
         
            <div id="infophoto">
                <div id="infotext"><asp:PlaceHolder ID="PlaceHolder1" runat="server" ClientIDMode="AutoID"></asp:PlaceHolder></div>
                    </div>
   
        </div>

        
        
        <footer id="footer">© 2020 Revelare By Burhan</footer>
        <div>
           
            
           
        </div>
    </form>
</body>
</html>