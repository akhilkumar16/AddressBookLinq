﻿using System;
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
    }
}
