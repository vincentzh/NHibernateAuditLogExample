using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHibernateAuditLogExample;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        var component = new CatalogComponent() {Name = txtComponentName.Text};
        component.Save();

    }
}