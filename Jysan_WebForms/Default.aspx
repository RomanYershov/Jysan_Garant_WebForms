<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <%@Register tagName="WebUserControl" TagPrefix="contragents_control" src="ContragentsControl.ascx" %>

    <contragents_control:WebUserControl runat="server" ID="WebUserControl1"/>

</asp:Content>
