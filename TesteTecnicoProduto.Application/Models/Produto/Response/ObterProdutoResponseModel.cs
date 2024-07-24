namespace TesteTecnicoProduto.Application.Models.Produto.Response
{
    public class ObterProdutoResponseModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public decimal Preco { get; set; }
    }
}
