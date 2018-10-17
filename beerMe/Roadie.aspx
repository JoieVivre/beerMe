<%@ Page Title="" Language="C#" MasterPageFile="~/beerMe.Master" AutoEventWireup="true" CodeBehind="Roadie.aspx.cs" Inherits="beerMe.Roadie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h1>Roadie</h1>
   





    <asp:Table ID="RoadieInfoTable" runat="server" Visible="False">
    
        <asp:TableHeaderRow ID="RoadieInfo">
              <asp:TableHeaderCell Scope="Column" Text="Brand" />  
              <asp:TableHeaderCell Scope="Column" Text="ABV" />  
              <asp:TableHeaderCell Scope="Column" Text="Type" />
              <asp:TableHeaderCell Scope="Column" Text="Volume" />
              <asp:TableHeaderCell Scope="Column" Text="Container" />
              <asp:TableHeaderCell Scope="Column" Text="Total Rating" />
        <asp:TableHeaderCell Scope="Column" Text="Number of Raters" />
        <asp:TableHeaderCell Scope="Column" Text="Average Rating" />
            </asp:TableHeaderRow>
    </asp:Table>
    <asp:Button ID="ButtonAddRating" runat="server" Text="ADD YOUR RATING!" OnClick="ButtonAddRating_Click" />

    <br/>
    
    <asp:ImageButton ID="ImageButton1" runat="server" Visible="False" OnClick="ImageButton1_Click" ImageUrl="~/Images/beerRating1.png"/>
    <asp:ImageButton ID="ImageButton2" runat="server" Visible="False" ImageUrl="~/Images/beerRating2.png" OnClick="ImageButton2_Click"/>
    <asp:ImageButton ID="ImageButton3" runat="server" Visible="False" ImageUrl="~/Images/beerRating3.png" OnClick="ImageButton3_Click"/>
    <asp:ImageButton ID="ImageButton4" runat="server" Visible="False" OnClick="ImageButton4_Click" ImageUrl="~/Images/beerRating4.png"/>
    <asp:ImageButton ID="ImageButton5" runat="server" Visible="False" ImageUrl="~/Images/beerRating5.png" OnClick="ImageButton5_Click"/>
    <br/>
    <asp:Button ID="ButtonRatingAdded" runat="server" Text="Button" Visible="False" />

    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>



</asp:Content>
