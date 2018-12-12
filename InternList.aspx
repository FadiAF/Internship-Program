<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InternList.aspx.cs" Inherits="InternList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display.">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="photo" HeaderText="photo" SortExpression="photo" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="dob" HeaderText="dob" SortExpression="dob" />
                    <asp:BoundField DataField="placeofbirth" HeaderText="placeofbirth" SortExpression="placeofbirth" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="Mobile" HeaderText="Mobile" SortExpression="Mobile" />
                    <asp:BoundField DataField="adress" HeaderText="adress" SortExpression="adress" />
                    <asp:BoundField DataField="identitycard" HeaderText="identitycard" SortExpression="identitycard" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connection1 %>" DeleteCommand="DELETE FROM [Intern] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Intern] ([LastName], [photo], [FirstName], [dob], [placeofbirth], [Email], [Mobile], [adress], [identitycard]) VALUES (@LastName, @photo, @FirstName, @dob, @placeofbirth, @Email, @Mobile, @adress, @identitycard)" ProviderName="<%$ ConnectionStrings:Connection1.ProviderName %>" SelectCommand="SELECT [ID], [LastName], [photo], [FirstName], [dob], [placeofbirth], [Email], [Mobile], [adress], [identitycard] FROM [Intern]" UpdateCommand="UPDATE [Intern] SET [LastName] = @LastName, [photo] = @photo, [FirstName] = @FirstName, [dob] = @dob, [placeofbirth] = @placeofbirth, [Email] = @Email, [Mobile] = @Mobile, [adress] = @adress, [identitycard] = @identitycard WHERE [ID] = @ID">
                <DeleteParameters>
                    <asp:Parameter Name="ID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="LastName" Type="String" />
                    <asp:Parameter Name="photo" Type="String" />
                    <asp:Parameter Name="FirstName" Type="String" />
                    <asp:Parameter DbType="Date" Name="dob" />
                    <asp:Parameter Name="placeofbirth" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="Mobile" Type="Int32" />
                    <asp:Parameter Name="adress" Type="String" />
                    <asp:Parameter Name="identitycard" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="LastName" Type="String" />
                    <asp:Parameter Name="photo" Type="String" />
                    <asp:Parameter Name="FirstName" Type="String" />
                    <asp:Parameter DbType="Date" Name="dob" />
                    <asp:Parameter Name="placeofbirth" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="Mobile" Type="Int32" />
                    <asp:Parameter Name="adress" Type="String" />
                    <asp:Parameter Name="identitycard" Type="String" />
                    <asp:Parameter Name="ID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
