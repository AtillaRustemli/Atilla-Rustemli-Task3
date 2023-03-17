using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustemliAtillaTask3
{
    internal class Student
    {
         public string name;
        public string surname;
        public string speciality;
        public string groupNo;
        public int age;

        public override string ToString()
        {
            return $"{name} {surname} {speciality} {groupNo} {age} ";
        }
    }
}
