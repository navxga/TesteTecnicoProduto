using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteTecnicoProduto.Domain.Entities;

namespace TesteTecnicoProduto.Infra.Data.Configurations
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable(nameof(Produto));
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("Id");

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(p => p.Tipo)
                .HasColumnName("Tipo")
                .HasConversion<int>()
                .IsRequired();

            builder.Property(p => p.Preco)
                .HasColumnName("Preco")
                .IsRequired();
        }
    }
}
