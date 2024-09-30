using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        } 
        
        public IActionResult CerrarSesion()
        {
            //action - controler
            return RedirectToAction("Login", "login");
        }
    }
}
