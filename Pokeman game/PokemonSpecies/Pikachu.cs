using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Pokeman_game.Interfaces;
using Pokeman_game.PokemonTypes;
using PokemanGame.Models;
using System.Xml.Linq;

namespace PokemonTrainerSimulator.PokemonSpecies
{
    // Pikachu är en eltyp och kan evolva (IEvolvable)
    public class Pikachu : ElectricPokemon, IEvolvable
    {
        public Pikachu(int level, List<Attack> attacks) // Konstruktor som tar emot level och attacker
            : base("Pikachu", level, attacks) // Anropar basklassens konstruktor med namnet "Pikachu"
        {
        }

        public void Evolve()
        {
            Console.WriteLine($"{Name} is evolving...");
            Name = "Raichu";
            Level += 10;
            Console.WriteLine($"Now it's {Name}! Level {Level}!");
        }
    }
}
