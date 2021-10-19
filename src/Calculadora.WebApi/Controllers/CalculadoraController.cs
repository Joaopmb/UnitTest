using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Calculadora.WebApi.Model;

namespace Calculadora.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        public CalculadoraController()
        {
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
            if (request.Numero2 == 0)
                return BadRequest("Não é possivel uma divisão com divisor zero");

            var resultado = request.Numero1 / request.Numero2;
            return Ok(resultado);
        }
    }
}
