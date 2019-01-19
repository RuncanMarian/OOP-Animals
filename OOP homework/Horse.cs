using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    public class Horse : Mammals, IWalk, ISwim
    {
        public Horse(string name):base(name)
        {

        }
        private int maxWalkSpeed;
        public int MaxWalkSpeed
        { get
            {
                return maxWalkSpeed;
                
            }

            set
            {
                if (value > 0)
                {
                    MaxWalkSpeed = value;
                }
                else
                {
                    MaxWalkSpeed = 0;
                }
            }
        }
        public int swimSpeed { get; set;}

        public void Swim()
        {
            
        }

        public void Walk()
        {
            
        }
    }
}
