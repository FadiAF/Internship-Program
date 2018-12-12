<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addEducation.aspx.cs" Inherits="addEducation" %>

<!DOCTYPE html>

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
        <div align="center">
            <table runat="server">
                <tr>
                    <td>Supervisor</td><td> <select name="cars" id="sup" runat="server">
</select> </td>
                </tr>
                <tr>
                    <td>Department</td><td><select name="cars" id="dp" runat="server">
</select></td>
                </tr>
                <tr>
                    <td>JoinDate</td><td><input type="text" id="jd" runat="server"/></td>
                </tr>
                <tr>
                    <td>EndDate</td><td><input type="text" id="ed" runat="server"/></td>
                </tr>
                <tr>
                    <td>Major</td><td><input type="text" id="mjr" runat="server"/></td>
                </tr>
                <tr>
                    <td>CV</td><td><asp:FileUpload runat="server" ID="cv"/></td>
                </tr>
                <tr>
                    <td>Degree</td><td><asp:FileUpload runat="server" ID="dgr"/></td>
                </tr>
                <tr>
                    <td>GradCert</td><td><asp:FileUpload runat="server" ID="gc"/></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="button2" runat="server" Text="Submit" OnClick="button2_Click" /></td>

                </tr>
            </table>
        </div>
    </form>
</body>
</html>
