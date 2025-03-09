using ECommerce.Infrastructure.Entities;

namespace ECommerce.Infrastructure.Interfaces
{
    public interface IUsersRepository
    {
        Task Add(UserEntity user);
        Task<UserEntity> GetByEmail(string email);
    }
}