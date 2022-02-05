using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Truck : Vehicle
    {
        //FIELDS
        //PROPS
        public float LoadCapacityLbs { get; set; }

        //CTORS
        public Truck(string make, string model, int year, float weight, float loadCapacityLbs) : base (make, model, year, weight)
        {
            LoadCapacityLbs = loadCapacityLbs;
        }//end FQCTOR
        public Truck()
        {

        }//end default ctor

        //METHODS
        public override string ToString()
        {
            return base.ToString() + $"\nTruck | Load Capacity: {LoadCapacityLbs:n0}lbs";
        }
    }//end class
}//end namespace
