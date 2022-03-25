using BLL.ServiceInterfaces;
using BLL.Services;
using DAL.Repositories;
using DAL.RepositoriesInterfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksForLess.DependencyInjection
{
    public static class DI
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
