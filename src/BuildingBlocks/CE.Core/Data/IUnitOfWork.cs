using System.Threading.Tasks;

namespace CE.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
