using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIntro
{
    internal class Student
    {
        public virtual void GetAdmission()
        {
            Console.WriteLine("Age should be 5 Year");
        }

    }
    class StudentSports: Student
    {

        public override void GetAdmission()
        {
            Console.WriteLine("Age should be 10 Year");
        }
        public void LetsPlay()
        {
            Console.WriteLine("Playing is going on");
        }
    }
    class AdmissionProgram
    {
        static void Main()
        {
            Student s1 = new StudentSports();
            s1.GetAdmission();
        }
    }
}
