using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Vehicle
    {
        #region Fields
        private string _make;
        private string _model;
        private int _year;
        private float _weight;
        #endregion

        #region Properties
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }//end property Make

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }//end property Model

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }//end property Year

        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }//end property Weight
        #endregion

        #region Constructors
        public Vehicle()
        {

        }//end parameterless Constructor

        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }//end FQCTR
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("{0} {1} {2}, {3:n0}lbs",
                Year,
                Make,
                Model,
                Weight
                );
        }//end override ToString()
        #endregion
    }//end class
}//end namespace
