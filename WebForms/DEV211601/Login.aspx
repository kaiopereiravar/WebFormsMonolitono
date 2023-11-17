<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DEV211601.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login</h1><br />

            <label>Usuario</label><br />
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <asp:Label ID="lbResultadoUsuario" runat="server" Visible="false"></asp:Label><br /> 
            
            <label>Senha</label><br />
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lbResultadoSenha" runat="server" Visible="false"></asp:Label>
            <br /> <br />
            <asp:Button ID="btnLogin" runat="server" Text="Logar" OnClick="btnLogin_Click"/>
            <br /> 
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastre-se" OnClick="btnCadastro_Click"/>
            <br />
        </div>
    </form>
</body>
</html>
