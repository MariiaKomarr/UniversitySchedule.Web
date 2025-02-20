using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversitySchedule.Web.Models
{
    public class Curriculum
    {
        public int CurriculumId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        public Courses Course { get; set; }

        [Required]
        public int Semester { get; set; }

        [Required]
        public int Year { get; set; }
    }
}
