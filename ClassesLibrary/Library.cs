using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        //FIELDS
        //No Business Rules.

        //PROPERTIES
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }

        //CTORS
        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            ZIP = zip;
        }//end FQCTOR
        public Library()
        {

        }//end Default CTOR

        //METHODS
        public override string ToString()
        {
            string booksInventory = "";

            foreach (Book b in Books)
            {
                booksInventory += string.Format("{0}\n", b);
            }

            return string.Format("{0}\n\n" +
                "Address: \t{1}\n" +
                "\t\t{2}, {3} {4}\n\n" +
                "Books:\n{5}",
                LibraryName,
                StreetAddress,
                City,
                State,
                ZIP,
                booksInventory);
        }//end override ToString();
    }//end class
}//end namespace
