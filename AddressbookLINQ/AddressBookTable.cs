using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressbookLINQ
{
    class AddressBookTable
    {
        DataTable table = new DataTable("AddressBookSystem");
        public AddressBookTable()
        {
            table.Columns.Add("FirstName", typeof(string));  
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("Email", typeof(string));
        }
        public void GetAllContacts()
        {
            foreach (DataRow dr in table.AsEnumerable())
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:- " + dr.Field<string>("firstName"));
                Console.WriteLine("LastName:- " + dr.Field<string>("lastName"));
                Console.WriteLine("Address:- " + dr.Field<string>("address"));
                Console.WriteLine("City:- " + dr.Field<string>("city"));
                Console.WriteLine("State:- " + dr.Field<string>("state"));
                Console.WriteLine("Zip:- " + dr.Field<string>("zip"));
                Console.WriteLine("PhoneNumber:- " + dr.Field<string>("phoneNumber"));
                Console.WriteLine("Email:- " + dr.Field<string>("eMail"));
            }
        }
    }
}
