using TesteTecnicoProduto.Domain.Entities;

namespace TesteTecnicoProduto.Domain.Interfaces.Services
{
    public interface IProdutoDomainService
    {
        #region CRUD
        void CriarProduto(Produto produto);
        Produto? ObterProduto(Guid id);
        List<Produto> ObterTodosProdutos();
        void AtualizarProduto(Produto produto);
        void DeletarProduto(Guid id);

        #endregion

        //ObterDadosDashboard
    }
}
