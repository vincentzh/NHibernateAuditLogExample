using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Envers;
using NHibernate.Envers.Reader;
using NUnit.Framework;

namespace NHibernateAuditLogExample.Test
{
    [TestFixture]
   public class ECatalogUserTest:TestBase
    {
        [Test]
        public void CreateUser()
        {
                var user = new ECatalogUser {Name = "TestName"};
            var catalogComponent = new CatalogComponent() {Name = "TestCatalogComponent"};
            catalogComponent.Descriptions.Add("TestDescription1");
            catalogComponent.Descriptions.Add("TestDescription1");
            user.Components.Add(catalogComponent);
            user.Permissions.Add(Permission.AppAdmin);
            user.Save();
                Framework.CloseWorkSpace();
                Framework.InitWorkSpace();
        

            var user_rev1 = AuditReaderFactory.Get(Framework.GetSession()).Find<ECatalogUser>(user.Id, user.Id);

            Assert.AreEqual(user_rev1, user);

        }
        [Test]
        public void RemoveUser()
        {
            var user = ECatalogUserDAO.Instance.Get(1);
            Assert.IsNotNull(user);
            //user.Components.First().Descriptions.Clear();
            //ECatalogUserDAO.Instance.Delete(user);
           
       
        }
    }
}
