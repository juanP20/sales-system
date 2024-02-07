using POS.Infrastructure.Persistences.Contexts;
using POS.Infrastructure.Persistences.Interfaces;

namespace POS.Infrastructure.Persistences.Repositories
{
    public class UniOfWork : IUnitOfWork
    {
        private readonly PosContext _context;

        public ICategoryRepository Category { get; private set; }
        public UniOfWork(PosContext context)
        { 
            _context = context;
            Category = new CategoryRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose(); 
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
