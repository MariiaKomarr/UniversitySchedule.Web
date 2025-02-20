using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversitySchedule.Web.Models
{
    public class Groups
    {
        public int GroupId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int FacultyId { get; set; }

        [ForeignKey("FacultyId")]
        public Faculties Faculty { get; set; }
    }
}
