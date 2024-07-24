using TesteTecnicoProduto.Application.Interfaces;
using TesteTecnicoProduto.Application.Models.Produto.Request;
using TesteTecnicoProduto.Application.Models.Produto.Response;
using TesteTecnicoProduto.Domain.Entities;
using TesteTecnicoProduto.Domain.Enums;
using TesteTecnicoProduto.Domain.Interfaces.Services;

namespace TesteTecnicoProduto.Application.Services
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoDomainService _produtoDomainService;

        public ProdutoAppService(IProdutoDomainService produtoDomainService)
        {
            _produtoDomainService = produtoDomainService;
        }

        #region CRUD

        public void CriarProduto(CriarProdutoRequestModel model)
        {
            var produto = new Produto()
            {
                Nome = model.Nome,
                Tipo = (TipoProdutoEnum)model.Tipo,
                Preco = model.Preco
            };

            _produtoDomainService.CriarProduto(produto);
        }

        public ObterProdutoResponseModel ObterProduto(Guid id)
        {
            var produto = _produtoDomainService.ObterProduto(id);

            return new ObterProdutoResponseModel()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Tipo = produto.Tipo.ToString(),
                Preco = produto.Preco
            };
        }

        public List<ObterProdutoResponseModel> ObterTodosProdutos()
        {
            return _produtoDomainService.ObterTodosProdutos().Select(p =>
            {
                return new ObterProdutoResponseModel()
                {
                    Id = p.Id,
                    Nome = p.Nome,
                    Tipo = p.Tipo.ToString(),
                    Preco = p.Preco
                };
            }).ToList();
        }

        public void AtualizarProduto(AtualizarProdutoRequestModel model)
        {
            var produto = new Produto()
            {
                Id = model.Id,
                Nome = model.Nome,
                Tipo = (TipoProdutoEnum)model.Tipo,
                Preco = model.Preco
            };

            _produtoDomainService.AtualizarProduto(produto);
        }

        public void DeletarProduto(Guid id)
        {
            _produtoDomainService.DeletarProduto(id);
        }

        #endregion

        public List<DadosDashboardResponseModel> ObterDadosDashboard()
        {
            var dadosDashboard = new List<DadosDashboardResponseModel>();

            var produtosTipados = _produtoDomainService.ObterTodosProdutos().GroupBy(p => p.Tipo).ToList();

            foreach (var tipo in produtosTipados)
            {
                dadosDashboard.Add(new DadosDashboardResponseModel()
                {
                    PrecoMedio = Decimal.Round(tipo.Sum(p => p.Preco) / tipo.Count(), 2),
                    Quantidade = tipo.Count(),
                    Tipo = tipo.Key.ToString()
                });
            }

            return dadosDashboard;
        }
    }
}
