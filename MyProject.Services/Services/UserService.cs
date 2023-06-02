using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _user;
        private readonly IMapper _mapper;

        public UserService(IUserRepository user, IMapper mapper)
        {
            _user = user;
            _mapper = mapper;
        }

        public async Task<UserDTO> AddAsync(string firstNam, string lastNam, string tz, DateTime date, eGenusDTO genus, eHMODTO hmo)
        {
            await _user.AddAsync( firstNam,  lastNam, tz, date, (eGenus)genus, (eHMO)hmo);
            return new UserDTO { FirstName= firstNam, LastName= lastNam, Tz= tz, DateOfBirth=date, Genus= genus, HMO=hmo };
        }

        public async Task DeleteAsync(int id)
        {
            await _user.DeleteAsync(id);
        }

        public async Task<List<UserDTO>> GetAllAsync()
        {
            return _mapper.Map<List<UserDTO>>(await _user.GetAllAsync());
        }

        public async Task<UserDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<UserDTO>(await _user.GetByIdAsync(id));
        }

        public async Task<UserDTO> UpdateAsync(UserDTO user)
        {
            return _mapper.Map<UserDTO>(await _user.UpdateAsync(_mapper.Map<User>(user)));
        }
    }
}
