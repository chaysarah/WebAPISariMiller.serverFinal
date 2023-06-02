using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();

        Task<User> GetByIdAsync(int id);

        Task<User> AddAsync(string firstNam, string lastNam,string tz,DateTime date,eGenus genus,eHMO hmo);
        Task<User> UpdateAsync(User user);

        Task DeleteAsync(int id);
    }
}
