using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

using System.Web.Security;
using System.Web.UI.WebControls;
using InternshipProgramModel;

public partial class educate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole("admin"))
        {
            Response.Write("<script>alert('You dont have permission')</script>");
            Response.Redirect("./index.aspx");
        }
        InternshipProgramEntities ipe = new InternshipProgramEntities();
        Education c = ipe.Educations.ToList().Where(x => x.InternID == int.Parse(Request.QueryString["id"].ToString())).First();
        User_Details ud = ipe.User_Details.ToList().Where(x => x.Id == c.Supervisor).First();
        Department dpa = ipe.Departments.ToList().Where(x => x.DepID == c.Deptmnt).First();
        sup.InnerHtml = ud.First_Name.ToString()+ud.Last_Name.ToString();
        dp.InnerHtml = dpa.DepName;
        jd.InnerHtml = c.JoinDate.ToString();
        ed.InnerHtml = c.EndDate.ToString();
        mjr.InnerHtml = c.Major.ToString();
        cv.HRef = c.CV;
        dgr.HRef = c.Degree;
        gc.HRef = c.GradCert;
    }
}