using TesteTecnicoProduto.Domain.Entities;
using TesteTecnicoProduto.Domain.Interfaces.Repositories;
using TesteTecnicoProduto.Infra.Data.Contexts;

namespace TesteTecnicoProduto.Infra.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public Produto? ObterPorNome(string nome)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Produto.FirstOrDefault(p => p.Nome == nome);
            }
        }
    }
}
