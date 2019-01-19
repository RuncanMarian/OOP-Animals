using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    public class Insects : Animals
    {
        public Insects(string name) : base(name)
        {

        }

        public override string ToString()
        {
            return string.Format($"This is {Name} and has a speed o");
        }
    }
}
