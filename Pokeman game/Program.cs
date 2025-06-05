using Pokeman_game.Interfaces;
using Pokeman_game.PokemonSpecies;
using PokemanGame.Enums;
using PokemanGame.Models;
using PokemonTrainerSimulator.PokemonSpecies;

class Program
{
    static void Main()
    {
        // Skapar attacker
        var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
        var ember = new Attack("Ember", ElementType.Fire, 6);
        var watergun = new Attack("Water Gun", ElementType.Water, 10);
        var bubble = new Attack("Bubble", ElementType.Water, 5);
        var thunderbolt = new Attack("Thunderbolt", ElementType.Electric, 10);
        var spark = new Attack("Spark", ElementType.Electric, 7);

        // Skapar Pokémon med attacker
        var charmander = new Charmander(5, new List<Attack> { flamethrower, ember });
        var squirtle = new Squirtle(3, new List<Attack> { watergun, bubble });
        var pikachu = new Pikachu(15, new List<Attack> { thunderbolt, spark });

        var pokemons = new List<Pokemon> { charmander, squirtle, pikachu }; // Skapar en lista av Pokémon som innehåller olika typer

        foreach (var p in pokemons) // Loopar igenom varje pokemon i listan
        {
            p.RaiseLevel(); // Höjer nivån på varje Pokémon

            while (true)
            {
                Console.Write("Choose an attack (1) or randomize attack (2).");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    p.Attack(); // användarval
                    break;
                }
                else if (input == "2")
                {
                    p.RandomAttack(); // slumpad
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Pick 1 or 2.");
                }
            }


            if (p is IEvolvable evolvable) // Om Pokémon kan utvecklas
            {
                evolvable.Evolve(); // Utvecklar Pokémon
            }

            Console.WriteLine();
        }
    }
}
