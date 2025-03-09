using ECommerce.Infrastructure.Entities;
using ECommerce.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Repositories
{
    public class UsersRepository
    {
        private readonly ECommerceDbContext _context;

        public UsersRepository(ECommerceDbContext context)
        {
            _context = context;
        }

        public async Task Add(UserEntity user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<UserEntity> GetByEmail(string email)
        {
            var userEntity = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Email == email);
            return userEntity;
        }

    }
}
