<%@ Page Title="" Language="C#" MasterPageFile="~/Sistema/index.Master" AutoEventWireup="true" CodeBehind="CadMedida.aspx.cs" Inherits="ControlePaineis.Interface.Sistema.CadMedida" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Home" runat="server">
    <div class="ImgMap">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="MEDI" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="MEDI" HeaderText="DESCRIÇÃO DA MEDIDA" ReadOnly="True" SortExpression="MEDI" />
                <asp:BoundField DataField="SIMB" HeaderText="ABREVIAÇÃO" SortExpression="SIMB" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Con SQL %>" DeleteCommand="DELETE FROM [DBMEDIDA] WHERE [MEDI] = @MEDI" InsertCommand="INSERT INTO [DBMEDIDA] ([MEDI], [SIMB]) VALUES (@MEDI, @SIMB)" ProviderName="<%$ ConnectionStrings:Con SQL.ProviderName %>" SelectCommand="SELECT [MEDI], [SIMB] FROM [DBMEDIDA]" UpdateCommand="UPDATE [DBMEDIDA] SET [SIMB] = @SIMB WHERE [MEDI] = @MEDI">
        </asp:SqlDataSource>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Rodape" runat="server">
</asp:Content>
