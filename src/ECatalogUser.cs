using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Iesi.Collections.Generic;
using NHibernate.Burrow.AppBlock.EntityBases;
using NHibernate.Envers.Configuration.Attributes;

namespace NHibernateAuditLogExample {
    [Audited]
    public class ECatalogUser : PersistantObj<int>{
        private ICollection<CatalogComponent> components=new Collection<CatalogComponent>();
        private Iesi.Collections.Generic.ISet<Permission> permissions = new HashedSet<Permission>();
        public override IComparable BusinessKey
        {
            get { return Id; }
        }
        public string Name { get; set; }
        public override int Id { get; set; }
        public ICollection<CatalogComponent> Components {
            get { return components; }
            set { components = value; } }
        public Iesi.Collections.Generic.ISet<Permission> Permissions
        {
            get { return permissions; }
        }
    }
}