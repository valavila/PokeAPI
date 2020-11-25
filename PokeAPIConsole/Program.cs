using PokeAPICore;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokeAPIConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            PokeAPIClient client = new PokeAPIClient();
            try
            {
                Pokemon result = await client.GetPokemonByName("bulbasaur");
                
                Console.WriteLine($"Pokemon id: {result.id}, " +
                    $"\nName: {result.name}, " +
                    $"\nWeight: {result.weight}, " +
                    $"\nHeight(in inches): {result.height}");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Sorry, that pokemon does not exist");
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("Please try again later");
            }

            Console.ReadKey();
        }
    }
}
