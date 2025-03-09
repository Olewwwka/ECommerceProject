using ECommerce.Infrastructure.Interfaces;

namespace ECommerce.Infrastructure
{
    public class PasswordHasher : IPasswordHasher
    {
        public string Generate(string password) =>
           BCrypt.Net.BCrypt.EnhancedHashPassword(password);

        public bool Verify(string password, string passworHash) =>
           BCrypt.Net.BCrypt.EnhancedVerify(password, passworHash);
    }
}
