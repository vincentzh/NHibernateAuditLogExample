using NHibernate.Envers.Configuration.Attributes;

namespace NHibernateAuditLogExample
{
    [RevisionEntity(typeof(CustomRevInfoListener))]
    public class CustomRevEntity
    {
        [RevisionNumber]
        public virtual long Id { get; set; }

        [RevisionTimestamp]
        public virtual long Timestamp { get; set; }

        public virtual string MaintainedBy { get; set; }

        protected bool Equals(CustomRevEntity other)
        {
            return Id == other.Id && string.Equals(MaintainedBy, other.MaintainedBy) && Timestamp == other.Timestamp;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CustomRevEntity) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Id.GetHashCode();
                hashCode = (hashCode*397) ^ (MaintainedBy != null ? MaintainedBy.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ Timestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}