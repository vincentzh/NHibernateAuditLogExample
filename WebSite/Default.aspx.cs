using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHibernateAuditLogExample;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        FormsAuthentication.SetAuthCookie(txtUserName.Text, false);
        Response.Redirect("Default2.aspx");
    }
}
