using ECommerce.Infrastructure.Entities;
using ECommerce.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ECommerceDbContext _context;

        public UsersRepository(ECommerceDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserEntity>> GetUsers()
        {
            var users = await _context.Users
                .AsNoTracking().ToListAsync();
            return users;
        }
        public async Task<UserEntity?> GetByIdAsync(int userId)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.UserId == userId);
        }


        public async Task<int> Delete(int id)
        {
            return await _context.Users.Where(x => x.UserId == id).ExecuteDeleteAsync();
        }

        public async Task<int> Create(UserEntity user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user.UserId;
        }

        public async Task<int> Update(int id, string Login, string PasswordHash, string Email, string FirstName, string LastName)
        {
            await _context.Users
                .Where(x => x.UserId == id)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(b => b.Login, b => Login)
                    .SetProperty(b => b.Email, b => Email)
                    .SetProperty(b => b.FirstName, b => FirstName)
                    .SetProperty(b => b.LastName, b => LastName)
                    .SetProperty(b => b.PasswordHash, b => PasswordHash));
            return id;
        }
    }
}
