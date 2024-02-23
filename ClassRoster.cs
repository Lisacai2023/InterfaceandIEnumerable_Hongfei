using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceandIEnumerable_Hongfei
{
    internal class ClassRoster : IEnumerable
    {
        List<Student> _classList;

        public ClassRoster()
        {
            _classList = new List<Student>();
        }

        internal List<Student> ClassList { get => _classList;}

        public void AddStudent(Student student)
        {
            _classList.Add(student);
        }

        public IEnumerator GetEnumerator()
        {
            return new ClassRosterEnumerator(ref _classList);
        }

        private class ClassRosterEnumerator : IEnumerator
        {
            int index = -1;
            List<Student> students;

            public ClassRosterEnumerator(ref List<Student> studentlist)
            {
                students = studentlist;
            }
            public object Current => students[index];

            public bool MoveNext()
            {
                index++;
                if (index >= students.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public void Reset()
            {
                index = -1; 
            }
        }


    }//Class
}//namespace
