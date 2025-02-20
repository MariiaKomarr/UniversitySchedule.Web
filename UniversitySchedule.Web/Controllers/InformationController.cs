using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversitySchedule.Web.Data;
using System.Threading.Tasks;
using UniversitySchedule.Web.Models;

namespace UniversitySchedule.Web.Controllers
{
    public class InformationController : Controller
    {
        private readonly UniversityScheduleContext _context;
        public InformationController(UniversityScheduleContext context)
        {
            _context = context;
        }

        // Список студентів із можливістю сортування за успішністю, факультетом чи групою
        public async Task<IActionResult> Students(string sortOrder)
        {
            IQueryable<Students> students = _context.Students
                .Include(s => s.Group)
                    .ThenInclude(g => g.Faculty);

            if (!string.IsNullOrEmpty(sortOrder))
            {
                if (sortOrder == "success")
                    students = students.OrderBy(s => s.SuccessRate);
                else if (sortOrder == "faculty")
                    students = students.OrderBy(s => s.Group.Faculty.Name);
                else if (sortOrder == "group")
                    students = students.OrderBy(s => s.Group.Name);
            }
            return View(await students.ToListAsync());
        }

        // Список викладачів із можливістю сортування за ПІБ, науковим ступенем або посадою
        public async Task<IActionResult> Teachers(string sortOrder)
        {
            IQueryable<Teachers> teachers = _context.Teachers
                .Include(t => t.Department);

            if (!string.IsNullOrEmpty(sortOrder))
            {
                if (sortOrder == "fullname")
                    teachers = teachers.OrderBy(t => t.FullName);
                else if (sortOrder == "degree")
                    teachers = teachers.OrderBy(t => t.AcademicDegree);
                else if (sortOrder == "position")
                    teachers = teachers.OrderBy(t => t.Position);
            }
            return View(await teachers.ToListAsync());
        }

        // Інформація про факультет
        public IActionResult FacultyInfo(int facultyId)
        {
            var faculty = _context.Faculties.Find(facultyId);
            if (faculty == null)
                return NotFound();
            return View(faculty);
        }
    }
}
