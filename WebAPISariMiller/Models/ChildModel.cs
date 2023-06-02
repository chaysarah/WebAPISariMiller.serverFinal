using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.API.Models
{
    public class ChildModel
    {
        public string FirstName { get; set; }
        public string Tz { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int IdParent { get; set; }
    }
}
