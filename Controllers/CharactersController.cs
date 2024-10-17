using Microsoft.AspNetCore.Mvc;

namespace TetrisTARpe23.Controllers
{
    public class CharactersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
