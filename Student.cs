using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagrutListLab
{
    public class Student
    {
        private int grade;
        private string name;
        public Student(int grade, string name)
        {
            this.grade = grade;
            this.name = name;
        }
        public int GetGrade()
        {
            return this.grade;
        }
        public string GetName()
        {
            return this.name;
        }
        public override string ToString()
        {
            return '('+this.grade+","+this.name+")";
        }

    }
}
