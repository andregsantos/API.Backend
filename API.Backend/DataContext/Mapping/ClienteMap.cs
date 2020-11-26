using API.Backend.DataContext.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Backend.DataContext.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {

            // Primary Key
            builder.HasKey(t => t.Id);

            // Properties
            builder.Property(t => t.Nome)
                .IsRequired();

            builder.Property(t => t.Idade)
                .IsRequired();

            // Table & Column Mappings
            builder.ToTable("Cliente");

            builder.Property(t => t.Nome).HasMaxLength(100).HasColumnName("Nome");
            builder.Property(t => t.Idade).HasColumnName("Idade");

        }
    }
}
