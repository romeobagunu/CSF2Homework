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

            #region Vehicle
            Console.WriteLine("\n-=-= Vehicle =-=-\n");

            Vehicle v1 = new Vehicle();
            v1.Make = "Mercedes-Benz";
            v1.Model = "560SEL";
            v1.Year = 1987;
            v1.Weight = 3594f;

            Console.WriteLine(v1);

            Console.WriteLine();

            Vehicle v2 = new Vehicle("Honda", "Accord", 2004, 3038f);

            Console.WriteLine(v2);

            #endregion

            #region Login
            Console.WriteLine("\n-=-= Login =-=-\n");

            Login l1 = new Login();
            l1.Username = "jgreensdale";
            l1.Password = "560SEL1987";

            Console.WriteLine(l1);

            Console.WriteLine();

            Login l2 = new Login("jdoe", "Accord2004");

            Console.WriteLine(l2);

            #endregion

        }//end Main()
    }//end class
}//end namespace
