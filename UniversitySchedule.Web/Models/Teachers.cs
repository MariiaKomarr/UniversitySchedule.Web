using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversitySchedule.Web.Models
{
    public class Teachers
    {
        public int TeacherId { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Departments Department { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string AcademicDegree { get; set; }  // наприклад: "PhD", "MSc" тощо

        [Required]
        public string Position { get; set; } // наприклад: "Професор", "Доцент", "Лектор
    }
}
