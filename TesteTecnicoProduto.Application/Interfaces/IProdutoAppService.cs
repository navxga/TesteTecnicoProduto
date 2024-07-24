using TesteTecnicoProduto.Application.Models.Produto.Request;
using TesteTecnicoProduto.Application.Models.Produto.Response;

namespace TesteTecnicoProduto.Application.Interfaces
{
    public interface IProdutoAppService
    {
        #region CRUD

        void CriarProduto(CriarProdutoRequestModel model);
        ObterProdutoResponseModel ObterProduto(Guid id);
        List<ObterProdutoResponseModel> ObterTodosProdutos();
        void AtualizarProduto(AtualizarProdutoRequestModel model);
        void DeletarProduto(Guid id);

        #endregion

        List<DadosDashboardResponseModel> ObterDadosDashboard();
    }
}
