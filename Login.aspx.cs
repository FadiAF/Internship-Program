using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login_Click(object sender, EventArgs e)
    {
        // Validate the user against the Membership framework user store
        if (Membership.ValidateUser(UserName.Value, Password.Value))
        {
            // Log the user into the site
            FormsAuthentication.RedirectFromLoginPage(UserName.Value, RememberMe.Checked);
        }
        // If we reach here, the user's credentials were invalid
        InvalidCredentialsMessage.Visible = true;
    }
}