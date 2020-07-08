using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using varegoApi.Models;
using varegoApi.Services;

namespace varegoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CacheController : ControllerBase
    {
        private readonly StringServiceCache _stringServiceCache;
        private readonly ILogger<CacheController> _logger;

        public CacheController(ILogger<CacheController> logger, StringServiceCache stringServiceCache)
        {
            _logger = logger;
            _stringServiceCache = stringServiceCache;
        }

        [HttpGet("{key}")]
        public async Task<IActionResult> GetCacheValue([FromRoute] string key)
        {
            var result = await _stringServiceCache.GetCacheValueAsync(key);
            return string.IsNullOrEmpty(result) ? (IActionResult) NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> SetCacheValue([FromBody] StringCacheRequest pRequest)
        {
            await _stringServiceCache.SetCacheValueAsync(pRequest.Key, pRequest.Value);
            return Ok();
        }
    }
}
