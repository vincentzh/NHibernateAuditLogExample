using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MindHarbor.GenClassLib.Configuration;
using MindHarbor.SingletonUtil;

namespace NHibernateAuditLogExample
{
    public class ServiceLocator
    {

        public static T GetInstanceFromConfig<T>(string key, Type defaultType)
        {
            Type t = defaultType;
            string tn = ConfigurationManager.GetSetting(key, string.Empty);
            if (!string.IsNullOrEmpty(tn))
                t = Type.GetType(tn);
            if (t == null)
                throw new Exception("Cannot find type \"" + tn + "\" as " + key +
                                                 ", please check configuration file");
            return (T)SingletonInstanceLoader.Load(t);
        }
        public static ServiceLocator GetInstance()
        {
            return GetInstanceFromConfig<ServiceLocator>("ServiceLocatorType", typeof(ServiceLocator));
        }
    }
}
