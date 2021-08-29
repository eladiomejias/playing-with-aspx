<%@ Page Title="Demo Person" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="DemoADO.Demo" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />

    <p>
        Demo data
    </p>

    <br />
    <br />

   <h1>Ejemplo de gridview con corrida en la clase automatica</h1>
   <asp:GridView ID="GridView1" runat="server"> </asp:GridView>  

    <form action="/" method="post"></form>


    <h2>Ejemplo grid view con corrida en el codigo</h2>
    <asp:gridview id="CustomersGridView" 
        datasourceid="CustomersSource" 
        autogeneratecolumns="true"
        emptydatatext="No data available." 
        runat="server">
                
      </asp:gridview>
            
      <!-- This example uses Microsoft SQL Server and connects  -->
      <!-- to the Northwind sample database. Use an ASP.NET     -->
      <!-- expression to retrieve the connection string value   -->
      <!-- from the Web.config file.                            -->
      <asp:sqldatasource id="CustomersSource"
        selectcommand="Select * From Person"
        connectionstring="<%$ ConnectionStrings:connectionASPX %>" 
        runat="server"/>


    <!-- Dataset -->
    <!--<h2>Ejemplo con dataSet</h2>
    <asp:gridview ID="gridView2" runat="server"></asp:gridview>-->




</asp:Content>
