using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemanGame.Enums;
using PokemanGame.Models;

namespace PokemanGame.Models
{
    public abstract class Pokemon // Abstrakta klasser kan inte skapas direkt, utan måste ärvas av andra klasser
    {
        private string _name;
        private int _level;

        // Validering med egenskaper
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 2 || value.Length > 15)
                    throw new ArgumentException("Name must be between 2 and 15 characters.");
                _name = value;
            }
        }

        public int Level
        {
            get => _level;
            set
            {
                if (value < 1)
                    throw new ArgumentException("Level must be 1 or higher.");
                _level = value;
            }
        }

        public ElementType Type { get; protected set; } // protected set så att endast ärvda klasser kan ändra typen

        // List samling, kan innehålla flera attacker
        public List<Attack> Attacks;

        public Pokemon(string name, int level, List<Attack> attacks) // När man skapar en ny Pokémon, måste man skicka in: namn, nivå och lista av attacker
        {
            Name = name;
            Level = level;
            Attacks = attacks;
        }

        public void RaiseLevel() // Metod för att höja nivån på Pokeman
        {
            Level++;
            Console.WriteLine($"{Name} leveled up to {Level}!");
        }

        public void RandomAttack() // Metod för att välja en attack slumpmässigt
        {
            var random = new Random();
            int index = random.Next(Attacks.Count);
            Attacks[index].Use(Level);
        }

        public void Attack() // Metod för att välja en attack från listan. Den måste finnas som alternativ i listan, annars kan man inte fortsätta
        {
            while (true)
            {
                for (int i = 0; i < Attacks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Attacks[i].Name}");
                }

                Console.Write("Choose an attack ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= Attacks.Count) // kontrollerar om input är ett giltigt tal och inom intervallet för attacker
                {
                    Attacks[choice - 1].Use(Level);
                    break; // korrekt input bryter loopen
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again.");
                }
            }
        }
    }
}