using System;

namespace Task01_ParfumeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] locker = new string[2, 3];
            locker[0, 0] = "Fendy";
            locker[0, 1] = "Versace";
            locker[0, 2] = "Gucci";
            locker[1, 0] = "Invictus";
            locker[1, 1] = "№13";
            Console.WriteLine("Enter the last parfume");
            locker[1, 2] = Console.ReadLine();
            for (var j = 0; j <= locker.GetUpperBound(0); j++)
            {
                Console.WriteLine();
                for (var i = 0; i <= locker.GetUpperBound(1); i++)
                    Console.Write($"[{i}],[{j}] {locker[j, i]} \t\t");
            }





        }
    }
}
