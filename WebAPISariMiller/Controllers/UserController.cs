using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.API.Models;
using MyProject.Common.DTOs;
using MyProject.Services.Interfaces;

namespace MyProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IUserService _users;

        public UserController(IUserService users)
        {
            _users = users;
        }

        [HttpGet]
        public async Task<List<UserDTO>> GetAllAsync()
        {
            return await _users.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<UserDTO> GetAsync(int id)
        {
            return await _users.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<UserDTO> AddAsync(string firstN, string lastN,string tz,DateTime d,eGenusModel genus,eHMOModel hmo)//[FromBody] RoleModel r
        {
            return await _users.AddAsync(firstN, lastN,tz,d, (eGenusDTO)genus, (eHMODTO)hmo);
        }

        [HttpPut("{id}")]
        public async Task<UserDTO> UpdateAsync(int id, [FromBody] UserModel r)
        {
            return await _users.UpdateAsync(new UserDTO { Id = id,FirstName=r.FirstName,LastName=r.LastName,Tz=r.Tz,DateOfBirth=r.DateOfBirth,Genus= (eGenusDTO)r.Genus,HMO= (eHMODTO)r.HMO});
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _users.DeleteAsync(id);
        }
    }
}
