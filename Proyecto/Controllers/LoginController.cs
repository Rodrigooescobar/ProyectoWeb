using Data.Manager;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult CrearCuenta()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public ActionResult LoginGoogle()
        {
            var usuariosManager = new UsuariosManager();
            var usuarios = usuariosManager.BuscarListaAsync();
            if (usuarios.Result.Count > 0)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
				return RedirectToAction("Login", "login");
			}

		}

        public IActionResult CerrarSesion()
        {
            //action - controler
            return RedirectToAction("Login", "login");
        }

        public ActionResult OlvidoClave()
        {
            return View();
        }

        public ActionResult EnviarMail()
        {
            return RedirectToAction("RecuperarCuenta", "Login");
        }

        public ActionResult RecuperarCuenta()
        {
            return View();
        }
    }
}
