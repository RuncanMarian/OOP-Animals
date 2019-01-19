using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    public class Birds : Animals
    {
        private int wingLenght;
        public int WingLenght
        {
            get
            {
                return this.wingLenght;
            }

            set
            {
                if (value > 0)
                {
                    wingLenght = value;
                }
                else
                {
                    wingLenght = 0;
                }
            }
        }




        public Birds(string name) : base(name)
        {

            

        }


        public override string ToString()
        {
            return string.Format($"This is {Name} and has the wings lenght of {wingLenght}");
        }


    }
}
