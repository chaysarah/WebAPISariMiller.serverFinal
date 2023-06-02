using System.Collections.Generic;
using System.Data;
using System.Security.Claims;
using System.Security;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyProject.Context
{
    public class MyDBContext : DbContext, IContext
    {
        public DbSet<Child> Children { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebAPISariMillerDb;Trusted_Connection=True;");
    }
}