using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;


namespace UniversitySchedule.Web.Models
{
    public class Students
    {
        public int StudentId { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public int GroupId { get; set; }

        [ForeignKey("GroupId")]
        public Groups Group { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        public double SuccessRate { get; set; }  // наприклад: середній бал або рейтинг
    }
}
