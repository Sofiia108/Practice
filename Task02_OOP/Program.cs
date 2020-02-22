using System;

namespace Task02_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = { new Animal(), new Cat(), new Cat(), new Dog() };
            foreach(var animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
