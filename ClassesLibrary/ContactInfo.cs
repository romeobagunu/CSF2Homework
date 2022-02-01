using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class ContactInfo
    {
        #region Fields
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;
        #endregion

        #region Properties
        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }//end property StreetAddress

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }//end property City

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }//end property State

        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }//end property Zip

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }//end property Phone

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }//end property Email
        #endregion

        #region Constructors
        public ContactInfo()
        {

        }//end parameterless constructor

        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }//end FQCTR
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("\n\tContact Information:\n" +
                "\tAddress:\t{0}\n" +
                "\t\t\t{1}, {2} {3}\n" +
                "\tPhone:\t\t{4}\n" +
                "\tEmail:\t\t{5}",
                StreetAddress,
                City,
                State,
                Zip,
                Phone,
                Email);
        }//end override ToString()
        #endregion
    }//end class
}//end namespace
