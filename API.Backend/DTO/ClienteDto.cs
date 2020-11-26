using API.Backend.DataContext.EntityModels;
using System;

namespace API.Backend.DTO
{
    public class ClienteDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    public static class ClienteDtoExtension
    {
        public static ClienteDto ToDto(this Cliente cliente)
        {
            return new ClienteDto()
            {
                Id = cliente.Id,
                Idade = cliente.Idade,
                Nome = cliente.Nome
            };
        }
    }
}
