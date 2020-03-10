using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Task_CompareTo
{
    class Program
    { 
        static void Main(string[] args)
        {
            var Boys = new List<Boy>();
            Boys.Add(new Boy(3, 3, "Pasha"));
            Boys.Add(new Boy(8, 5, "Ivan"));
            Boys.Add(new Boy(2, 0, "Andrii"));
            Boys.Sort();
            Boys.ForEach(Boys => Console.WriteLine(Boys));

        }

        
    }
}
