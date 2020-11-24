using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokeAPICore
{
    /// <summary>
    /// Client class to consume poke API
    /// https://pokeapi.co/
    /// </summary>
    public class PokeAPIClient
    {
        static readonly HttpClient client = new HttpClient();

        /// <summary>
        /// Retreive pokemon by name
        /// </summary>
        /// <exception cref="HttpRequestException"></exception>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<Pokemon> GetPokemonByName(string name)
        {
            try
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{name}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Pokemon>(responseBody);
            }
            catch(HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

        public void GetPokemoneById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
