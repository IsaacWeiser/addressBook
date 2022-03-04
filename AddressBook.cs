using System;
using System.Collections.Generic;

namespace addressBook
{
    public class AddressBook
    {

        //property
        public Dictionary<string, Contact> Rolodex { get; set; }


        //constructor
        public AddressBook()
        {
            Rolodex = new Dictionary<string, Contact>();
        }

        //method that adds a contact to the dictionary
        public void AddContact(Contact person)
        {

            Rolodex.Add(person.Email, person);
        }

        //method that gets contact by email
        public Contact GetByEmail(string email)
        {

            return Rolodex[$"{email}"];
        }
    }

}