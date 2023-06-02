using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IChildService
    {
        Task<List<ChildDTO>> GetAllAsync();

        Task<ChildDTO> GetByIdAsync(int id);

        Task<ChildDTO> AddAsync(string firstNam, string tz, DateTime date, int IdParent);

        Task<ChildDTO> UpdateAsync(ChildDTO child);

        Task DeleteAsync(int id);
    }
}
