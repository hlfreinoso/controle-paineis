<%@ Page Title="" Language="C#" MasterPageFile="~/Sistema/index.Master" AutoEventWireup="true" CodeBehind="LogSistema.aspx.cs" Inherits="ControlePaineis.Interface.Sistema.LogSistema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Home" runat="server">
    <div class="GridView">
        <asp:SqlDataSource
            ID="SqlDataSource1" 
            runat="server" 
            ConnectionString="<%$ ConnectionStrings:Con SQL %>"
            SelectCommand="SELECT * FROM REGISTRO_DETALHADO">
        </asp:SqlDataSource>
        <asp:GridView class="GridViewObj"
            ID="GridView1" 
            runat="server" 
            DataSourceID="SqlDataSource1"
            AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="DISPARO" HeaderText="DISPARO" ReadOnly="True" SortExpression="DISPARO" >
                <HeaderStyle CssClass="GridViewHead" />
                </asp:BoundField>
                <asp:BoundField DataField="PAINEL1" HeaderText="PAINEL1" ReadOnly="True" SortExpression="PAINEL1" >
                <HeaderStyle CssClass="GridViewHead" />
                </asp:BoundField>
                <asp:BoundField DataField="PAINEL2" HeaderText="PAINEL2" ReadOnly="True" SortExpression="PAINEL2" >
                <HeaderStyle CssClass="GridViewHead" />
                </asp:BoundField>
                <asp:BoundField DataField="PAINEL3" HeaderText="PAINEL3" ReadOnly="True" SortExpression="PAINEL3" >
                <HeaderStyle CssClass="GridViewHead" />
                </asp:BoundField>
                <asp:BoundField DataField="PAINEL4" HeaderText="PAINEL4" ReadOnly="True" SortExpression="PAINEL4" >
                <HeaderStyle CssClass="GridViewHead" />
                </asp:BoundField>
                <asp:BoundField DataField="PAINEL5" HeaderText="PAINEL5" ReadOnly="True" SortExpression="PAINEL5" >
                <HeaderStyle CssClass="GridViewHead" />
                </asp:BoundField>
                <asp:BoundField DataField="PAINEL6" HeaderText="PAINEL6" ReadOnly="True" SortExpression="PAINEL6" >
                <HeaderStyle CssClass="GridViewHead" />
                </asp:BoundField>
                <asp:BoundField DataField="PAINEL7" HeaderText="PAINEL7" ReadOnly="True" SortExpression="PAINEL7" >
                <HeaderStyle CssClass="GridViewHead" />
                </asp:BoundField>
                <asp:BoundField DataField="PAINEL8" HeaderText="PAINEL8" ReadOnly="True" SortExpression="PAINEL8" >
                <HeaderStyle CssClass="GridViewHead" />
                </asp:BoundField>
                <asp:BoundField DataField="PAGINA" HeaderText="PAGINA" ReadOnly="True" SortExpression="PAGINA" >
                <HeaderStyle CssClass="GridViewHead" />
                </asp:BoundField>
                <asp:BoundField DataField="DATA" HeaderText="DATA" ReadOnly="True" SortExpression="DATA" >
                <HeaderStyle CssClass="GridViewHead" />
                </asp:BoundField>
                <asp:BoundField DataField="USUARIO" HeaderText="USUARIO" ReadOnly="True" SortExpression="USUARIO" >
                <HeaderStyle CssClass="GridViewHead" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="Rodape" runat="server">
</asp:Content>
