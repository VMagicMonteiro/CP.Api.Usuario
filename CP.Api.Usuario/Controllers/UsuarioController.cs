using CP.Api.Usuario.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP.Api.Usuario.Controllers
{
    [Route("Api/[Controller]")]
    public class UsuarioController : Controller
    {
        /// <summary>
        /// Tras todos os usuários cadastrados
        /// em Uma lista para serem exibidos.
        /// </summary>
        /// <param name="temperatura">Temperatura em Fahrenheit</param>
        /// <returns>Retorna os usuários cadastrados no banco de dados</returns>
        [HttpGet]
        public async Task Get()
        {

        }
        [HttpGet("{Cpf}")]
        public async Task<GetUsuariosResponse> Get(string Cpf)
        {
            return await 
        }


    }
}
