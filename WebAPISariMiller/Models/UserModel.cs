public enum eGenusModel { Male, Female }
public enum eHMOModel { Klalit, Meuchedet, Maccabi, Leumit }

namespace MyProject.API.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eGenusModel Genus { get; set; }
        public eHMOModel HMO { get; set; }
    }

   
}
