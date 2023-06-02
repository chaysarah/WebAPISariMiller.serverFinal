using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public enum eGenus { Male, Female }
    public enum eHMO { Klalit, Meuchedet,Maccabi,Leumit }

    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eGenus Genus { get; set; }
        public eHMO HMO { get; set; }
    }
}
