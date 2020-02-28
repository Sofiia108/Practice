using System;
using System.Collections.Generic;
using System.Text;

namespace restaurant
{
    class Cooker
    {
        
        public Dish CreateDish(int number)
        {
           
            switch (number)
            {
                case 1:
                    return new Pizza("Pizza paperoni", 1);
                case 2:
                    return new ScrumbledEggs("Scrumbled eggs", 2);
                case 3:
                    return new CheeseSoup("Cheese Soup", 3);
                case 4:
                    return new Salad("Salad", 4);
                case 5:
                    return new Sushi("Sushi philadelphia", 5);
                case 6:
                    return new Noodls("Noodls", 6);
                default:
                    return null;
            }
                
        }
    }

}
