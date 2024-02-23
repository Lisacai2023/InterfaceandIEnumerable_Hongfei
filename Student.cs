using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceandIEnumerable_Hongfei
{
    internal class Student
    {
        string _fistName;
        string _lastName;
        double _csiGrade;
        double _genEdGrad;

        public Student(string fistName, string lastName, double csiGrade, double genEdGrad)
        {
            _fistName=fistName;
            _lastName=lastName;
            _csiGrade=csiGrade;
            _genEdGrad=genEdGrad;
        }

        public double Average()
        {
            return (_csiGrade+_genEdGrad)/2.0;
        }

        public override string ToString()
        {
            return $"{_fistName} {_lastName} {_csiGrade}  {_genEdGrad}";
        }
    }
}
