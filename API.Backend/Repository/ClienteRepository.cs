using API.Backend.DataContext;
using API.Backend.DataContext.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace API.Backend.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly BaseDataContext _dataContext;

        public ClienteRepository(BaseDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> AtualizarClienteAsync(Cliente cliente)
        {
            _dataContext.Cliente.Update(cliente);
            return await _dataContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExcluirClienteAsync(Guid Id)
        {
            _dataContext.Cliente.Remove(_dataContext.Cliente.Find(Id));
            return await _dataContext.SaveChangesAsync() > 0;
        }

        public async Task<Guid> InserirClienteAsync(Cliente cliente)
        {
            await _dataContext.Cliente.AddAsync(cliente);
            await _dataContext.SaveChangesAsync();

            return cliente.Id;
        }

        public async Task<Cliente> ObterClienteAsync(Guid Id)
        {
            return await _dataContext.Cliente.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }
    }
}
