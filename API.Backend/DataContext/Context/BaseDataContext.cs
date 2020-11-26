using API.Backend.DataContext.EntityModels;
using API.Backend.DataContext.Mappings;
using Microsoft.EntityFrameworkCore;

namespace API.Backend.DataContext
{
    public class BaseDataContext : DbContext
    {
        public BaseDataContext(DbContextOptions<BaseDataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());

            base.OnModelCreating(modelBuilder);
        }

        #region DbSet

        public DbSet<Cliente> Cliente { get; set; }

        #endregion
    }
}