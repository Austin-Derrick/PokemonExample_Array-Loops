using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPokemon
{
    class Character
    {
        public string name;
        public int age;
        public Pokemon[] pokemon = new Pokemon[6];
        public Character()
        {
            name = "";
            age = 0;
            for (int i = 0; i < pokemon.Length; i++)
            {
                pokemon[i] = new Pokemon();
            }
        }

        public Character(string Name)
        {
            name = Name;
        }

        public void setName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());
        }

        public string getName()
        {
            return name;
        }
    }
}
