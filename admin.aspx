<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>

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
        <form id="form1" runat="server">
            <div id="topbar" align="center" >
            <div class="container" align="center">
  <div class="row" align="center">
    <div class="col-sm">
      <a href="/CreateUser.aspx">Create User</a>
    </div>
    <div class="col-sm">
      <a href="newIntern.aspx">New Intern</a>
    </div><div class="col-sm">
      <a href="Interns.aspx" id="log" runat="server">Interns</a>
    </div>
  </div>
</div>
    <div id="second" align="center">
        <div>
            <table id="users" style="width:100%;" runat="server">
                <tr style="background-color: #808080">
                    <td>username</td>
                    <td>role</td>
                    <td>toggle role</td>
                </tr>
            </table>
        </div>
        </div>
    </form>
</body>
</html>
