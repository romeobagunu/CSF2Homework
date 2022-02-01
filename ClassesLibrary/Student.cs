using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {
        #region Fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;
        #endregion

        #region Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }//end property FirstName

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }//end property LastName

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }//end property ID

        public float GPA
        {
            get { return _gpa; }
            set { _gpa = value; }
        }//end property GPA
        #endregion

        #region Constructors
        public Student()
        {

        }//end Parameterless Constructor

        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            GPA = gpa;
        }//end FQCTR
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("First Name: {0}" +
                "\nLast Name: {1}" +
                "\nID: {2}" +
                "\nGPA: {3:n2}",
                FirstName,
                LastName,
                ID,
                GPA);
        }//end override ToString()
        #endregion
    }//end class
}//end namespace
