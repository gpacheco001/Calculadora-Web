using Microsoft.AspNetCore.Mvc;

namespace CalculadoraWeb.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpGet]
        public IActionResult Sumar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sumar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            ViewBag.Resultado = resultado;
            return View();
        }
    }
}
