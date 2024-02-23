using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceandIEnumerable_Hongfei
{
    internal interface IOpen
    {
        //Fields
        const double _maxRotation = 120;
        const double _minRotation = 0;
        
        //Method Signature
        public void Open();
    }
}
