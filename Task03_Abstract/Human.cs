using System;
using System.Collections.Generic;
using System.Text;

namespace Task03_Abstract
{
    abstract class Human
    {
        public void Speak()
        {
            Console.WriteLine("La-La");
        }
        public abstract void Sing();
       

    }
}
