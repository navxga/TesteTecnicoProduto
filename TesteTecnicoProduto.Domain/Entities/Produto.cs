using TesteTecnicoProduto.Domain.Enums;

namespace TesteTecnicoProduto.Domain.Entities
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public TipoProdutoEnum Tipo { get; set; }
        public decimal Preco { get; set; }
    }
}
