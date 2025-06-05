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
    // Pikachu är en eltyp och kan utvecklas (IEvolvable)
    public class Charmander : FirePokemon, IEvolvable
    {
        public Charmander(int level, List<Attack> attacks) // Konstruktor som tar emot level och attacker
            : base("Charmander", level, attacks) { } //Anropar basklassens konstruktor med namnet "Charmander"

        public void Evolve()
        {
            Console.WriteLine($"{Name} is evolving...");
            Name = "Charmeleon";
            Level += 10;
            Console.WriteLine($"Now it's {Name}! Level {Level}!");
        }
    }

}
