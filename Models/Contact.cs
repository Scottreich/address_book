using System.Collections.Generic;

namespace AddressBook.Models
{
    public class Contact
    {
        private string _name;
        private string _phone;
        private string _address;
    }

        public Contact(string name, string phone, string address)
        {
          _name = name;
          _phone = phone;
          _address = address;
        }
}
