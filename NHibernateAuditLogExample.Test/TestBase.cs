using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Burrow;
using NHibernate.Burrow.Util;
using NHibernate.Cfg;
using NHibernate.Envers.Configuration.Attributes;
using NUnit;
using NUnit.Framework;
namespace NHibernateAuditLogExample.Test
{
    
    public abstract class TestBase

    {
        protected BurrowFramework Framework=new BurrowFramework();
        [SetUp]
        public virtual void Setup()
        {
          Framework.InitWorkSpace();
        }
        [TestFixtureSetUp]
        public virtual void FixtureSetup()
        {
        }
        [TearDown]
        public virtual void TearDown()
        {
            Framework.CloseWorkSpace();
        }
        [TestFixtureTearDown]
        public virtual void FixtureTearDown()
        {
        }
       
    }
}
