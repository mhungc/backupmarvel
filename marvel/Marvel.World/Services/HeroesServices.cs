using Marvel.World.Interfaces;
using Marvel.World.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Marvel.World.Services
{
    public class HeroesServices : IHeroesServices
    {
        private readonly IHttpClientFactory _iHttpClientFactory;
        public HeroesServices(IHttpClientFactory iHttpClientFactory)
        {
            _iHttpClientFactory = iHttpClientFactory;
        }

        public Task<Hero> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Hero>> GetAsync()
        {
            var client = _iHttpClientFactory.CreateClient("heroesService");
            var response = await client.GetAsync($"api/heroes");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Hero>>(content);
            }

            return null;
        }
    }
}
