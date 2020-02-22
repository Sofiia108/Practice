using System;
using System.Collections.Generic;
using System.Text;

namespace Task02_OOP
{
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }
}
