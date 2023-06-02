using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IChildRepository
    {
        Task<List<Child>> GetAllAsync();

        Task<Child> GetByIdAsync(int id);

        Task<Child> AddAsync(string firstNam, string tz, DateTime date,int parentId);
        Task<Child> UpdateAsync(Child child);

        Task DeleteAsync(int id);
    }
}
