using System.ComponentModel.DataAnnotations;

namespace TesteTecnicoProduto.Application.Models.Produto.Request
{
    public class AtualizarProdutoRequestModel
    {
        [Required(ErrorMessage = "Informe o id do produto.")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do produto!")]
        [MaxLength(255, ErrorMessage = "Informe no máximo 255 caracteres no nome do produto!")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe o tipo do produto!")]
        [Range(1, 2, ErrorMessage = "O tipo do produto deve ser 1 (Material) ou 2 (Serviço)!")]
        public int Tipo { get; set; }

        [Required(ErrorMessage = "Informe o preço do produto!")]
        public decimal Preco { get; set; }
    }
}
