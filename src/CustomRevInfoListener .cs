using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using NHibernate.Envers;

namespace NHibernateAuditLogExample
{
    public class CustomRevInfoListener : IRevisionListener
    {
        public void NewRevision(object revisionEntity)
        {
            
           var username = HttpContext.Current == null ? ECatalogDomainSession.Current.UserName : HttpContext.Current.User.Identity.Name;
            ((CustomRevEntity) revisionEntity).MaintainedBy = username;
        }
    }
}
