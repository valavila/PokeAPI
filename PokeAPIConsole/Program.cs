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
            Pokemon result = await client.GetPokemonByName("bulbasaur");
            Console.WriteLine($"Pokemon id: {result.id}, " +
                $"\nName: {result.name}, " +
                $"\nWeight(in hectograms): {result.weight}, " +
                $"\nHeight(in inches): {result.height}");

            Console.ReadKey();
        }
    }
}
