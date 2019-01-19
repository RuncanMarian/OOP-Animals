using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    public abstract class Animals
    {
        public string Name { get; set; }
        //public int Speed { get; set; }
        //public MovingType MovingType { get; set; }


        public Animals(string name)
        {


            this.Name = name;
            

        }




    }

    /*public enum MovingType 
        {
          walk,
          swim,
          crawl,
          Fly
        }*/






}
