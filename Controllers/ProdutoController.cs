using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using varegoApi.Models;
using varegoApi.Services;

namespace varegoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly ProdutoService _produtoService;
        private readonly ILogger<ProdutosController> _logger;

        public ProdutosController(ILogger<ProdutosController> logger, ProdutoService produtoService)
        {
            _logger = logger;
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<IEnumerable<Produto>> Get()
        {
            return await _produtoService.GetAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Salvar([FromBody] Produto pProduto)
        {
            return Ok(await _produtoService.CreateAsync(pProduto));
        }
    }
}
