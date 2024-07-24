using Microsoft.EntityFrameworkCore;
using TesteTecnicoProduto.Domain.Entities;
using TesteTecnicoProduto.Infra.Data.Configurations;

namespace TesteTecnicoProduto.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=DBTesteTecnico;Persist Security Info=True;User ID=sa;Password=admin;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
