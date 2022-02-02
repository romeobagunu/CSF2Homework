using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //No FIELDS - Automatic Properties w/ no business rules
        #region Properties
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }
        #endregion
        #region Constructors
        public Customer(string customerID, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }//FQCTR
        public Customer() { }//Default Constructor 
        #endregion
        #region Methods
        public override string ToString()
        {
            return string.Format("Customer: {0}, {1}\n" +
                "ID: #{2}\n" +
                "{3}",
                LastName,
                FirstName,
                CustomerID,
                ContactInformation);
        }//end override ToString()
        #endregion
    }
}
