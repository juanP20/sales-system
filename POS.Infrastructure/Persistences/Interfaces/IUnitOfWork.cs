namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        // Declarations  or registrations of samples at the repository level 

        ICategoryRepository Category { get; }

        void SaveChange();
        Task SaveChangeAsync();
    }
}
