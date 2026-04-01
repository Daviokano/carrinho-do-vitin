using Microsoft.AspNetCore.Mvc;

namespace Project2.Controllers
{
    public class LivrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
