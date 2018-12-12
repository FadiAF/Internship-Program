using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Security;
using InternshipProgramModel;

public partial class addEducation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole("admin"))
        {
            Response.Write("<script>alert('You dont have permission')</script>");
            Response.Redirect("./index.aspx");
        }
        InternshipProgramEntities ipe = new InternshipProgramEntities();
        Education c = ipe.Educations.ToList().Where(x => x.InternID == int.Parse(Request.QueryString["id"].ToString())).FirstOrDefault();
        if (c != null)
        {
            Response.Redirect("/educate.aspx?id=" + Request.QueryString["id"]);
        }
        var users = ipe.User_Details;
        foreach(User_Details user in users)
        {
            sup.Items.Add(new ListItem(user.First_Name.ToString()+" " + user.Last_Name.ToString(), user.Id.ToString()));
        }
        var deps = ipe.Departments;
        foreach(Department dep in deps)
        {
            dp.Items.Add(new ListItem(dep.DepName.ToString(), dep.DepID.ToString()));
        }
    }

    protected void button2_Click(object sender, EventArgs e)
    {
        InternshipProgramEntities ipe = new InternshipProgramEntities();
        Education us = new Education();

        us.InternID = int.Parse(Request.QueryString["id"]);
        us.Supervisor = int.Parse(sup.Value);
        us.Deptmnt = int.Parse(dp.Value);
        us.JoinDate = DateTime.Parse(jd.Value);
        if (us.EndDate != null)
            us.EndDate = DateTime.Parse(ed.Value);
        us.Major = mjr.Value;
        HttpPostedFile f = Request.Files["cv"];
        string fpath = System.IO.Path.GetFileName(f.FileName);
        f.SaveAs(Server.MapPath(System.IO.Path.Combine("~/CVs/", fpath)));
        HttpPostedFile a = Request.Files["dgr"];
        string apath = System.IO.Path.GetFileName(f.FileName);
        a.SaveAs(Server.MapPath(System.IO.Path.Combine("~/Degrees/", apath)));
        HttpPostedFile c = Request.Files["gc"];
        string cpath = System.IO.Path.GetFileName(f.FileName);
        c.SaveAs(Server.MapPath(System.IO.Path.Combine("~/GradCerts/", cpath)));
        us.CV = "/CVs/"+fpath;
        us.Degree = "/Degrees/" + apath;
        us.GradCert = "/GradCerts/" + cpath;
        ipe.AddToEducations(us);
        ipe.SaveChanges();
        Response.Redirect("/index.aspx");
    }
}