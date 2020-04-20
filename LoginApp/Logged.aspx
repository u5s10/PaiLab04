<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logged.aspx.cs" Inherits="LoginApp.Logged" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Logged</h1>
            <asp:Button ID="Button1" runat="server" Text="Log out" OnClick="Button1_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
