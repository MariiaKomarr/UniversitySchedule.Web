using System.ComponentModel.DataAnnotations;

namespace UniversitySchedule.Web.Models
{
    public class Faculties
    {
        public int FacultyId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Dean { get; set; }
    }
}
