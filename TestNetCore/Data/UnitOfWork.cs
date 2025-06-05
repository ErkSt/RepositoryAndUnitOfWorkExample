using System.Threading.Tasks;

namespace TestNetCore.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PostsDbContext _context;
        public IPostRepository Posts { get; }

        public UnitOfWork(PostsDbContext context, IPostRepository postRepository)
        {
            _context = context;
            Posts = postRepository;
        }
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
