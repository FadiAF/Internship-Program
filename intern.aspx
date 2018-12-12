<%@ Page Language="C#" AutoEventWireup="true" CodeFile="intern.aspx.cs" Inherits="intern" %>

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
<body style="background-color: grey">
    <div id="topbar" align="center" >
            <div class="container" align="center">
  <div class="row" align="center">
    <div class="col-sm">
      <a href="/index.aspx">Home</a>
    </div><div class="col-sm">
      <a href="Login.aspx">Login</a>
    </div>
  </div>
</div>
        </div>
    <form id="form1" runat="server">
        <div class="container">
        <div class="col-sm"></div>
        <div align="center" class="interns1 col-sm">
            <table runat="server">
                <tr>
                    <td>First Name</td><td><input type="text" id="fn" runat="server"/></td>
                </tr>
                <tr>
                    <td>Last Name</td><td><input type="text" id="ln" runat="server"/></td>
                </tr>
                <tr>
                    <td>DoB</td><td><input type="text" id="ag" runat="server"/></td>
                </tr>
                <tr>
                    <td>Birth Place</td><td><input type="text" id="pob" runat="server"/></td>
                </tr>
                <tr>
                    <td>Email</td><td><input type="text" id="em" runat="server"/></td>
                </tr>
                <tr>
                    <td>Mobile</td><td><input type="text" id="mb" runat="server"/></td>
                </tr>
                <tr>
                    <td>Addresss</td><td><input type="text" id="ad" runat="server"/></td>
                </tr>
                <tr>
                    <td><asp:Button ID="button2" runat="server" Text="Education" OnClick="button2_Click" /></td><td><asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Update" EnableEventValidation="false"  /></td>
                </tr>
            </table>
        </div>
        <div class="col-sm"></div>
        </div>
    </form>
</body>
</html>
