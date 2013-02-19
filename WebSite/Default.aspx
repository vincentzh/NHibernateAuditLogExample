<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   username:<asp:TextBox runat="server" ID="txtUserName"></asp:TextBox>
   <asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnSave_OnClick"/>
</asp:Content>
