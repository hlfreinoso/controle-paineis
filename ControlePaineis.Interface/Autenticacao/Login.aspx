<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ControlePaineis.Interface.Autenticação.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Controle de Paineis</title>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/style.css" rel="stylesheet" />
    <script type="text/javascript" src="../Scripts/bootstrap.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery-1.9.1.min.js"></script>
</head>
    <body>
        <form id="geral" runat="server">
            <div id="topo">
                <div class="page-header">
                    <h1>Controle Geral de Paineis Eletricos <small>Controle ao alcance</small></h1>
                </div>
            </div>
            <div id="home">
                <div id="login">
                    <div class="form-login">
                        <asp:TextBox ID="TxtUsuario" runat="server" PlaceHolder="usuário"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="TxtSenha" runat="server" TextMode="Password" PlaceHolder="senha"></asp:TextBox>
                        <br />
                        <asp:Button ID="BtnEntrar" text="ENTRAR" runat="server" OnClick="BtnEntrar_Click" CssClass="BtnEntrar" />
                        <asp:Label runat="server" ID="LblStatus" ForeColor="Red"></asp:Label>
                    </div>
                </div>
            </div>
            <div id="rodape">
                <div>Desenvolvido por Heitor Reinoso - Todos os direitos reservados</div>
            </div>
        </form>
    </body>
</html>