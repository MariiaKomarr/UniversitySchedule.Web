using Microsoft.AspNetCore.Mvc;

namespace UniversitySchedule.Web.Controllers
{
    public class HelpController : Controller
    {
        // GET: Відображення форми введення інформації для довідки
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: Обробка інформації для довідки та відображення результату
        [HttpPost]
        public IActionResult Index(string query)
        {
            // Тут можна реалізувати логіку пошуку або формування довідки
            ViewBag.Message = "Довідка для запиту: " + query;
            return View("Result");
        }
    }
}
