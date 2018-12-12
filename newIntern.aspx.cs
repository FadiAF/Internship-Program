using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using InternshipProgramModel;

public partial class newIntern : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole("admin"))
        {
            Response.Write("<script>alert('You dont have permission')</script>");
            Response.Redirect("./index.aspx");
        }
    }

    protected void Unnamed2_Click(object sender, EventArgs e)
    {
        InternshipProgramEntities ipe = new InternshipProgramEntities();
        Intern1 inte = new Intern1();

        HttpPostedFile f = Request.Files["photo"];
        string fpath = System.IO.Path.GetFileName(f.FileName);
        f.SaveAs(Server.MapPath(System.IO.Path.Combine("~/images/", fpath)));
        HttpPostedFile a = Request.Files["card"];
        string apath = System.IO.Path.GetFileName(a.FileName);
        a.SaveAs(Server.MapPath(System.IO.Path.Combine("~/App_Data/", apath)));

        inte.adress = res.Text;
        inte.dob = DateTime.Parse(dob.Text);
        inte.Email = email.Text;
        inte.FirstName = fname.Text;
        inte.LastName = lname.Text;
        inte.photo = "/images/" + fpath;
        inte.Mobile = int.Parse(pn.Text);
        inte.placeofbirth = bp.Text;
        inte.identitycard = "/App_data/" + apath;
        ipe.AddToIntern1(inte);
        ipe.SaveChanges();

    }
}