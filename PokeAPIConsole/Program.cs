using PokeAPICore;
using System;
using System.Threading.Tasks;

namespace PokeAPIConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            PokeAPIClient client = new PokeAPIClient();
            string result = await client.GetPokemonByName("bulbasaur");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
