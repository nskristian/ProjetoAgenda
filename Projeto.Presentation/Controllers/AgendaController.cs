using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Projeto.Presentation.Controllers
{
    [Authorize]
    public class AgendaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
