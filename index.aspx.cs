using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using InternshipProgramModel;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        InternshipProgramEntities ipe = new InternshipProgramEntities();
        var i = ipe.Intern1.ToList();
        interncount.InnerHtml = "We have "+i.Count+" total interns";

        if (Roles.IsUserInRole("admin"))
        {
            log.InnerHtml = "Admin Panel";
            log.HRef = "/admin.aspx";
        }
    }

    protected void toInterns_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Interns.aspx");
    }
}