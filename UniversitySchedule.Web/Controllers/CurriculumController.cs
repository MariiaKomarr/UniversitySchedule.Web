using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversitySchedule.Web.Data;
using System.Threading.Tasks;

namespace UniversitySchedule.Web.Controllers
{
    public class CurriculumController : Controller
    {
        private readonly UniversityScheduleContext _context;
        public CurriculumController(UniversityScheduleContext context)
        {
            _context = context;
        }

        // GET: Відображення форми для введення даних
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: Обробка введених даних та відображення навчального плану
        [HttpPost]
        public async Task<IActionResult> Index(string fullName, int facultyId, int groupId)
        {
            // Реальна логіка пошуку навчального плану може залежати від додаткових зв'язків.
            // Для демонстрації повертаємо усі навчальні плани.
            var curriculums = await _context.Curriculums
                .Include(c => c.Course)
                .ToListAsync();

            ViewBag.FullName = fullName;
            ViewBag.FacultyId = facultyId;
            ViewBag.GroupId = groupId;
            return View("CurriculumList", curriculums);
        }
    }
}
