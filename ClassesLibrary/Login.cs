using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        #region Fields
        private string _username;
        private string _password;
        #endregion

        #region Properties
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }//end property Username

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }//end property Password
        #endregion

        #region Constructors
        public Login()
        {

        }//end parameterless constructor

        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }//end FQCTR
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("\nUsername: {0}\nPassword: {1}\n",
                Username,
                Password);
        }//end override ToString()
        #endregion
    }//end class
}//end namespace
