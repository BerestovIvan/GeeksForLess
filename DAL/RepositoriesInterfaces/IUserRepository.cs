﻿using DAL.Entity;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;

namespace DAL.RepositoriesInterfaces
{
    public interface IUserRepository
    {
        Task<IdentityResult> Register(ApplicationUser applicationUser);
        Task<IdentityResult> RegisterAdmin(ApplicationUser applicationUser);
        Task<JwtSecurityToken> Login(ApplicationUser applicationUser);
    }
}
