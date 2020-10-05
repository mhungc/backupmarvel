using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marvel.Heroes.DAL;
using Marvel.Heroes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Marvel.Heroes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private ILogger _logger;
        private IHeroesProvider _heroesProvider;
        public HeroesController(ILogger<HeroesController> logger, IHeroesProvider heroesProvider)
        {
            _logger = logger;
            _heroesProvider = heroesProvider;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            var result = await _heroesProvider.GetAsync(id);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpGet("")]
        public async Task<IEnumerable<Hero>> GetAsync()
        {
            _logger.LogInformation($"Getting Heroes {DateTime.UtcNow.ToLongTimeString()} ");
            return await _heroesProvider.GetAsync();
        }
    }
}
