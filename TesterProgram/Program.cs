using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "--== CSF2 Homework - Data Type Classes ==--";

            #region Student
            Console.WriteLine("\n-=-= Student =-=-\n");

            Student s1 = new Student();
            s1.FirstName = "Jerry";
            s1.LastName = "Greensdale";
            s1.ID = "jgreensdale";
            s1.GPA = 3.66f;
            Console.WriteLine(s1);

            Console.WriteLine();

            Student s2 = new Student("John", "Doe", "jdoe", 3.52f);
            Console.WriteLine(s2);
            #endregion


        }//end Main()
    }//end class
}//end namespace
