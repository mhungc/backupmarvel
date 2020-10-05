using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marvel.World.DAL;
using Marvel.World.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Marvel.World.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FightController : ControllerBase
    {
        private IWarServices _warServices;
        public FightController(IWarServices warProvider)
        {
            _warServices = warProvider;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            //var result = await _warServices.GetAsync(id);

            //if (result != null)
            //{
            //    return Ok(result);
            //}

            return NotFound();
        }

        [HttpGet]
        public async Task<IEnumerable<War>> GetAsync()
        {
           // return "Welcome to Csharpstar !!";
             return await _warServices.GetAsync();
        }
    }
}
