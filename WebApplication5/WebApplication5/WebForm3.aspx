<%@ Page Title="Home/Magicverse" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication5.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="mycss.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <asp:TextBox ID="Search" runat="server" Height="22px" Width="1133px"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" Height="26px" Width="56px" />
     <div id="infotext"><asp:PlaceHolder ID="PlaceHolder1" runat="server" ClientIDMode="AutoID"></asp:PlaceHolder></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
</asp:Content>

