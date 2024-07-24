namespace TesteTecnicoProduto.Domain.Exceptions.Produto
{
    public class ProdutoJaCadastradoException : Exception
    {
        public override string Message => "O produto informada já está cadastrado!";
    }
}
