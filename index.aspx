<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

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
      <a href="/index.aspx">Home</a>
    </div>><div class="col-sm">
      <a href="Login.aspx" id="log" runat="server">Login</a>
    </div>
  </div>
</div>
                <div id="second" align="center">
        <div class="row">
    <div class="col">
      
    </div>
    <div class="col-6">
        <h1 id="interncount" runat="server"></h1>
        <p><asp:Button ID="toInterns" Text="See the list here" runat="server" OnClick="toInterns_Click"/></p>
    </div>
    <div class="col">
      
    </div>
  </div></div>
    </form>
</body>
</html>
