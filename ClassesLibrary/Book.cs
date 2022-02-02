using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        #region Fields
        private int _numberOfPages;
        #endregion
        #region Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages
        {
            get { return _numberOfPages; }
            set
            {
                if (value > 0)
                {
                    _numberOfPages = value;
                }//end if
                else
                {
                    _numberOfPages = 1;
                }//end else
            }//end set - Business rule: Sets the number of pages for any value greater than 0. If a negative value is given, sets the number of pages to 1 as a minimum page count for any book.
        }//end property NumberOfPages
        #endregion
        #region Constructors
        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }//end FQCTOR
        public Book() { }//Default constructor
        #endregion
        #region Methods
        public override string ToString()
        {
            return string.Format("{0}\n" +
                "by {1}\n" +
                "Pages: {2:n0}",
                Title,
                Author,
                NumberOfPages);
        }//end override ToString()
        #endregion
    }//end class
}//end namespace
