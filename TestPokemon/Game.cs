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
        public Pokemon[] starterPokemon = new Pokemon[3];
        public Game()
        {
            starterPokemon[0] = squirtle;
            starterPokemon[1] = charmander;
            starterPokemon[2] = bulbasaur;
            StartGame();
        }

        public void StartGame()
        {
            int playerInput = 0;
            Console.WriteLine("Welcome to the wonderful land of pokemon");
            Console.ReadKey();
            Console.WriteLine("Please choose a pokemon to begin:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1})\n\t{starterPokemon[i].name}\n\t\tType: {starterPokemon[i].type}\n\t\tDescription: {starterPokemon[i].description}");
                starterPokemon[i].printMoves();
            }
            playerInput = int.Parse(Console.ReadLine());
            switch (playerInput)
            {
                case 1:
                    player.pokemon[0] = squirtle;
                    break;
                case 2:
                    player.pokemon[0] = charmander;
                    break;
                case 3:
                    player.pokemon[0] = bulbasaur;
                    break;
            }
            Console.WriteLine($"Nice choice: {player.pokemon[0].name} is a great pokemon");
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
                    Console.WriteLine($"{ player.pokemon[0].name} says: {player.pokemon[0].phrase}");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
