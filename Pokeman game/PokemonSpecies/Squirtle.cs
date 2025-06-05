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

namespace Pokeman_game.PokemonSpecies
{
    // Squirtle är en vattentyp och kan evolva (IEvolvable)
    public class Squirtle : WaterPokemon, IEvolvable
    {
        public Squirtle(int level, List<Attack> attacks) // Konstruktor som tar emot level och attacker
            : base("Squirtle", level, attacks) //Anropar basklassens konstruktor med namnet "Squirtle"
        {
        }

        public void Evolve()
        {
            Console.WriteLine($"{Name} is evolving...");
            Name = "Wartortle";
            Level += 10;
            Console.WriteLine($"Now it's {Name}! Level {Level}!");
        }
    }

}
