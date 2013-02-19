using NHibernate.Burrow.AppBlock.DAOBases;
using NHibernate.Criterion;

namespace NHibernateAuditLogExample{
    public class ECatalogUserDAO : GenericDAO<ECatalogUser>{
        private static readonly ECatalogUserDAO instance = new ECatalogUserDAO();

        public static ECatalogUserDAO Instance{
            get { return instance; }
        }
    }
}