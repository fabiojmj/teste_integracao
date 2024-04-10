using CalculosGeometricos.Interfaces;
using CalculosGeometricos.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CalculosGeometricos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculosController : Controller
    {

        private readonly ICalculosServices _calculosServices;

        public CalculosController(ICalculosServices calculosServices)
        {
            _calculosServices = calculosServices;
        }

        [Route("soma")]
        [HttpPost]
        public IActionResult Soma(SomaViewModel soma)
        {
            var resultado = _calculosServices.Soma(soma);
            return Ok(resultado);
        }

        [Route("quadrado")]
        [HttpGet]
        public IActionResult Quadrado(int numero)
        {
            var resultado = _calculosServices.Quadrado(numero);
            return Ok(resultado);
        }

        [Route("potencia")]
        [HttpPost]
        public IActionResult Potencia(PotenciaViewModel potencia)
        {
            var resultado = _calculosServices.Potencia(potencia);
            return Ok(resultado);
        }
    }
}
