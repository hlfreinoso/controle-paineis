<%@ Page Title="" Language="C#" MasterPageFile="~/Sistema/index.Master" AutoEventWireup="true" CodeBehind="Sensores.aspx.cs" Inherits="ControlePaineis.Interface.Sistema.Sensores" %>

<asp:Content ID="ContentHome" ContentPlaceHolderID="Home" runat="server">
    <div class="titulo">Sensores - Aqui você vizualiza a situação de cada sensor</div>
    <div class="BtnPainel">
        <asp:Label ID="LabelSts" runat="server" Text="Status"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Temperatura: " ></asp:Label>
    </div>
</asp:Content>