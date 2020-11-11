<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DropDownColorChange.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList runat="server" ID="ddlAvailability3" AutoPostBack="true"
                OnSelectedIndexChanged="ddlAvailability_OnSelectedIndexChanged"
                CssClass="dropdowns">
                <asp:ListItem ID="LT3"></asp:ListItem>
                <asp:ListItem ID="RT3"></asp:ListItem>
            </asp:DropDownList>
    </form>
</body>
</html>
