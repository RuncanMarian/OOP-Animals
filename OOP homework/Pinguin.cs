using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    public class Pinguin : Birds, IWalk
    {
        public Pinguin(string name) : base(name)
        {

        }
       

        private int maxSpeed;

        public int MaxWalkSpeed
        {
            get
            {
                return this.maxSpeed;
            }
            set
            {
                //maxSpeed = (value > 0 ? value : 0);
                if (value > 0)
                {
                    maxSpeed = value;

                }
                else
                {
                    maxSpeed = 0;
                }

            }
        }

        public void Walk()
        {
            Console.WriteLine($"I'm pinguin, but i'm a bird and I walk with maximum speed {MaxWalkSpeed}");
        }
    }
}
