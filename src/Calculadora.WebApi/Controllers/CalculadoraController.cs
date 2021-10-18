using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Calculadora.WebApi.Model;

namespace Calculadora.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("Soma")]
        public IActionResult Soma([FromBody]Operacao.Request request)
        {
            var resultado = request.Numero1 + request.Numero2;
            return Ok(resultado);
        }

        [HttpPost]
        [Route("Subtracao")]
        public IActionResult Subtracao([FromBody]Operacao.Request request)
        {
            var resultado = request.Numero1 - request.Numero2;
            return Ok(resultado);
        }

        [HttpPost]
        [Route("Multiplicacao")]
        public IActionResult Multiplicacao([FromBody]Operacao.Request request)
        {
            var resultado = request.Numero1 * request.Numero2;
            return Ok(resultado);
        }

        [HttpPost]
        [Route("Divisao")]
        public IActionResult Divisao([FromBody]Operacao.Request request)
        {
            var resultado = request.Numero1 / request.Numero2;
            return Ok(resultado);
        }
    }
}
