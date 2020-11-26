using System;
using System.Threading.Tasks;
using API.Backend.DataContext.EntityModels;
using API.Backend.DTO;
using API.Backend.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly IClienteRepository _clienteRepository;
        public ClienteController(ILogger<ClienteController> logger, IClienteRepository clienteRepository)
        {
            _logger = logger;
            _clienteRepository = clienteRepository;
        }

        [HttpGet("/Cliente/{idCliente}")]
        public async Task<ClienteDto> Get(string idCliente)
        {
            _logger.LogInformation("Obtendo cliente");

            var result = await _clienteRepository.ObterClienteAsync(new Guid(idCliente));

            return result.ToDto();
        }

        [HttpPut("/Cliente/")]
        public async Task<OkObjectResult> Put([FromBody]Cliente cliente)
        {
            _logger.LogInformation("Inserindo cliente");

            var result = await _clienteRepository.InserirClienteAsync(cliente);

            return Ok(result);
        }

        [HttpPost("/Cliente/")]
        public async Task<OkObjectResult> Post([FromBody]Cliente cliente)
        {
            _logger.LogInformation("Atualizar cliente");

            var result = await _clienteRepository.AtualizarClienteAsync(cliente);

            return Ok(result);
        }

        [HttpDelete("/Cliente/{idCliente}")]
        public async Task<OkObjectResult> Delete(string idCliente)
        {
            _logger.LogInformation("Remover cliente");

            var result = await _clienteRepository.ExcluirClienteAsync(new Guid(idCliente));

            return Ok(result);
        }
    }
}
