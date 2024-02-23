using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceandIEnumerable_Hongfei
{
    internal class Bottle : IOpen
    {
        public void Open()
        {
            Console.WriteLine($"The bottle is opening to " + IOpen._maxRotation + " degree");
        }
    }
}
