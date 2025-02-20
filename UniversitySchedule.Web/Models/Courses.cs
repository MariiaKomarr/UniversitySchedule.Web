using System.ComponentModel.DataAnnotations;

namespace UniversitySchedule.Web.Models
{
    public class Courses
    {
        public int CourseId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Credits { get; set; }
    }
}
