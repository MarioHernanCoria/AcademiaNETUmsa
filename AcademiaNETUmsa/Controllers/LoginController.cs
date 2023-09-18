using AcademiaNETUmsa.Entities;
using AcademiaNETUmsa.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace AcademiaNETUmsa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        /// <summary>
        /// Obtiene todos los usuarios
        /// </summary>
        /// <param name="todos">Valor booleano</param>
        /// <returns>Todos los usuarios, o devuelve un usuario</returns>
        [HttpGet]
        [Route("Usuarios")]
        public IActionResult Usuarios(bool todos)
        {
            try
            {
                // throw new NotImplementedException();
                // Si todos es = true devuelve todos los usuarios
                if (todos)
                {
                    return Ok("Todos los usuarios");
                }
                else
                {
                    return Ok("Un Usuario");
                }
            }
            catch (Exception ex)
            {
                //Log(ex.Message)
                return BadRequest($"Contacta a sistemas {ex}");
            }
          
        }


        /// <summary>
        /// Obtiene todos los usuarios
        /// </summary>
        /// <param name="todos">Valor booleano</param>
        /// <returns>Un Token o un usuario o clave erronea</returns>
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


        /// <summary>
        /// Obtiene todos los usuarios
        /// </summary>
        /// <param name="todos">Valor booleano</param>
        /// <returns>Todos los usuarios, o devuelve un usuario</returns>
        [HttpPut]
        [Route("Editar")]
        public IActionResult EditarLogin(LoginDto login)
        {
           return Ok($"Se modifico el usuario {login.Usuario} correctamente");
        }


        /// <summary>
        /// Obtiene todos los usuarios
        /// </summary>
        /// <param name="todos">Valor booleano</param>
        /// <returns>Todos los usuarios, o devuelve un usuario</returns>
        [HttpDelete]
        [Route("Eliminar")]
        public IActionResult EliminarLogin(int id)
        {
            return Ok($"Se elimino el elemtento {id} correctamente");
        }
    }
}
