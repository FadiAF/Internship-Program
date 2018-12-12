using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using InternshipProgramModel;

public partial class Continue : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Guid newuserid = Guid.Parse(Request.QueryString["userid"].ToString());
        InternshipProgramEntities ipe = new InternshipProgramEntities();
        User_Details us = new User_Details();

        us.First_Name = fname.Text;
        us.Last_Name = lname.Text;
        us.DoB = DateTime.Parse(dob1.Text);
        us.UserID = newuserid;
        ipe.AddToUser_Details(us);
        ipe.SaveChanges();
        Response.Redirect("/index.aspx");
        
    }
}