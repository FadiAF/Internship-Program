using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InternshipProgramModel;
using System.Web.Security;

public partial class intern : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*if (!Roles.IsUserInRole("admin"))
        {
            Response.Write("<script>alert('You dont have permission')</script>");
        }*/
        {
            InternshipProgramEntities ipe = new InternshipProgramEntities();
            Intern1 c = ipe.Intern1.ToList().Where(x => x.ID == int.Parse(Request.QueryString["id"].ToString())).First();
            fn.Value = c.FirstName.ToString();
            ln.Value = c.LastName.ToString();
            ag.Value = DateTime.Parse(c.dob.ToString()).ToString("yyyy-MM-dd");
            pob.Value = c.placeofbirth.ToString();
            em.Value = c.Email.ToString();
            mb.Value = c.Mobile.ToString();
            ad.Value = c.adress.ToString();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        InternshipProgramEntities ipe = new InternshipProgramEntities();
        Intern1 c = ipe.Intern1.ToList().Where(x => x.ID == int.Parse(Request.QueryString["id"].ToString())).First();
        c.FirstName = fn.Value;
        c.LastName = ln.Value;
        c.dob = DateTime.Parse(ag.Value);
        c.photo = c.photo;
        c.identitycard = c.identitycard;
        c.placeofbirth = pob.Value;
        c.Email = em.Value;
        c.Mobile = int.Parse(mb.Value);
        c.adress = ad.Value;
        ipe.SaveChanges();
    }

    protected void button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("/addEducation.aspx?id="+ Request.QueryString["id"].ToString());
    }
}