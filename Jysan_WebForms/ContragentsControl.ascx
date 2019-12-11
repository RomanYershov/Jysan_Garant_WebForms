<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ContragentsControl.ascx.cs" Inherits="ContragentsControl" %>

<asp:Menu runat="server" ID="menu" 
          disappearafter="2000"
          staticdisplaylevels="2"
          staticsubmenuindent="10" 
          orientation="Vertical"
          font-names="Arial" 
          target="_blank"
         >
    <Items>
        <asp:MenuItem NavigateUrl="IndividualsPage.aspx"    runat="server" Text="Физ.лица"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="LegalEntityPage.aspx"    runat="server" Text="Юр.лица"></asp:MenuItem>
    </Items>
</asp:Menu>






