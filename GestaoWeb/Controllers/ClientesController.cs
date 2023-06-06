using Microsoft.AspNetCore.Mvc;

namespace GestaoWeb.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
