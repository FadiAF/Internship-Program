using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using InternshipProgramModel;
using System.Web.Security;

public partial class admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole("admin"))
        {
            Response.Write("<script>alert('You dont have permission')</script>");
            Response.Redirect("./index.aspx");
        }
        else
        {
            InternshipProgramEntities cv = new InternshipProgramEntities();
            var usersList = Membership.GetAllUsers();

            
            foreach (MembershipUser userwee in usersList)
            {
                
                
                    HtmlTableRow row = new HtmlTableRow();
                    HtmlTableCell cell1 = new HtmlTableCell();
                    cell1.InnerHtml = userwee.ToString();
                    row.Cells.Add(cell1);
                    HtmlTableCell cell2 = new HtmlTableCell();
                    string[] roles = Roles.GetRolesForUser(userwee.UserName);

                    foreach (string role in roles)
                    {
                        cell2.InnerHtml += role;
                    }
                    row.Cells.Add(cell2);
                    HtmlTableCell cell3 = new HtmlTableCell();
                    Button button = new Button();
                    button.Text = "Toggle Role";
                    button.ID = userwee.UserName.ToString();
                    button.Click += Button1_Click;
                    cell3.Controls.Add(button);
                    row.Cells.Add(cell3);
                    users.Rows.Add(row);
                
            }
            /* HtmlTableRow row = new HtmlTableRow();
            HtmlTableCell cell1 = new HtmlTableCell();
            cell1.InnerHtml = "blah blah blah";
            row.Cells.Add(cell1);
            users.Rows.Add(row);*/
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string username = button.ID;
        string[] roles = Roles.GetRolesForUser(username);
        if (roles.Length > 0)
        {
            if (roles[0] == "admin")
        {
            Roles.AddUserToRole(username, "employee");
            Roles.RemoveUserFromRole(username, "admin");
        }
        else if(roles[0] == "employee")
            {
            Roles.AddUserToRole(username, "admin");
            Roles.RemoveUserFromRole(username, "employee");
        }
        }
        else
            Roles.AddUserToRole(username, "employee");
        Response.Redirect("./admin.aspx");

    }
}