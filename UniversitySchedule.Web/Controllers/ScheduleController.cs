using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversitySchedule.Web.Data;
using System.Threading.Tasks;

namespace UniversitySchedule.Web.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly UniversityScheduleContext _context;

        public ScheduleController(UniversityScheduleContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Завантаження всіх занять із пов'язаними даними
            var lessons = await _context.Lessons
                .Include(l => l.Course)
                .Include(l => l.Teacher)
                .Include(l => l.Auditorium)
                .Include(l => l.Group)
                .ToListAsync();

            return View(lessons);
        }

        // Додаткові методи для фільтрації розкладу можна додати тут.
    }
}
