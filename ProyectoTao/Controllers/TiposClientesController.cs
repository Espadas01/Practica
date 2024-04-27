using ProyectoTao.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoTao.Controllers
{


    public class TiposClientesController : Controller
    {
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(TipoCliente tipoCliente) 
        {
            if (!ModelState.IsValid)
            {
                return View(tipoCliente);
            }
            return View();
        }



    }
}
