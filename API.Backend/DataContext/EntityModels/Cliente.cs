using System;
using System.ComponentModel.DataAnnotations;

namespace API.Backend.DataContext.EntityModels
{
    /// <summary>
    /// Para boas praticas ultilizar anotation quando possível.
    /// Informações base para criar um cliente
    /// Importante limitar o tamanho do campo.
    /// </summary>
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(100)] 
        public string Nome { get; set; }

        [Range(18, 100)]
        public int Idade { get; set; }
    }
}