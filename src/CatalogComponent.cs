using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using NHibernate.Burrow.AppBlock.EntityBases;
using NHibernate.Envers.Configuration.Attributes;

namespace NHibernateAuditLogExample{
    /// <summary>
    /// Base for Category, GroupOfProduct and IProductSpec, Components that can be assigned to a catalog
    /// </summary>
    [Audited]
    public  class CatalogComponent :PersistantObj<int>
       
    {
        private ICollection<string> _descriptions=new List<string>();
        public string Name { get; set; }
        public ICollection<string> Descriptions
        {
            get { return _descriptions; }
            set { _descriptions = value; }
        }

        public override IComparable BusinessKey
        {
            get { return Id; }
        }

        public override int Id { get; set; }
    }
}