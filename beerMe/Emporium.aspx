<%@ Page Title="" Language="C#" MasterPageFile="~/beerMe.Master" AutoEventWireup="true" CodeBehind="Emporium.aspx.cs" Inherits="beerMe.emporium" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Emporium Barcade</h1>
    <hr />
    <h4>Business Type: Bar</h4>
    <h4>Address: Milwaukee </h4>
    <h4>Phone: 999-999-9999</h4>
    <h4>Hours of Operation: 8:00am - 8:00pm</h4>
    <h4>Email: emporium@gmail.com</h4>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Inventory" OnClick="Button1_Click" />
    <br />
    <asp:Table ID="EmporiumInventoryTable" runat="server" Visible="False">
    <asp:TableHeaderRow ID="EmporiumInventoryTableHeaderRow">
              <asp:TableHeaderCell Scope="Column" Text="Name" />
              <asp:TableHeaderCell Scope="Column" Text="Brand" />  
              <asp:TableHeaderCell Scope="Column" Text="ABV" />  
              <asp:TableHeaderCell Scope="Column" Text="Type" />
              <asp:TableHeaderCell Scope="Column" Text="Volume" />
              <asp:TableHeaderCell Scope="Column" Text="Container" />
                  <asp:TableHeaderCell Scope="Column" Text="Amount" />        
    </asp:TableHeaderRow>
        </asp:Table>
    
    <asp:SqlDataSource ID="invBeer" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [name], [brand], [ABV], [type], [volume], [container], [PPU] FROM [Beer]"></asp:SqlDataSource>
    <br/>
    <asp:Label ID="Label1" runat="server" Text="Beer Name: " Visible="False"></asp:Label>
    <asp:TextBox ID="TBbeerName" runat="server" Visible="False"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Amount: " Visible="False"></asp:Label>
    <asp:TextBox ID="TBbeerAmount" runat="server" Visible="False"></asp:TextBox>
    <br/>
    <asp:Button ID="Button2" runat="server" Text="Update Inventory" OnClick="Button2_Click" Visible="False" />
    </asp:Content>