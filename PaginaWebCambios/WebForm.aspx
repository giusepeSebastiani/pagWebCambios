<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="PaginaWebCambios.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lb1" runat="server" Text="Ingrese una cantidad: "></asp:Label> 
            <asp:TextBox ID="tb1" runat="server" Text=""></asp:TextBox>
            <asp:Button ID="btn1" runat="server" Text="Dolares a Soles" OnClick ="das" style="height: 26px" />
            <asp:Button ID="btn2" runat="server" Text="Soles a dolares" OnClick ="sad" style="height: 26px" />          
         </div>
    </form>
</body>
</html>
