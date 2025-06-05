using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemanGame.Enums;
using PokemanGame.Models;

namespace Pokeman_game.PokemonTypes
{
    public class FirePokemon : Pokemon
    {
        public FirePokemon(string name, int level, List<Attack> attacks) : base(name, level, attacks) // Konstruktor som anropar basklassens konstruktor
        {
            Type = ElementType.Fire; // Sätter elementtypen till Fire
        }
    }

}
