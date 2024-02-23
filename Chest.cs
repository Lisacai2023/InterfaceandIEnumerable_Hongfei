using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceandIEnumerable_Hongfei
{
    internal class Chest : IOpen
    {
        public void Open()
        {
            Console.WriteLine($"The chest is opening to " + IOpen._maxRotation + " degree");
        }
    }
}
