using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenManagementSystem
{
    internal class Student
    {
        public Student(string n, float matric, float inter,float ecat)
        {
            sname = n;
            matricMarks = matric;
            fscmarks = inter;
            ecatMarks = ecat;
        }
        public string sname;
        public float matricMarks;
        public float fscmarks;
        public float ecatMarks;
        public float aggregate;
    }
}
