<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Presentacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Inicio de Sesión</h2>
            Usuario: <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox><br/>
            Contraseña: <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox><br/>
            <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" OnClick="btnLogin_Click" /><br/>
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
