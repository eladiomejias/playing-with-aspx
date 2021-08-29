<%@ Page Title="Demo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DemoSearch.aspx.cs" Inherits="DemoADO.DemoSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />

    <h2>Search a Student</h2>

    <div> 
        
       <table>  
        <tr>  
        <td>   
           Buscar  
            </td>  
                <td>  
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="padding-form"></asp:TextBox>  
                </td>  
                <td>   
                  <asp:Button ID="Button1" runat="server" Text="Buscar estudiante" CssClass="padding-form" onclick="Button1_Click" />  
                </td>  
            </tr>  
        </table> 
        
        <table>
            <tr>
                <td>
                    <p>
                        <asp:Label ID="Label2" runat="server" Text="label"></asp:Label>  </p>

                </td>
            </tr>
        </table>  

        <asp:GridView ID="GridView1" runat="server"  BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" CellSpacing="2" Height="90px" Width="260px">
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" /> 

        </asp:GridView>

     </div>  
    
</asp:Content>
