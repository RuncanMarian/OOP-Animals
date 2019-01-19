using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    interface IWalk
    {
        int MaxWalkSpeed { get; set; }
        void Walk();
    }
}
