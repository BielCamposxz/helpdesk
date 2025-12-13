using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
