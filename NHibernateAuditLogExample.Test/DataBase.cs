using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Burrow.Util;
using NUnit.Framework;

namespace NHibernateAuditLogExample.Test
{
    [TestFixture]
    public class DataBase
    {
        [Test, Explicit]
        public void CreateDB()
        {
            new SchemaUtil().CreateSchemas();
        }
    }
}
