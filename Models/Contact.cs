using System.Collections.Generic;

namespace AddressBook.Models
{
        public class Contact
        {
          private string _name;
          private int _phone;
          private string _address;
        }

        public static void Main()
        {
          Contact hendrix = new Contact();
          hendrix.Name = "Jimi Hendrix";
          hendrix.Phone = "503-826-9371";
          hendrix.Address = "208 SW 5th St. Portland, OR 97204";

          Contact elvis = new Contact();
          elvis.Name = "Elvis Presley";
          elvis.Phone = "617-356-3571";
          elvis.Address = "Graceland, TN";

          Contact einstein = new Contact();
          einstein.Name = "Albert Einstein";
          einstein.Phone = "415-738-4935";
          einstein.Address = "3718 MLK Blvd. Oakland, CA 94609";

        }
}
