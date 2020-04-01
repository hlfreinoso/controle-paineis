<%@ Page Title="" Language="C#" MasterPageFile="~/Sistema/index.Master" AutoEventWireup="true" CodeBehind="Paineis.aspx.cs" Inherits="ControlePaineis.Interface.Sistema.Paineis" %>
<asp:Content ID="ContentHead" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="ContentHome" ContentPlaceHolderID="Home" runat="server">
    <div class="titulo">Paineis - Aqui você controla a situação de cada painel</div>
        <div class="BtnPainel">
        <asp:Label ID="LabelSts" runat="server" Text="Status"></asp:Label>
        <br />
        <asp:Button ID="ButtonDes" runat="server" OnClick="ButtonDes_Click" CssClass="BtnAlignLD" Text="Desligar Todos" />
        <asp:Button ID="ButtonLig" runat="server" OnClick="ButtonLig_Click" CssClass="BtnAlignLD" Text="Ligar Todos" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Painel 1: "></asp:Label>
        <asp:Label ID="LabelSts1" runat="server"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" CssClass="BtnAlign" Text="Button" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Painel 2: "></asp:Label>
        <asp:Label ID="LabelSts2" runat="server"></asp:Label>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" CssClass="BtnAlign" Text="Button" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Painel 3: "></asp:Label>
        <asp:Label ID="LabelSts3" runat="server"></asp:Label>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" CssClass="BtnAlign" Text="Button" />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Painel 4: "></asp:Label>
        <asp:Label ID="LabelSts4" runat="server"></asp:Label>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" CssClass="BtnAlign" Text="Button" />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Painel 5: "></asp:Label>
        <asp:Label ID="LabelSts5" runat="server"></asp:Label>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" CssClass="BtnAlign" Text="Button" />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Painel 6: "></asp:Label>
        <asp:Label ID="LabelSts6" runat="server"></asp:Label>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" CssClass="BtnAlign" Text="Button" />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Painel 7: "></asp:Label>
        <asp:Label ID="LabelSts7" runat="server"></asp:Label>
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" CssClass="BtnAlign" Text="Button" />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Painel 8: "></asp:Label>
        <asp:Label ID="LabelSts8" runat="server"></asp:Label>
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" CssClass="BtnAlign" Text="Button" />
    </div>
</asp:Content>