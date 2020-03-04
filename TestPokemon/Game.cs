using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPokemon
{
    class Game
    {
        public static Character player = new Character();
        public Pokemon squirtle = new Pokemon("squirtle", "water", "A turtle like pokemon", "SQUIRTLLLE!", "watergun", "slash");
        public Pokemon charmander = new Pokemon("charmander", "fire", "A Spicy boi", "Char Char!", "ember", "quick attack");
        public Pokemon bulbasaur = new Pokemon("bulbasaur", "grass", "A lizard that ate too many flowers", "Bulba bulb!", "leach seed", "slash");
        public Game()
        {
            StartGame();
        }

        public void StartGame()
        {
            int playerInput = 0;
            Console.WriteLine("Welcome to the wonderful land of pokemon");
            Console.ReadKey();
            Console.WriteLine("Please choose a pokemon to begin:");
            playerInput = int.Parse(Console.ReadLine());
            switch (playerInput)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
            Menu();
        }

        public static void Menu()
        {
            int menuInput = 0;
            Console.Clear();
            Console.WriteLine("What would you like to do?\n\t1: Battle\n\t2: Heal your pokemon\n\t3: Talk to your pokemon");
            menuInput = int.Parse(Console.ReadLine());
            switch (menuInput)
            {
                case 1:
                    break;
                case 2:
                    Pokecenter.Menu();
                    break;
                case 3:
                    Console.ReadKey();
                    break;
            }
        }
    }
}
