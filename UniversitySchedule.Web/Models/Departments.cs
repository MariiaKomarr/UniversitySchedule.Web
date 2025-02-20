using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversitySchedule.Web.Models
{
    public class Departments
    {
        public int DepartmentId { get; set; }

        [Required]
        public int FacultyId { get; set; }

        [ForeignKey("FacultyId")]
        public Faculties Faculty { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Head { get; set; }
    }
}
