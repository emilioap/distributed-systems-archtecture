using System;

namespace CE.Core.DomainObjects
{
    public interface IRepository<T>: IDisposable where T : IAggregateRoot
    {

    }
}
