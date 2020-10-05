using Marvel.World.Interfaces;
using Marvel.World.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Marvel.World.Services
{
    public class VillainsServices : IVillainsServices
    {
        private readonly IHttpClientFactory _iHttpClientFactory;
        public VillainsServices(IHttpClientFactory iHttpClientFactory)
        {
            _iHttpClientFactory = iHttpClientFactory;
        }

        public async Task<IEnumerable<Villain>> GetAsync()
        {
            var client = _iHttpClientFactory.CreateClient("villainsService");
            var response = await client.GetAsync($"api/villains");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Villain>>(content);
            }

            return null;
        }

        public Task<Villain> GetAsync(string id)
        {
            throw new System.NotImplementedException();
        }

    }
}