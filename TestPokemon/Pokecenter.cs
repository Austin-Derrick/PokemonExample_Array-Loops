using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPokemon
{
    class Pokecenter
    {
        public static Character nurseJoy = new Character("Nurse Joy");

        public static void Menu()
        {
            int playerInput = 0;
            Console.WriteLine($"{nurseJoy.name}: Welcome to the Poke. What would you like to do?\n\t1: heal pokemon\n\t2: return to main menu");
            playerInput = int.Parse(Console.ReadLine());

            if (playerInput == 1)
            {
                HealPokemon(Game.player.pokemon);
            }
            else if (playerInput == 2)
            {
                Game.Menu();
            }
        }

        public static void HealPokemon(Pokemon[] pokemon)
        {
            for (int i = 0; i < pokemon.Length; i++)
            {
                if (pokemon[i].name != "Pokemon Name")
                {
                    Console.WriteLine($"Healing: {pokemon[i].name}");
                    pokemon[i].health = 100;
                }
                else
                {
                    Console.WriteLine("All done!");
                    Console.ReadKey();
                    Game.Menu();
                }
            }
        }
    }
}
