<%@ Page Language="C#" AutoEventWireup="true" CodeFile="educate.aspx.cs" Inherits="educate" %>

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
        <div align="center" runat="server">
            <table runat="server" style="border: 5px">
                <tr>
                    <td>Supervisor:</td><td> <p name="cars" id="sup" runat="server">
</p> </td>
                </tr>
                <tr>
                    <td>Department:</td><td runat="server"><p name="cars" id="dp" runat="server">
</p></td>
                </tr>
                <tr>
                    <td>JoinDate:</td><td><p type="text" id="jd" runat="server"></p></td>
                </tr>
                <tr>
                    <td>EndDate:</td><td><p type="text" id="ed" runat="server"></p></td>
                </tr>
                <tr>
                    <td>Major:</td><td><p type="text" id="mjr" runat="server"></p></td>
                </tr>
                <tr>
                    <td>CV:</td><td><a href="" runat="server" ID="cv" download>Download Here</a></td>
                </tr>
                <tr>
                    <td>Degree:</td><td><a href="" runat="server" ID="dgr" download>Download Here</a></td>
                </tr>
                <tr>
                    <td>GradCert:</td><td><a href="" runat="server" ID="gc" download>Download Here</a></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
