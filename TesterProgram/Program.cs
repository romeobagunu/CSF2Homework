using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "--== CSF2 Homework - Data Type Classes ==--";

            #region Student
            Console.WriteLine("\n-=-= Student =-=-\n");

            Student s1 = new Student();
            s1.FirstName = "Jerry";
            s1.LastName = "Greensdale";
            s1.ID = "jgreensdale";
            s1.GPA = 3.66f;
            Console.WriteLine(s1);

            Console.WriteLine();

            Student s2 = new Student("John", "Doe", "jdoe", 3.52f);
            Console.WriteLine(s2);
            #endregion

            #region Vehicle
            Console.WriteLine("\n-=-= Vehicle =-=-\n");

            Vehicle v1 = new Vehicle();
            v1.Make = "Mercedes-Benz";
            v1.Model = "560SEL";
            v1.Year = 1987;
            v1.Weight = 3594f;

            Console.WriteLine(v1);

            Console.WriteLine();

            Vehicle v2 = new Vehicle("Honda", "Accord", 2004, 3038f);

            Console.WriteLine(v2);

            #endregion

            #region Login
            Console.WriteLine("\n-=-= Login =-=-\n");

            Login l1 = new Login();
            l1.Username = "jgreensdale";
            l1.Password = "560SEL1987";

            Console.WriteLine(l1);

            Console.WriteLine();

            Login l2 = new Login("jdoe", "Accord2004");

            Console.WriteLine(l2);

            #endregion

            #region ContactInfo
            Console.WriteLine("\n-=-= Contact Information =-=-\n");

            ContactInfo contact1 = new ContactInfo();
            contact1.StreetAddress = "15937 Forest Ave";
            contact1.City = "Kansas City";
            contact1.State = "Missouri";
            contact1.Zip = "64129";
            contact1.Phone = "816-132-3240";
            contact1.Email = "jgreensdale@outlook.com";

            Console.WriteLine(contact1);

            ContactInfo contact2 = new ContactInfo("92358 Lincoln St", "Shawnee", "Kansas", "66202", "913-064-8496", "jdoe@outlook.com");

            Console.WriteLine(contact2);

            #endregion

            #region Customer
            Console.WriteLine("\n-=-= Customers =-=-\n");
            Customer customer1 = new Customer();
            customer1.CustomerID = "JG01";
            customer1.FirstName = "Jerry";
            customer1.LastName = "Greensdale";
            customer1.ContactInformation = contact1;

            Console.WriteLine(customer1);

            Customer customer2 = new Customer("JD02", "John", "Doe", contact2);

            Console.WriteLine(customer2);
            #endregion

            #region CreditCardAccount
            Console.WriteLine("\n-=-= Credit Card Accounts =-=-\n");

            CreditCardAccount account1 = new CreditCardAccount();
            account1.AccountNumber = 5002411;
            account1.CustomerInfo = customer1;
            account1.Balance = 1350.23m;
            account1.IsPastDue = true;
            account1.AnnualInterestRate = 24.99m;

            Console.WriteLine(account1);

            CreditCardAccount account2 = new CreditCardAccount(5003201, customer2, 240.12m, false, 24.99m);

            Console.WriteLine(account2);

            #endregion

            #region Books
            Console.WriteLine("\n-=-= Books =-=-\n");

            Book b1 = new Book();
            b1.Title = "Dispensational Truth";
            b1.Author = "Clarence Larkin";
            b1.NumberOfPages = 336;

            Console.WriteLine(b1);

            Book b2 = new Book("Rightly Dividing the Word of Truth", "C.I. Scofield", 72);

            Console.WriteLine(b2);
            #endregion

            #region Library
            Console.WriteLine("\n--==--==** LIBRARY **==--==--\n");

            List<Book> libraryInventory1 = new List<Book>();
            libraryInventory1.Add(b1);
            libraryInventory1.Add(b2);

            Library livingFaithLibrary = new Library();
            livingFaithLibrary.Books = libraryInventory1;
            livingFaithLibrary.LibraryName = "Living Faith Library";
            livingFaithLibrary.StreetAddress = "3953 Walnut St";
            livingFaithLibrary.City = "Kansas City";
            livingFaithLibrary.State = "MO";
            livingFaithLibrary.ZIP = "64111";

            Console.WriteLine(livingFaithLibrary);

            Book b3 = new Book("Morning and Evening", "C.H. Spurgeon", 768);
            Book b4 = new Book("The Treasury of David", "C.H. Spurgeon", 8762);

            List<Book> libraryInventory2 = new List<Book>();
            libraryInventory2.Add(b3);
            libraryInventory2.Add(b4);

            Library spurgeonLibrary = new Library(libraryInventory2, "Spurgeon Library", "5001 North Oak Trafficway", "Kansas City", "MO", "64118");

            Console.WriteLine(spurgeonLibrary);

            #endregion

            #region Songs

            Song sng1 = new Song();
            sng1.Title = "Slave Name";
            sng1.Artist = "Kanye West ft. Ant Clemons";
            sng1.LengthInSeconds = 243;

            Console.WriteLine(sng1);

            Song sng2 = new Song("Kanye West ft. Ant Clemons", "Hurricane", 165);

            Console.WriteLine(sng2);

            #endregion

            #region Artists

            List<Song> trackList1 = new List<Song>();
            trackList1.Add(sng1);
            trackList1.Add(sng2);

            Artist artist1 = new Artist();
            artist1.Title = "Kanye West";
            artist1.Genre = "Hip Hop / Rap";
            artist1.Tracks = trackList1;

            Console.WriteLine("\n" + artist1);

            Song sng3 = new Song("Pinegrove", "The Alarmist", 242);
            Song sng4 = new Song("Pinegrove", "Light On", 219);

            List<Song> trackList2 = new List<Song>();
            trackList2.Add(sng3);
            trackList2.Add(sng4);

            Artist artist2 = new Artist(trackList2, "Pinegrove", "Indie Rock");

            Console.WriteLine("\n" + artist2);

            #endregion

            #region Motor Homes

            MotorHome mh1 = new MotorHome();
            mh1.Make = "Coachmen RV";
            mh1.Model = "Freelander";
            mh1.Year = 2021;
            mh1.Weight = 10156f;
            mh1.NumberOfBeds = 3;

            Console.WriteLine(mh1);

            MotorHome mh2 = new MotorHome("Winnebago", "Intent 28Y", 2021, 18000f, 1);

            Console.WriteLine(mh2);

            #endregion

            #region Trucks

            Truck trk1 = new Truck();
            trk1.Make = "Ford";
            trk1.Model = "F-150 XL";
            trk1.Year = 2022;
            trk1.Weight = 4363f;
            trk1.LoadCapacityLbs = 3325f;

            Console.WriteLine(trk1);

            Truck trk2 = new Truck("Chevrolet", "Silverado 1500", 2022, 4603f, 9200f);

            Console.WriteLine(trk2);

            #endregion

        }//end Main()
    }//end class
}//end namespace
