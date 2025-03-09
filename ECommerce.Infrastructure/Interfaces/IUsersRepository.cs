using ECommerce.Infrastructure.Entities;

namespace ECommerce.Infrastructure.Interfaces
{
    public interface IUsersRepository
    {
        Task AddAsync(UserEntity user);
        Task<UserEntity> GetByEmailAsync(string email);
    }
}