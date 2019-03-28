using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TratamentoDeExcecoes.Dtos;
using Microsoft.AspNetCore.Http;

namespace TratamentoDeExcecoes.Controllers
{
    [Route("api/[controller]")]
    public class MinhaAPI : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            DtoNumeroAleatorio dtoNumero = new DtoNumeroAleatorio();

            try
            {
                Model.Numeros numeros = new Model.Numeros();

                int numero = numeros.GerarNumeroAleatorio();

                return Json(new { numero } );
            }
            catch (Exception ex)
            {
                dtoNumero.mensagemDeErro = ex.Message;
                dtoNumero.mensagemStack = ex.StackTrace.ToString();

                return Json(new { dtoNumero.mensagemDeErro, dtoNumero.mensagemStack } );
            }
        }  
    }
}
