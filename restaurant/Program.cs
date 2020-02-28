using System;

namespace restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our restaurant");
            Console.WriteLine("Choose your dish, please");

            string[] dishes = { "Pizza", "Scrumbled eggs", "Cheese Soup", "Salad", "Sushi", "Noodls" };

            

            for(int i=0; i<dishes.Length; i++)
            {
                Console.WriteLine(dishes[i]);
            }
            string userInput = Console.ReadLine();

            int number;

            bool success = Int32.TryParse(userInput, out number);

            Cooker cooker = new Cooker();
            Dish dish = cooker.CreateDish(number);
            dish.Cook();


  
        }
    }
}
