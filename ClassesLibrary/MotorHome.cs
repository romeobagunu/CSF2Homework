using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class MotorHome : Vehicle
    {
        //FIELDS
        //Unique Attributes: NumberOfBeds

        //PROPS
        public int NumberOfBeds { get; set; }

        //CTORS
        public MotorHome(string make, string model, int year, float weight, int numberOfBeds) : base(make, model, year, weight)
        {
            NumberOfBeds = numberOfBeds;
        }//end FQCTOR
        public MotorHome()
        {

        }//end Default CTOR

        //Methods
        public override string ToString()
        {
            return base.ToString() + $"\nMotor Home | Number of Beds: {NumberOfBeds}";
        }//end override ToString()
    }//end class
}//end namespace
