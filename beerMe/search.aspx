<%@ Page Title="" Language="C#" MasterPageFile="~/beerMe.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="beerMe.search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Text="Beer" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <br/>
    <asp:Label ID="Label1" runat="server" Text="Filter your results by:" Visible="False"></asp:Label>   
    <br/>
    <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Visible="False" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
            <asp:ListItem Value="name">Name</asp:ListItem>
            <asp:ListItem Value="brand">Brand</asp:ListItem>
            <asp:ListItem Value="ABV">ABV</asp:ListItem>
            <asp:ListItem Value="type">Type</asp:ListItem>
            <asp:ListItem Value="volume">Volume</asp:ListItem>
            <asp:ListItem Value="container">Container</asp:ListItem>
            <asp:ListItem Value="rating">Rating</asp:ListItem>
        </asp:ListBox>
        <br/>

        <asp:Table ID="BeerTable1" runat="server" Visible="False">
            <asp:TableHeaderRow ID="BeerTableHeaderRow">
              <asp:TableHeaderCell Scope="Column" Text="Name" />
              <asp:TableHeaderCell Scope="Column" Text="Brand" /> 
              <asp:TableHeaderCell Scope="Column" Text="ABV" /> 
              <asp:TableHeaderCell Scope="Column" Text="Type" />
              <asp:TableHeaderCell Scope="Column" Text="Volume" />
              <asp:TableHeaderCell Scope="Column" Text="Container" />
              <asp:TableHeaderCell Scope="Column" Text="Rating" />
            </asp:TableHeaderRow>
        </asp:Table>
    <br/>
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Suppliers" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" />
   
        <br/>
    <asp:Label ID="Label2" runat="server" Text="Filter your results by: " Visible="False"></asp:Label>
    <br/>
    <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True" Visible="False" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged">
            <asp:ListItem Value="businessName">Name</asp:ListItem>
            <asp:ListItem Value="businessType">Type</asp:ListItem>
            <asp:ListItem Value="address">Address</asp:ListItem>
            <asp:ListItem>hours</asp:ListItem>
        </asp:ListBox>
        <br/>
       
        <asp:Table ID="SupplierTable1" runat="server" Visible="False">
            <asp:TableHeaderRow ID="SupplierTableHeaderRow">
              <asp:TableHeaderCell Scope="Column" Text="Name" />
              <asp:TableHeaderCell Scope="Column" Text="Type" /> 
             <asp:TableHeaderCell Scope="Column" Text="Address" /> 
              <asp:TableHeaderCell Scope="Column" Text="Phone" />
             <asp:TableHeaderCell Scope="Column" Text="Hours" />
             <asp:TableHeaderCell Scope="Column" Text="Email" />
            </asp:TableHeaderRow>
        </asp:Table>


        <br/>

        <asp:HyperLink ID="HyperLink1" runat="server"></asp:HyperLink>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

</asp:Content>
