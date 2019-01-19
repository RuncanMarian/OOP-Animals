using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pinguin pinguin = new Pinguin("Lex") {WingLenght = 2, MaxWalkSpeed = 5 };
            
            List<Animals> animals = new List<Animals>();

            animals.Add(pinguin);
            pinguin.Walk();

            foreach (var item in animals)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
