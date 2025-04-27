using Microsoft.AspNetCore.Mvc;

namespace EstacionaFacil.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
