using ECommerce.Core.Models;

namespace ECommerce.Application
{
    public interface IJwtProvider
    {
        string GenerateToken(User user);
    }
}