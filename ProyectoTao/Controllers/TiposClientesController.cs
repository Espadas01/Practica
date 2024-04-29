using ProyectoTao.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Dapper;

namespace ProyectoTao.Controllers
{


    public class TiposClientesController : Controller
    {
        private readonly string connectionString;

        public TiposClientesController(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public IActionResult Crear()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = connection.Query("SELECT 1").FirstOrDefault();
            }

            return View();
        }
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
