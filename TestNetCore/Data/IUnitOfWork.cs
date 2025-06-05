using System.Threading.Tasks;

namespace TestNetCore.Data
{
    public interface IUnitOfWork
    {
        IPostRepository Posts { get; }
        Task<int> CompleteAsync();
    }
}
