using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Welcome To Address Book====");
            AddressBookLibrary bookLibrary = new AddressBookLibrary();
            bookLibrary.AddressBookMenu();
            Console.ReadLine();
        }

    }
}   