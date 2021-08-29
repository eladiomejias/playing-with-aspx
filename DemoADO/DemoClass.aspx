<%@ Page Title="DemoClass" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DemoClass.aspx.cs" Inherits="DemoADO.DemoClass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br />
     <br />
     <h2>Importación con clase</h2>
     <asp:GridView ID="gridView" runat="server"> </asp:GridView>  

     <h2>Importación sin clase</h2>
     <asp:GridView ID="gridView2" runat="server"> </asp:GridView> 
</asp:Content>


