using Microsoft.AspNetCore.Mvc;

namespace ReactJsQuickstart.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
