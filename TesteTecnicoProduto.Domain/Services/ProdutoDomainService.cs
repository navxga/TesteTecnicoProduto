using TesteTecnicoProduto.Domain.Entities;
using TesteTecnicoProduto.Domain.Exceptions.Produto;
using TesteTecnicoProduto.Domain.Interfaces.Repositories;
using TesteTecnicoProduto.Domain.Interfaces.Services;

namespace TesteTecnicoProduto.Domain.Services
{
    public class ProdutoDomainService : IProdutoDomainService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoDomainService (IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        #region CRUD

        public void CriarProduto(Produto produto)
        {
            if (_produtoRepository.ObterPorNome(produto.Nome) != null)
                throw new ProdutoJaCadastradoException();

            _produtoRepository.Criar(produto);
        }

        public Produto? ObterProduto(Guid id)
        {
            return _produtoRepository.ObterPorId(id)
                ?? throw new ProdutoNaoLocalizadoException();
        }

        public List<Produto>? ObterTodosProdutos()
        {
            return _produtoRepository.ObterTodos();
        }

        public void AtualizarProduto(Produto produto)
        {
            if (_produtoRepository.ObterPorId(produto.Id) == null)
                throw new ProdutoNaoLocalizadoException();

            _produtoRepository.Atualizar(produto);
        }

        public void DeletarProduto(Guid id)
        {
            var produto = _produtoRepository.ObterPorId(id)
                ?? throw new ProdutoNaoLocalizadoException();

            _produtoRepository.Deletar(produto);
        }

        #endregion
    }
}
