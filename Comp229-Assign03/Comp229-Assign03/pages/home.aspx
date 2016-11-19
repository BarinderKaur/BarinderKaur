<%@ Page Title="" Language="C#" MasterPageFile="~/pages/mySite.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Comp229_Assign03.pages.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Student Management</p>
<p>
        Student records can be viewed and updated here!</p>
<p>
       
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView_RowSelection" AutoGenerateColumns="False"  Height="156px" HorizontalAlign="Center" Width="276px" AutoGenerateSelectButton="True">
            <Columns>
                <asp:BoundField DataField="StudentID" HeaderText="StudentID" InsertVisible="False" ReadOnly="True"  />
                <asp:BoundField DataField="LastName" HeaderText="LastName" />
                <asp:BoundField DataField="FirstMidName" HeaderText="FirstMidName" />
            </Columns>
        </asp:GridView>
     
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Comp229Assign03ConnectionString2 %>" SelectCommand="SELECT * FROM [Courses]"></asp:SqlDataSource>
     
    </p>
<p>
        <asp:Button ID="Button1" runat="server" Text="Add Students" OnClick="Button1_Click" />
</p>
</asp:Content>
