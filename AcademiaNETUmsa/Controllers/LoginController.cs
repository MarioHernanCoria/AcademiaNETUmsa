using AcademiaNETUmsa.Entities;
using AcademiaNETUmsa.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaNETUmsa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [HttpGet]
        [Route("Usuarios")]
        public IActionResult Usuarios(bool todos)
        {
            if (todos)
            {
                return Ok("Todos los usuarios");
            }
            else
            {
                return Ok("Un Usuario");
            }
        }

        [HttpPost]
        public IActionResult Login(LoginDto login)
        {
            if (login.Usuario == "Mario" && login.Clave == "1234")
            {
                return Ok("token: 31231231");
            }else
            {
                return Unauthorized("Usuario o clave erronea");
            }
        }

        [HttpPut]
        [Route("Editar")]
        public IActionResult EditarLogin(LoginDto login)
        {
           return Ok($"Se modifico el usuario {login.Usuario} correctamente");
        }

        [HttpDelete]
        [Route("Eliminar")]
        public IActionResult EliminarLogin(int id)
        {
            return Ok($"Se elimino el elemtento {id} correctamente");
        }
    }
}
