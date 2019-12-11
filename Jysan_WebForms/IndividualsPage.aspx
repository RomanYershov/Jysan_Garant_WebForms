<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="IndividualsPage.aspx.cs" Inherits="LegalEntityPage" %>
<%@ Import Namespace="Jysan.BLL.Models" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Физ лица</title>
</head>
<body>
   
  
<form id="form1" runat="server">
    <div style="padding-bottom: 20px;">
        
            <asp:Label runat="server">Ф</asp:Label>
            <asp:TextBox runat="server" ID="fName" ></asp:TextBox>
      
   
      
            <asp:Label runat="server">И</asp:Label>
            <asp:TextBox runat="server" ID="lName" CssClass="form-control"></asp:TextBox>
     
  
        
            <asp:Label runat="server">О</asp:Label>
            <asp:TextBox runat="server" ID="pName" CssClass="form-control"></asp:TextBox>
     
      
       
            <asp:Label runat="server">ИИН</asp:Label>
            <asp:TextBox runat="server" ID="iin" CssClass="form-control"></asp:TextBox>
   
        <asp:Button runat="server" ID="btnSubmit" OnClick="btnSubmit_OnClick" Text="Send"/>
    </div>

<div class="well">
   <asp:GridView runat="server" ID="IndividualsGV" 
                 AutoGenerateColumns="False" 
                 DataSourceID="SqlDataSource1" 
                 AllowPaging="True"
                 AllowSorting="True" 
                 CellPadding="4" 
                 DataKeyNames="Id"
                 ForeColor="#333333"
                 GridLines="None"
                 Height="145px"
                 Width="520px" 
                 >
       <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
       <Columns>
           <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
           <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
           <asp:BoundField DataField="Patronymic" HeaderText="Patronymic" SortExpression="Patronymic"/>
           <asp:BoundField DataField="Iin" HeaderText="Iin" SortExpression="Iin" />
           <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" Visible="False" />
           <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
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

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                       ConnectionString="<%$ ConnectionStrings:DefaultConnection %>"
                       SelectCommand="SELECT [FirstName], [LastName], [Patronymic], [Iin], [Id] FROM [Individuals]"
                       UpdateCommand="Update Individuals SET FirstName=@FirstName,LastName=@LastName, Patronymic=@Patronymic, Iin=@Iin WHERE Id=@id" 
                       DeleteCommand="Delete Individuals where Id=@id">

    </asp:SqlDataSource>
</div>
</form>  

</body>
</html>
