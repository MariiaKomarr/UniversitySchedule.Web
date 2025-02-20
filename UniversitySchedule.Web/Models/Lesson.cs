using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace UniversitySchedule.Web.Models
{
    public class Lesson
    {
        public int LessonId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        public Courses Course { get; set; }

        [Required]
        public int TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        public Teachers Teacher { get; set; }

        [Required]
        public int AuditoriumId { get; set; }

        [ForeignKey("AuditoriumId")]
        public Auditoriums Auditorium { get; set; }

        [Required]
        public int GroupId { get; set; }

        [ForeignKey("GroupId")]
        public Group Group { get; set; }

        [Required]
        public string DayOfWeek { get; set; } // Наприклад: "Понеділок"

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }
    }
}
