using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        #region Fields
        private decimal _balance;
        #endregion
        #region Properties
        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }//TODO: Research interest rates and develop business rules for setting the correct interest rate for a credit card account.
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }//end if - If the value is greater than or equal to 0, assigns the value.
                else
                {
                    _balance = 0;
                }//end else - If the value is less than 0, assigns zero.
            }//end set - Business rule: The balance on a Credit Card cannot be less than zero. So if a negative balance is entered, the balance is set to zero.
        }//end property Balance
        #endregion
        #region Constructors
        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
            Balance = balance;
        }//end FQCTR
        public CreditCardAccount() { }//Default Constructor
        #endregion
        #region Methods
        public override string ToString()
        {
            return string.Format("Customer: {0}, {1}\n" +
                "Account Number: {2}\n" +
                "Balance: {3:c}\n" +
                "Annual Interest Rate: {4:n2}%" +
                "\nNotes:\n\t{5}\n",
                CustomerInfo.LastName,
                CustomerInfo.FirstName,
                AccountNumber,
                Balance,
                AnnualInterestRate,
                IsPastDue ? "!! PAST DUE !!" : "No payments past due.");
        }//end override ToString()
        #endregion
    }//end class
}//end namespace
