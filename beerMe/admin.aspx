<%@ Page Title="" Language="C#" MasterPageFile="~/beerMe.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="beerMe.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Label ID="fName_lbl" runat="server" Text="First Name: "></asp:Label>
    <asp:TextBox ID="fName_txt" runat="server"></asp:TextBox>
    <asp:Label ID="lName_lbl" runat="server" Text="Last Name: "></asp:Label>   
    <asp:TextBox ID="lName_txt" runat="server"></asp:TextBox>
    <asp:Label ID="dob_lbl" runat="server" Text="Date Of Birth: "></asp:Label>
    <asp:TextBox ID="dob_txt" runat="server"></asp:TextBox>
    <asp:Label ID="phone_lbl" runat="server" Text="Phone: "></asp:Label>
    <asp:TextBox ID="phone_txt" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="email_lbl" runat="server" Text="Email: "></asp:Label>
    <asp:TextBox ID="email_txt" runat="server"></asp:TextBox>
    <asp:Label ID="pwd_lbl" runat="server" Text="Password: "></asp:Label>
    <asp:TextBox ID="pwd_txt" runat="server"></asp:TextBox>
    <asp:Button ID="addUserBTN" runat="server" Text="Add" OnClick="addUserBTN_Click" />
    <asp:Button ID="updateUserBTN" runat="server" Text="Update" OnClick="updateUserBTN_Click" />
    <asp:Label ID="addMessage" runat="server" Text="User Has Been Succesfully Added to the Database" Visible="False" ForeColor="Red"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="usersTable" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="userID" DataSourceID="users" ForeColor="#333333" GridLines="None" HorizontalAlign="Center">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="userID" HeaderText="User ID" InsertVisible="False" ReadOnly="True" SortExpression="userID" />
            <asp:BoundField DataField="fName" HeaderText="First Name" SortExpression="fName" />
            <asp:BoundField DataField="lName" HeaderText="Last Name" SortExpression="lName" />
            <asp:BoundField DataField="dob" HeaderText="D.O.B." SortExpression="dob" />
            <asp:BoundField DataField="phone" HeaderText="Phone" SortExpression="phone" />
            <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
            <asp:BoundField DataField="pwd" HeaderText="Password" SortExpression="password" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:Label ID="userID_lbl" runat="server" Text="User ID: "></asp:Label>
    <asp:TextBox ID="userID_txt" runat="server"></asp:TextBox>
    <asp:Button ID="deleteUserBTN" runat="server" Text="Delete" OnClick="deleteUserBTN_Click"/>
    <asp:Label ID="deleteMessage" runat="server" Text="User Has Been Succesfully Deleted from the Database" Visible="False" ForeColor="Red"></asp:Label>
    <asp:Label ID="updateMessage" runat="server" Text="User Has Been Succesfully Updated from the Database" Visible="False" ForeColor="Red"></asp:Label>

    <asp:SqlDataSource ID="users" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
    
    <br />
    <hr />
    <br />
    
    <asp:Button ID="addSupplierBTN" runat="server" Text="Add" OnClick="addSupplierBTN_Click" />
    <asp:Button ID="updateSupplierBTN" runat="server" Text="Update" OnClick="updateSupplierBTN_Click" />
    <asp:Label ID="supplierAddMessage" runat="server" Text="Supplier has Succesfully been added to the database" Visible="false" ForeColor="Red"></asp:Label>
    <br />
    <br />
    <asp:Label ID="businessName_lbl" runat="server" Text="Buisness Name: "></asp:Label>
    <asp:TextBox ID="businessName_txt" runat="server"></asp:TextBox>
    <asp:Label ID="businessType_lbl" runat="server" Text="Business Type: "></asp:Label>
    <asp:DropDownList ID="businessType_ddl" runat="server">
        <asp:listitem>Bar</asp:listitem>
        <asp:ListItem>Brewery</asp:ListItem>
        <asp:ListItem>Resturant</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="address_lbl" runat="server" Text="Address: "></asp:Label>
    <asp:TextBox ID="address_txt" runat="server"></asp:TextBox>
    <asp:Label ID="supplierPhone_lbl" runat="server" Text="Phone: "></asp:Label>
    <asp:TextBox ID="supplierPhone_txt" runat="server"></asp:TextBox>
    <asp:Label ID="hours_lbl" runat="server" Text="Hours: "></asp:Label>
    <asp:TextBox ID="hours_txt" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="supplierEmail_lbl" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="supplierEmail_txt" runat="server"></asp:TextBox>
    <asp:Label ID="supplierPwd_lbl" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="supplierPwd_txt" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:GridView ID="suppliersTable" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="suppliersID" DataSourceID="suppliers" ForeColor="#333333" GridLines="None" HorizontalAlign="Center">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="suppliersID" HeaderText="Supplier ID" InsertVisible="False" ReadOnly="True" SortExpression="suppliersID" />
            <asp:BoundField DataField="businessName" HeaderText="Business Name" SortExpression="buinessName" />
            <asp:BoundField DataField="businessType" HeaderText="Buisness Type" SortExpression="buisnessType" />
            <asp:BoundField DataField="address" HeaderText="Address" SortExpression="address" />
            <asp:BoundField DataField="phone" HeaderText="Phone" SortExpression="phone" />
            <asp:BoundField DataField="hours" HeaderText="Hours" SortExpression="hours" />
            <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
            <asp:BoundField DataField="pwd" HeaderText="Password" SortExpression="pwd" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:Label ID="supplierID_lbl" runat="server" Text="Supplier ID: "></asp:Label>
    <asp:TextBox ID="supplierID_txt" runat="server"></asp:TextBox>
    <asp:Button ID="deleteSupplierBTN" runat="server" Text="Delete" OnClick="deleteSupplierBTN_Click"/>
    <asp:Label ID="supplierDeleteMessage" runat="server" Text="Supplier has succesfully been deleted from the database" Visible="false" ForeColor="Red"></asp:Label>
    <asp:Label ID="supplierUpdateMessage" runat="server" Text="Supplier has succesfully been updated in the database" Visible="false" ForeColor="Red"></asp:Label>
    <br />
    <asp:SqlDataSource ID="suppliers" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Suppliers]"></asp:SqlDataSource>
    <hr />
    <br />
    <asp:Button ID="addBeerBTN" runat="server" Text="Add" OnClick="addBeerBTN_Click" />
    <asp:Button ID="updateBeerBTN" runat="server" Text="Update" OnClick="updateBeerBTN_Click" />
    <br />
    <asp:Label ID="beerName_lbl" runat="server" Text="Beer Name: "></asp:Label>
    <asp:TextBox ID="beerName_txt" runat="server"></asp:TextBox>
    <asp:Label ID="beerBrand_lbl" runat="server" Text="Beer Brand: "></asp:Label>
    <asp:TextBox ID="beerBrand_txt" runat="server"></asp:TextBox>
    <asp:Label ID="beerABV_lbl" runat="server" Text="ABV"></asp:Label>
    <asp:TextBox ID="beerABV_txt" runat="server"></asp:TextBox>
    <asp:Label ID="beerType_lbl" runat="server" Text="Beer Type: "></asp:Label>
    <asp:TextBox ID="beerType_txt" runat="server"></asp:TextBox>
    <asp:Label ID="beerVolume_lbl" runat="server" Text="Volume: "></asp:Label>
    <asp:TextBox ID="beerVolume_txt" runat="server"></asp:TextBox>
    <asp:Label ID="beerContainer_lbl" runat="server" Text="Container"></asp:Label>
    <asp:TextBox ID="beerContainer_txt" runat="server"></asp:TextBox>
    <asp:Label ID="beerPPU_lbl" runat="server" Text="PPU"></asp:Label>
    <asp:TextBox ID="beerPPU_txt" runat="server"></asp:TextBox>
    <asp:Label ID="beerRating_lbl" runat="server" Text="Rating(Total): "></asp:Label>
    <asp:DropDownList ID="beerRating_ddl" runat="server">
        <asp:ListItem>0</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="usersVoted_lbl" runat="server" Text="Users Voted: "></asp:Label>
    <asp:DropDownList ID="usersVoted_ddl" runat="server">
        <asp:ListItem>0</asp:ListItem>
    </asp:DropDownList>

    <asp:Label ID="addBeerMessage" runat="server" Text="Beer was succesfully added to database" Visible="false" ForeColor="Red"></asp:Label>

    <br />
    <asp:GridView ID="beersTable" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="beerID" DataSourceID="beers" ForeColor="#333333" GridLines="None" HorizontalAlign="Center">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="beerID" HeaderText="Beer ID" ReadOnly="True" SortExpression="beerID" />
            <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
            <asp:BoundField DataField="brand" HeaderText="Brand" SortExpression="brand" />
            <asp:BoundField DataField="ABV" HeaderText="ABV" SortExpression="ABV" />
            <asp:BoundField DataField="type" HeaderText="Type" SortExpression="type" />
            <asp:BoundField DataField="volume" HeaderText="Volume" SortExpression="volume" />
            <asp:BoundField DataField="container" HeaderText="Container" SortExpression="container" />
            <asp:BoundField DataField="PPU" HeaderText="PPU" SortExpression="PPU" />
            <asp:BoundField DataField="rating" HeaderText="Rating(TotalPTS)" SortExpression="rating" />
            <asp:BoundField DataField="numUsersRated" HeaderText="User Voted" SortExpression="numUsersRated" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>

    <asp:Label ID="beerID_lbl" runat="server" Text="BeerID: "></asp:Label>
    <asp:TextBox ID="beerID_txt" runat="server"></asp:TextBox>
    <asp:Button ID="deleteBeerBTN" runat="server" Text="Delete" OnClick="deleteBeerBTN_Click"/>
    <asp:Label ID="deleteBeerMessage" runat="server" Text="Beer was successfully deleted from Database" Visible="false" ForeColor="Red"></asp:Label>
    <asp:Label ID="updateBeerMessage" runat="server" Text="Beer was successfully updated to Database" Visible="false" ForeColor="Red"></asp:Label>

    <asp:SqlDataSource ID="beers" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Beer]"></asp:SqlDataSource>

</asp:Content>
