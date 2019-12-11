<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LegalEntityPage.aspx.cs" Inherits="LegalEntityPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Юр.лица</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding-bottom: 20px;">
        
            <asp:Label runat="server">Ф</asp:Label>
            <asp:TextBox runat="server" ID="name" ></asp:TextBox>
       
            <asp:Label runat="server">ИИН</asp:Label>
            <asp:TextBox runat="server" ID="iin" CssClass="form-control"></asp:TextBox>
   
            <asp:Button runat="server" ID="btnSubmit" OnClick="btnSubmit_OnClick" Text="Send"/>
        </div>
        <div class="well">
            <h4 class="alert alert-success">Список юридических лиц</h4>
            <asp:GridView runat="server" AllowPaging="True" ID="legalEntityGrid"
                          AllowSorting="True"
                          AutoGenerateColumns="False"
                          CellPadding="4"
                          DataKeyNames="Id" 
                          DataSourceID="SqlDataSource1"
                          ForeColor="Black"
                          GridLines="Vertical"
                          OnSelectedIndexChanged="OnSelectedIndexChanged" 
                          Width="603px"
                          BackColor="White"
                          BorderColor="#DEDFDE" 
                          BorderWidth="1px" 
                          BorderStyle="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Iin" HeaderText="Iin" SortExpression="Iin" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                </Columns>
                <EmptyDataTemplate>
                    Name
                </EmptyDataTemplate>
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" ForeColor="White" Font-Bold="True" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                               ConnectionString="<%$ ConnectionStrings:_contragentsDbConnectionString %>"
                               SelectCommand="SELECT [Name], [Id], [Iin] FROM [LegalEntities]"
                               UpdateCommand="Update LegalEntities SET Name=@Name,Iin=@Iin WHERE Id=@id" 
                               DeleteCommand="Delete LegalEntities where Id=@id">
            </asp:SqlDataSource>
        </div>
        <div class="well" style="margin-top: 20px;">
            <h4 class="alert alert-success">Контактные лица</h4>
            <asp:GridView runat="server" ID="contactsGrid" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#284775" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

            </asp:GridView>
        </div>
    </form>
</body>
</html>
