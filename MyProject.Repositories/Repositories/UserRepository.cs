using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class UserRepository:IUserRepository
    {
        readonly IContext _context;

        public UserRepository(IContext context)
        {
            _context = context;
        }

        public async Task<User> AddAsync(string firstNam, string lastNam, string tz, DateTime date, eGenus genus, eHMO hmo)
        {
            User temp = new User {  FirstName=firstNam, LastName= lastNam, Tz= tz, DateOfBirth= date, Genus= genus, HMO= hmo };
            var t = _context.Users.Add(temp);
            await _context.SaveChangesAsync();
            return t.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Users.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User user)
        {
            var t = _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return t.Entity;
        }
    }
}
