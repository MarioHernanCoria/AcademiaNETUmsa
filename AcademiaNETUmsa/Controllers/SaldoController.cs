using AcademiaNETUmsa.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaNETUmsa.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class SaldoController : ControllerBase
    {

        /// <summary>
        /// Funcion para Consultar Saldo
        /// </summary>
        /// <returns>190</returns>
        [HttpGet]
        [Route("Consultar")]
        public IActionResult Consultar()
        {
           return Ok(190);
        }


        /// <summary>
        /// Funcion para Agrega saldo
        /// </summary>
        /// <returns>Un Hola</returns>
        [HttpPost]
        [Route("Agregar")]
        public IActionResult AgregarSaldo()
        {
            return Unauthorized("Hola");
        }
    }
}