using Microsoft.AspNetCore.Mvc;
using Projeto.Infra.Data.Repositories;
using Projeto.Presentation.Models;

namespace Projeto.Presentation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AccountLoginModel model, [FromServices] UsuarioRepository usuarioRepository)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }

        [HttpPost]
        public IActionResult Register(AccountRegisterModel model, [FromServices] UsuarioRepository usuarioRepository)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
