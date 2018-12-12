using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using InternshipProgramModel;

public partial class CreateUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole("admin"))
        {
            Response.Write("<script>alert('You dont have permission')</script>");
            Response.Redirect("./index.aspx");
        }
        var test = CreateUserWizard1.FindControl("dateselect") as Calendar;
        
    }

    protected void CreateUserWizard1_CreatedUser1(object sender, EventArgs e)
    {
        MembershipUser newUser = Membership.GetUser(CreateUserWizard1.UserName);
        Guid newUserID = (Guid)newUser.ProviderUserKey;

        TextBox dob1 = (TextBox)CreateUserWizard1.FindControl("dob1");
        TextBox fnam = (TextBox)CreateUserWizard1.FindControl("fname");
        TextBox lname = (TextBox)CreateUserWizard1.FindControl("lname");

        InternshipProgramEntities ipm = new InternshipProgramEntities();
        User_Details newUserDets = new User_Details();

        Response.Redirect("./continue.aspx?userid=" + newUserID);
        /*newUserDets.DoB = Convert.ToDateTime("1996-1-1");
        newUserDets.First_Name = fnam.Text;
        newUserDets.Last_Name = lname.Text;
        System.Diagnostics.Debug.WriteLine(newUserID);
        newUserDets.UserID = newUserID;
        ipm.User_Details.Add(newUserDets);
        ipm.SaveChanges();
        //Response.Write("<script>alert('" + newUserID.ToString() + "')</script>");
        Response.Write("<script>alert('hi')</script>");*/

    }

    protected void ContinueButton_Click(object sender, EventArgs e)
    {
        MembershipUser newUser = Membership.GetUser(CreateUserWizard1.UserName);
        Guid newUserID = (Guid)newUser.ProviderUserKey;
        
    }

   
}