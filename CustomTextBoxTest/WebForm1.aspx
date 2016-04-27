<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<%@ Register assembly="CustomTextBox" namespace="CustomTextBox" tagprefix="asp" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:CustomTextBox ID="CustomTextBox1" xText="Test String From Front-Side!" runat="server"></asp:CustomTextBox>
    </form>
</body>
</html>
