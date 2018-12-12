<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Continue.aspx.cs" Inherits="Continue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                                <td align="right">
                                    <asp:Label ID="DoB" runat="server" >Date Of Birth:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox runat="server" ID="dob1" ></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="Label1" runat="server" >First Name:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox runat="server" ID="fname"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="Label2" runat="server" >Last Name:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox runat="server" ID="lname"></asp:TextBox>
                                </td>
                            </tr>
                <tr>
                                <td align="right">
                                    
                                </td>
                                <td>
                                    <asp:Button runat="server" text="Continue" OnClick="Unnamed1_Click"/>
                                </td>
                            </tr>
            </table>
        </div>
    </form>
</body>
</html>
