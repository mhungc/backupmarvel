using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marvel.Villains.DAL;
using Marvel.Villains.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Marvel.Villains.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillainsController : ControllerBase
    {
        private IVillainsProvider _villainsProvider;

        public VillainsController(IVillainsProvider villainsProvider)
        {
            _villainsProvider = villainsProvider;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            var result = await _villainsProvider.GetAsync(id);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IEnumerable<Villain>> GetAsync()
        {
            return await _villainsProvider.GetAsync();
        }
    }
}
