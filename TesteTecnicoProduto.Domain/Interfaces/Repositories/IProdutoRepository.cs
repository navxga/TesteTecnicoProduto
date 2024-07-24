using TesteTecnicoProduto.Domain.Entities;

namespace TesteTecnicoProduto.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        Produto? ObterPorNome(string nome);
    }
}
