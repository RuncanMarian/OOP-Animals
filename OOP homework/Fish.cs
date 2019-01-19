using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    public class Fish : Animals
    {
        public Fish (string name) : base(name)
        {

        }

        public override string ToString()
        {
            return string.Format($"This is {Name} and has a speed ");
        }
    }
}
