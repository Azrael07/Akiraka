<%@ Page Title="Article" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DisplayIndividualArticle.aspx.cs" Inherits="WebApplication5.DisplayIndividualArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="mycss.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <div id="infotext"><asp:PlaceHolder ID="PlaceHolder1" runat="server" ClientIDMode="AutoID"></asp:PlaceHolder>
        <asp:HiddenField ID="HiddenField2" runat="server" />
        
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="comment">
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Height="24px" Width="217px"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
    <asp:TextBox ID="TextBox1" runat="server" Height="117px" Width="591px" TextMode="multiline"></asp:TextBox>
        <br />
        <br />
        <br />
    <asp:Button ID="Button1" runat="server" Text="Post" OnClick="Button1_Click" />
        <br />
<asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
        </div>
</asp:Content>
