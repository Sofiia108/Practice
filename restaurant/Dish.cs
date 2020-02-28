using System;
using System.Collections.Generic;
using System.Text;

namespace restaurant
{
    class Dish:IDish
    {

        public string Name { get; set; }
        public int Number { get; set; }

        public Dish(string name, int number)
        {
            Name = name;
            Number = number;
        }

        

        public void Cook()
        {
            Console.WriteLine($"{Name} is cooking");
        }

    }
}
