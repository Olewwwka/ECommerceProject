using ECommerce.Infrastructure.Entities;

namespace ECommerce.Infrastructure.Interfaces
{
    public interface IUsersRepository
    {
        Task<int> Create(int id, string Login, string PasswordHash, string Email, string FirstName, string LastName);
        Task<int> Delete(int id);
        Task<List<UserEntity>> GetUsers();
        Task<int> Update(int id, string Login, string PasswordHash, string Email, string FirstName, string LastName);
    }
}