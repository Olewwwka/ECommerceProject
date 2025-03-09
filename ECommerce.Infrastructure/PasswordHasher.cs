﻿using ECommerce.Infrastructure.Interfaces;

namespace ECommerce.Infrastructure
{
    public class PasswordHasher : IPasswordHasher
    {
        public string Generate(string password) =>
           BCrypt.Net.BCrypt.HashPassword(password);

        public bool Verify(string password, string passworHash) =>
           BCrypt.Net.BCrypt.Verify(password, passworHash);
    }
}
