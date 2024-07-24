namespace TesteTecnicoProduto.Domain.Exceptions.Produto
{
    public class ProdutoNaoLocalizadoException : Exception
    {
        public override string Message => "O produto informado não foi localizado!";
    }
}
