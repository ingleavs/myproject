<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Registration Page
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <table>
            <tr>
            
            </tr>
            <tr><td>Password</td><td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
            <tr><td>Retype Password</td><td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td></tr>
            <tr><td>Qualification</td><td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td></tr>
            <tr><td>Age</td><td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td></tr>
            <tr><td>Mobile</td><td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td></tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Register Now" OnClick="Button1_Click" />
                </td>
            </tr>




        </table>
    </div>
    </form>
</body>
</html>
