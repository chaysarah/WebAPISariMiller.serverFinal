using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using MyProject.Context;
using MyProject.Repositories;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using MyProject.Services.Services;

namespace MyProject.Services
{
    public static class Extension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddDbContext<IContext, MyDBContext>();
            services.AddRepositories();
            services.AddAutoMapper(typeof(Mapping));
            services.AddScoped<IChildService, ChildService>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}