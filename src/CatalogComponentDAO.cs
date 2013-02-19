using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Burrow.AppBlock.DAOBases;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace NHibernateAuditLogExample{
    public class CatalogComponentDAO : GenericDAO<CatalogComponent>{
        private static readonly CatalogComponentDAO instance = new CatalogComponentDAO();

        public static CatalogComponentDAO Instance{
            get { return instance; }
        }
    }
}