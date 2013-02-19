using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Burrow;
using NHibernate.Cfg;
using NHibernate.Envers.Configuration.Attributes;

namespace NHibernateAuditLogExample
{
   public class CustomBurrowConfigurator:IConfigurator
    {
        public void Config(IBurrowConfig val)
        {
        }

        public void Config(IPersistenceUnitCfg puCfg, Configuration nhCfg)
        {
            //var enversConf = new NHibernate.Envers.Configuration.Fluent.FluentConfiguration();
            //enversConf.SetRevisionEntity<CustomRevEntity>(e => e.Id, e => e.Timestamp, typeof(CustomRevInfoListener));
            //enversConf.Audit(GetDomainEntities().Where(e => !typeof(REVINFO).IsAssignableFrom(e)));
            nhCfg.IntegrateWithEnvers(new AttributeConfiguration());
            
        }
    }
}
