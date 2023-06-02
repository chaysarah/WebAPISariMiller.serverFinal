using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.API.Models;
using MyProject.Common.DTOs;
using MyProject.Services.Interfaces;

namespace MyProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        readonly IChildService _child;

        public ChildController(IChildService child)
        {
            _child = child;
        }

        [HttpGet]
        public async Task<List<ChildDTO>> GetAllAsync()
        {
            return await _child.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ChildDTO> GetAsync(int id)
        {
            return await _child.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<ChildDTO> AddAsync(string firstName,string tz,DateTime d,int idParent )//
        {
            return await _child.AddAsync(firstName,tz,d,idParent);
        }

        [HttpPut("{id}")]
        public async Task<ChildDTO> UpdateAsync(int id, [FromBody] ChildModel r)
        {
            return await _child.UpdateAsync(new ChildDTO { Id = id, FirstName=r.FirstName,Tz=r.Tz,DateOfBirth=r.DateOfBirth,IdUser=r.IdParent});
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _child.DeleteAsync(id);
        }
    }
}
