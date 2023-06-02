using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public enum eGenusDTO { Male, Female }
    public enum eHMODTO { Klalit, Meuchedet, Maccabi, Leumit }
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eGenusDTO Genus { get; set; }
        public eHMODTO HMO { get; set; }
    }
}
