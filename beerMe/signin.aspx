<%@ Page Title="" Language="C#" MasterPageFile="~/beerMe.Master" AutoEventWireup="true" CodeBehind="signin.aspx.cs" Inherits="beerMe.signin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>beerMe Sign In</h1>
    <asp:Label ID="emailSignlbl" runat="server" Text="Email: "></asp:Label>
    <asp:TextBox ID="emailSigntxt" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="pwdSignlbl" runat="server" Text="Password: "></asp:Label>
    <asp:TextBox ID="pwdSigntxt" runat="server"></asp:TextBox>
    <asp:Button ID="loginBTN" runat="server" Text="Log In" OnClick="loginBTN_Click" />
    <br />
    <br />
    <asp:CheckBox ID="userType" runat="server" Text="Member" />
    <asp:CheckBox ID="supplierType" runat="server" Text="Supplier" />
    <br />
    <br />
    <asp:HyperLink ID="registerLink" runat="server" NavigateUrl="~/registration.aspx">Not A Member? Please Register Here</asp:HyperLink>
</asp:Content>
