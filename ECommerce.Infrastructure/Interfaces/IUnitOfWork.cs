namespace ECommerce.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        IUsersRepository UsersRepository { get; }
        void Dispose();
        Task<int> SaveChangesAsync();
    }
}