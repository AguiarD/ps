using Microsoft.AspNetCore.Mvc;

namespace GPS.Controllers
{
    public class ScoutController : Controller
    {
        private readonly Contexto _context;
        public IActionResult Index()
        {
            return View();
        }
    }
}
