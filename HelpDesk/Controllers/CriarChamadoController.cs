using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Controllers
{
    public class CriarChamadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
