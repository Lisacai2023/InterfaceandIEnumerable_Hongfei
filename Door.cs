using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceandIEnumerable_Hongfei
{
    internal class Door : IOpen
    {
        //method signature
        public void Open()
        {
            Console.WriteLine($"The door is opening to " + IOpen._maxRotation + " degree");
        }
    }
}
