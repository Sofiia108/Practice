using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Task_CompareTo
{
    class Boy : IComparable<Boy>
    {
        public int Behavior { get; set; }
        public int SumGirls { get; set; }
        public string Name { get; set; }
        public Boy(int behavior, int sumGirls, string name)
        {
            Behavior = behavior;
            SumGirls = sumGirls;
            Name = name;
        }

        public int CompareTo(Boy other)
        {
            int sum = this.Behavior + this.SumGirls;
            int sumOther = other.Behavior + other.SumGirls;
            int result = sum.CompareTo(sumOther);
            return result;
            
            /*if (this.Behavior  > other.Behavior)
            {
                return 1;
            }
            
            else if (this.SumGirls < other.SumGirls)
            {
                return 1;
            }

            else if (this.Behavior < other.Behavior)
            {
                return -1;
            }

            else if (this.SumGirls > other.SumGirls)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            */
        }
             public override string ToString()
        {
            return $"{this.Name} {this.Behavior} {this.SumGirls}";
        }
    }
}


