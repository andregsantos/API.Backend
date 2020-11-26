using API.Backend.DataContext.EntityModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Backend.Repository
{
    public interface IClienteRepository
    {
        Task<Cliente> ObterClienteAsync(Guid Id);
        Task<Guid> InserirClienteAsync(Cliente cliente);
        Task<bool> AtualizarClienteAsync(Cliente cliente);
        Task<bool> ExcluirClienteAsync(Guid Id);
    }
}
