using System;
using MindHarbor.ClassEnum;

namespace NHibernateAuditLogExample
{
    [Serializable]
    public class Permission : ClassEnumGeneric<Permission>
    {
        public static readonly Permission AppAdmin = new Permission("Application Administration");
        public static readonly Permission CatalogAdmin = new Permission("Catalog Administration");

        protected Permission(string name) : base(name)
        {
        }
    }

    public class PermissionUserType : ClassEnumUserType<Permission>
    {
    }
}
