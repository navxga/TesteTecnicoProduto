using TesteTecnicoProduto.Application.Interfaces;
using TesteTecnicoProduto.Application.Services;
using TesteTecnicoProduto.Domain.Interfaces.Repositories;
using TesteTecnicoProduto.Domain.Interfaces.Services;
using TesteTecnicoProduto.Domain.Services;
using TesteTecnicoProduto.Infra.Data.Repositories;

namespace TesteTecnicoProduto.API.Configurations
{
    public class DependencyInjectionConfiguration
    {
        public static void Configure(WebApplicationBuilder builder)
        {
            #region AppServices

            builder.Services.AddTransient<IProdutoAppService, ProdutoAppService>();

            #endregion

            #region DomainServices

            builder.Services.AddTransient<IProdutoDomainService, ProdutoDomainService>();

            #endregion

            #region Repositories

            builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();

            #endregion
        }
    }
}
