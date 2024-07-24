using Microsoft.AspNetCore.Mvc;
using TesteTecnicoProduto.Application.Interfaces;
using TesteTecnicoProduto.Application.Models.Produto.Request;
using TesteTecnicoProduto.Domain.Exceptions.Produto;

namespace TesteTecnicoProduto.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutoController(IProdutoAppService produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        #region CRUD

        [HttpPost]
        [Route("criar-produto")]
        public IActionResult CriarProduto(CriarProdutoRequestModel model)
        {
            try
            {
                _produtoAppService.CriarProduto(model);

                return StatusCode(201, new { Mensagem = "Produto criado com sucesso!"});
            }
            catch (ProdutoJaCadastradoException ex)
            {
                return StatusCode(409, new { Mensagem = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensagem = ex.Message });
            }
        }

        [HttpGet]
        [Route("obter-produto")]
        public IActionResult ObterProduto(Guid id)
        {
            try
            {
                var response = _produtoAppService.ObterProduto(id);

                return StatusCode(200, new { Mensagem = response });
            }
            catch (ProdutoNaoLocalizadoException ex)
            {
                return StatusCode(404, new { Mensagem = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensagem = ex.Message });
            }
        }

        [HttpGet]
        [Route("obter-todos")]
        public IActionResult ObterTodosProdutos(Guid id)
        {
            try
            {
                var response = _produtoAppService.ObterTodosProdutos();

                return StatusCode(200, new { Mensagem = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensagem = ex.Message });
            }
        }

        [HttpPut]
        [Route("atualizar-produto")]
        public IActionResult AtualizarProduto(AtualizarProdutoRequestModel model)
        {
            try
            {
                _produtoAppService.AtualizarProduto(model);

                return StatusCode(201, new { Mensagem = "Produto atualizado com sucesso!" });
            }
            catch (ProdutoNaoLocalizadoException ex)
            {
                return StatusCode(404, new { Mensagem = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensagem = ex.Message });
            }
        }

        [HttpDelete]
        [Route("deletar-produto")]
        public IActionResult DeletarProduto(Guid id)
        {
            try
            {
                _produtoAppService.DeletarProduto(id);

                return StatusCode(201, new { Mensagem = "Produto deletado com sucesso!" });
            }
            catch (ProdutoNaoLocalizadoException ex)
            {
                return StatusCode(500, new { Mensagem = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensagem = ex.Message });
            }
        }

        #endregion

        [HttpGet]
        [Route("obter-dados-dashboard")]
        public IActionResult ObterDadosDashboard()
        {
            try
            {
                var response = _produtoAppService.ObterDadosDashboard();

                return StatusCode(200, new { Mensagem = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensagem = ex.Message });
            }
        }
    }
}
