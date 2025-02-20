using Microsoft.AspNetCore.Mvc;


namespace UniversitySchedule.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Тут можна додати навігаційне меню або інформацію про сайт
            return View();
        }
    }
}