using System;

namespace CE.Core.DomainObjects
{
    public abstract class EntityObject
    {
        public Guid Id { get; set; }

        //Comparing two instances of the same class.
        public override bool Equals(object obj)
        {
            var compareTo = obj as EntityObject;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        //Random code generated for each instance of a class.
        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 188) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{GetType().Name} [Id={Id}]";
        }

        public static bool operator ==(EntityObject a, EntityObject b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Equals(b);
        }

        public static bool operator !=(EntityObject a, EntityObject b)
        {
            return !(a == b);
        }
    }
}
