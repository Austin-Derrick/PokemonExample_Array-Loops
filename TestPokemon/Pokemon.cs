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

        public Pokemon()
        {
            name = "Pokemon Name";
            type = "Pokemon Type";
            health = 100;
            description = "Pokemon Description";
            phrase = "Pokemon Phrase";
        }
        public Pokemon(string Name, string Type, string Description, string Phrase, string move1, string move2)
        {
            name = Name;
            type = Type;
            health = 100;
            description = Description;
            phrase = Phrase;
        }

        public void printMoves()
        {

        }
    }
}
