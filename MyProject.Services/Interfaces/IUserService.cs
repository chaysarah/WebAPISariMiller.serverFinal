using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllAsync();

        Task<UserDTO> GetByIdAsync(int id);

        Task<UserDTO> AddAsync(string firstNam, string lastNam, string tz, DateTime date, eGenusDTO genus, eHMODTO hmo);

        Task<UserDTO> UpdateAsync(UserDTO user);

        Task DeleteAsync(int id);
    }
}
