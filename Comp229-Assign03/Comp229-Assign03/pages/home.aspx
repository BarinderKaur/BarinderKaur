<%@ Page Title="" Language="C#" MasterPageFile="~/pages/mySite.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Comp229_Assign03.pages.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Student Management</p>
<p>
        Student records can be viewed and updated here!</p>
<p>
       
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView_RowSelection" AutoGenerateColumns="False"  Height="156px" HorizontalAlign="Center" Width="276px" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="StudentID" HeaderText="StudentID" InsertVisible="False" ReadOnly="True"  />
                <asp:BoundField DataField="LastName" HeaderText="LastName" />
                <asp:BoundField DataField="FirstMidName" HeaderText="FirstMidName" />
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
     
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Comp229Assign03ConnectionString2 %>" SelectCommand="SELECT * FROM [Courses]"></asp:SqlDataSource>
     
    </p>
<p>
        <asp:Button ID="Button1" runat="server" Text="Add Students" OnClick="Button1_Click" />
</p>
</asp:Content>
