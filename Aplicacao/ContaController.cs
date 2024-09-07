using Dominio;
using Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Aplicacao
{
    #region DTO
    public class InserirContaDTO
    {
        public string NumeroConta { get; set; }

        public string Titular { get; set; }
    }
    #endregion

    [Controller]
    [Route("api/[Controller]")]
    public class ContaController : ControllerBase
    {
        public ContaDomain _contaDomain { get; set; }

        public ContaController()
        {
            _contaDomain = new ContaDomain();
        }

        [HttpPost]
        public IActionResult Inserir([FromBody] InserirContaDTO inserirDto)
        {
            try
            {
                var conta = new Conta()
                {
                    NumeroConta = inserirDto.NumeroConta,
                    Titular = inserirDto.Titular
                };

                _contaDomain.Inserir(conta);

                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, e.Message);
            }
        }
    }
}
