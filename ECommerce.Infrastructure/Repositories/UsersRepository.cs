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

        public async Task<int> Delete(int id)
        {
            return await _context.Users.Where(x => x.UserId == id).ExecuteDeleteAsync();
        }

        public async Task<int> Create(int id, string Login, string PasswordHash, string Email, string FirstName, string LastName)
        {
            var userEntity = new UserEntity
            {
                UserId = id,
                Login = Login,
                PasswordHash = PasswordHash,
                Email = Email,
                FirstName = FirstName,
                LastName = LastName
            };

            await _context.Users.AddAsync(userEntity);
            await _context.SaveChangesAsync();

            return userEntity.UserId;
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
