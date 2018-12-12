<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newIntern.aspx.cs" Inherits="newIntern" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="homecss.css">
        <link rel="stylesheet" type="text/css" href="normalize.css">
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
        <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
        <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <title>Internship Program</title>
</head>
<body>
    <div id="topbar" align="center" >
            <div class="container" align="center">
  <div class="row" align="center">
    <div class="col-sm">
      <a href="/index.aspx">Home</a>
    </div><div class="col-sm">
      <a href="Login.aspx" runat="server" id="log">Login</a>
    </div>
  </div>
</div>
        </div>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label runat="server">Photo</asp:Label>
                    </td>
                    <td>
                        <asp:FileUpload runat="server" ID="photo"/>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:Label runat="server">First Name</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="fname" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:Label runat="server">Last Name</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="lname" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:Label runat="server">Email</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:Label runat="server">Phone</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="pn" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:Label runat="server">DoB</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="dob" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:Label runat="server">Birth Place</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="bp" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:Label runat="server">Residence</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="res" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:Label runat="server">ID Card</asp:Label>
                    </td>
                    <td>
                        <asp:FileUpload runat="server" ID="card"/>
                    </td>
                    </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button name="go" Text="Continue" runat="server" OnClick="Unnamed2_Click"/>
                    </td>
                    </tr>
            </table>
        </div>
    </form>
</body>
</html>
