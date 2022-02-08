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
            addressBookTable.EditExistingContact("ak", "ku", "PhoneNumber", "1234566");
            addressBookTable.RetrieveByCityOrState("hnk", "ap");
        }
    }
}
