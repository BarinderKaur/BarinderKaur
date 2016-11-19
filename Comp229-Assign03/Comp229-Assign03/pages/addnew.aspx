<%@ Page Title="" Language="C#" MasterPageFile="~/pages/mySite.Master" AutoEventWireup="true" CodeBehind="addnew.aspx.cs" Inherits="Comp229_Assign03.pages.addnew" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    First Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    Last Name&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    <br />
    <br />
    Enrollment Date:&nbsp; &nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
</asp:Content>
