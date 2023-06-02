using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public class ChildDTO
    {

        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string Tz { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        [ForeignKey("User")]
        public int IdUser { get; set; }
        public UserDTO User { get; set; }
    }
}
