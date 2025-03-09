using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public User(int id, string login, string passwordHash, string email, string firstname, string lastname)
        {
            UserId = id;
            Login = login;
            PasswordHash = passwordHash;
            Email = email;
            FirstName = firstname;
            LastName = lastname;
        }

        public static User Create(int id, string login, string passwordHash, string email, string firstname, string lastname)
        {
            return new User(id, login, passwordHash, email, firstname, lastname);
        }
    }
}
