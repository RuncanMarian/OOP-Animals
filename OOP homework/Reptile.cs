using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    public class Reptile : Animals
    {
        public Reptile(string name) : base(name)
        {

        }

        public override string ToString()
        {
            return string.Format($"This is {Name} and has a speed ");
        }


    }
}
