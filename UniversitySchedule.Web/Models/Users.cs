using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversitySchedule.Web.Models
{
    public class Users
    {
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; } // Зберігайте хеш пароля у реальному проекті

        [Required]
        public string Role { get; set; } // Наприклад, "Admin" або "Student"

        public int? TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teachers Teacher { get; set; }

        public int? StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Students Student { get; set; }
    }
}
