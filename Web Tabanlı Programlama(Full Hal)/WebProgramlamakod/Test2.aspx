<%@ Page Title="" Language="C#" MasterPageFile="~/AnaSayfa.Master" AutoEventWireup="true" CodeBehind="Test2.aspx.cs" Inherits="Proje.Web.Test2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
       LİNQ Sorguları</p><br />
    <asp:ListBox ID="lst" runat="server"></asp:ListBox>
<br />
<br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
<br />
<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
</asp:Content>
