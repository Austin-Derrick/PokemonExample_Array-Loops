using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPokemon
{
    class Pokemon
    {
        public string name;
        public string type;
        public int health;
        public string description;
        public string phrase;
        public string[] moves = new string[4];

        public Pokemon()
        {
            name = "Pokemon Name";
            type = "Pokemon Type";
            health = 100;
            description = "Pokemon Description";
            phrase = "Pokemon Phrase";
            moves[0] = "Slash";
            moves[1] = "Quick Attack";
            moves[2] = "";
            moves[3] = "";
        }
        public Pokemon(string Name, string Type, string Description, string Phrase, string move1, string move2)
        {
            name = Name;
            type = Type;
            health = 100;
            description = Description;
            phrase = Phrase;
            moves[0] = move1;
            moves[1] = move2;
            moves[2] = "";
            moves[3] = "";
        }

        public void printMoves()
        {
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] != "")
                {
                    Console.Write($"\t\tMove {i + 1}: {moves[i]}\n");
                }
            }
        }
    }
}
