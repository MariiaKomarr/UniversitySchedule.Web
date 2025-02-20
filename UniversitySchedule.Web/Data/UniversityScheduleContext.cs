using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UniversitySchedule.Web.Models;


namespace UniversitySchedule.Web.Data
{
    public class UniversityScheduleContext : DbContext
    {
        public UniversityScheduleContext(DbContextOptions<UniversityScheduleContext> options)
            : base(options)
        {
        }

        public DbSet<Faculties> Faculties { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Auditoriums> Auditoriums { get; set; }
        public DbSet<Curriculum> Curriculums { get; set; }
    }
}
