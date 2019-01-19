using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    public class Mammals : Animals
    {
        public Mammals(string name) : base(name)
        {

        }

        private int weight;

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            { if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    weight = 0;
                }

            }
        }


        public override string ToString()
        {
            return string.Format($"This is {Name} and has a weight of {weight}");
        }

    }
}
