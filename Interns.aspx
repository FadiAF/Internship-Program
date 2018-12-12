<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Interns.aspx.cs" Inherits="Interns" %>

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
    </div>><div class="col-sm">
      <a href="Login.aspx" runat="server" id="log">Login</a>
    </div>
  </div>
</div>
        </div>
    <form id="form1" runat="server">
        <div id="search" runat="server">
            <asp:TextBox ID="srch" runat="server"></asp:TextBox> 
            <asp:Button ID="Go_Search" runat="server" Text="Search" OnClick="Go_Search_Click" />
            
            <asp:DropDownList ID="ddl" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl_SelectedIndexChanged">

                <asp:ListItem id="none" runat="server" Text="none" Value="" Enabled="true"></asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="still" runat="server" Text="Still Interning" OnClick="still_Click"/>
        </div>
        <div id="interns" runat="server" style="width: 100%">
           <!---<table runat="server" style="width:100%;" id="gone">
                <tr>
                    <td>Photo</td>
                    <td>Name</td>
                    <td>Phone</td>
                    <td>Email</td>
                    <td>Delete</td>
                </tr>

            </table>-->
        </div>
         <div>
        <asp:Button ID="save" runat="server" Text="Save To PDF" OnClick="save_Click" />
    </div>
    </form>
   
</body>
</html>
