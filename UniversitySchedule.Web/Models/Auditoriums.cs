using System.ComponentModel.DataAnnotations;

namespace UniversitySchedule.Web.Models
{
    public class Auditoriums
    {
        public int AuditoriumId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Info { get; set; }
    }
}
