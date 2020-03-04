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
        public Character()
        {
            name = "";
            age = 0;
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
