using System;
using System.Data;

namespace AddressbookLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book Linq");
            // UC 1 Create a new table
            AddressBookTable addressBookTable = new AddressBookTable();
            addressBookTable.GetAllContacts();
            // UC4
            addressBookTable.EditExistingContact("ak", "ku", "PhoneNumber", "1234566");
            //uc5//
            addressBookTable.DeleteContact("dac", "chicha");

        }
    }
}
