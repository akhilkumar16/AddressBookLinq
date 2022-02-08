using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            table.Rows.Add("ak", "ku", "ta, ha", "ha", "hyd", "1234566", "1245638", "akku@gmail.com");
            table.Rows.Add("dac", "chicha", "seceb", "hnk", "ap", "1452638", "45215689", "dac@gmail.com");
            
        }
        public void GetAllContacts()
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.HelpLink);
            }
        }

        //UC4//
        public void EditExistingContact(string firstName, string lastName, string column, string newValue)
        {                                                                  
            DataRow contact = table.Select("FirstName = '" + firstName + "' and LastName = '" + lastName + "'").FirstOrDefault();
            contact[column] = newValue;
            Console.WriteLine("Record successfully Edited");
            GetAllContacts();
        }
        // UC5//
        public void DeleteContact(string firstName, string lastName)
        {
            try
            {
                DataRow contact = table.Select("FirstName = '" + firstName + "' and LastName = '" + lastName + "'").FirstOrDefault();
                table.Rows.Remove(contact);
                Console.WriteLine("Record Successfully Deleted");
                GetAllContacts();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //uc6//
        public void RetrieveByCityOrState(string city, string state)
        {
            var retrieveData = from records in table.AsEnumerable()
                               where records.Field<string>("City") == city || records.Field<string>("State") == state
                               select records;
            Console.WriteLine("\nRetrieve contact details by city or state name");
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
