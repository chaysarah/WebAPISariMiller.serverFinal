using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class ChildRepository:IChildRepository
    {
        readonly IContext _context;

        public ChildRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Child> AddAsync(string firstNam, string tz, DateTime date,int par)
        {
            Child temp = new Child { FirstName = firstNam, Tz = tz, DateOfBirth = date,IdUser=par };
            var t = _context.Children.Add(temp);
            await _context.SaveChangesAsync();
            return t.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Children.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.Include(p=>p.User).ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            return await _context.Children.Include(p=>p.User).FirstOrDefaultAsync(p=>p.Id==id);
        }

        public async Task<Child> UpdateAsync(Child child)
        {
            var t = _context.Children.Update(child);
            await _context.SaveChangesAsync();
            return t.Entity;
        }
    }
}
