<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

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
            <table runat="server">
                <tr>
                    <td>
                        <h1>
                            Login
                        </h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        Username:
                    </td>
                    <td>
                        <input type="text" id="UserName" placeholder="Username" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        Password:
                    </td>
                    <td>
                        <input type="password" id="Password" placeholder="password" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        Remember Login
                    </td>
                    <td>
                        <input type="checkbox" id="RememberMe" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <p id="InvalidCredentialsMessage" runat="server" visible="false">Incorrect Credentials</p>
                    </td>
                    <td>
                        <asp:Button runat="server" Text="Login" OnClick="Login_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
