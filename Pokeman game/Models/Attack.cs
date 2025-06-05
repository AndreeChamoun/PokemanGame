using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemanGame.Enums;

namespace PokemanGame.Models
{
    public class Attack // Attack class represents a Pokeman attack
    {
        public string Name { get; set; } // Namnet på attacken
        public ElementType Type { get; set; } // Attackens elementtyp
        public int BasePower { get; set; } // Grundstyrka

        public Attack(string name, ElementType type, int basePower) // Konstruktor för att skapa en attack
        {
            Name = name;
            Type = type;
            BasePower = basePower;
        }

        public void Use(int level)
        {// Metod som "använder" attacken
            Console.WriteLine($"\n{Name} hits with total power {BasePower + level}!");
        }

        internal int CalculateDamage(int level)
        {
            throw new NotImplementedException();
        }
    }

}
