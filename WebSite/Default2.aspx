<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
CatalogComponentName:<asp:TextBox runat="server" ID="txtComponentName"></asp:TextBox>
<asp:Button runat="server" ID="btnSave" OnClick="btnSave_OnClick"/>
</asp:Content>

