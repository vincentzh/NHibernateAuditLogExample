using MindHarbor.GenClassLib.Data;

namespace NHibernateAuditLogExample
{
    /// <summary>
    ///     Summary description for ECatalogDomainSession.
    /// </summary>
    public class ECatalogDomainSession
    {
        private static readonly SessionData<ECatalogDomainSession> instance = new SessionData<ECatalogDomainSession>();


        /// <summary>
        ///     get the current domainLayer object, that is related to current session
        /// </summary>
        public static ECatalogDomainSession Current
        {
            get
            {
                if (instance.Value == null)
                    instance.Value = ServiceLocator.GetInstanceFromConfig<ECatalogDomainSession>("DomainSessionType",
                                                                                                 typeof (
                                                                                                     ECatalogDomainSession
                                                                                                     ));
                return instance.Value;
            }
        }
        public string UserName { get; set; }
    }
}