using System;
using System.Collections.Generic;
using System.Text;

namespace restaurant
{
    interface IDish
    {
        string Name { get; set; }
        void Cook();

        int Number { get; set; }


    }
}
