using System.Collections.Generic;

namespace AddressBook.Models
{

public class Contact
{
    private string _name;
    private string _phone;
    private string _address;




    public static void Index()
    {
      Contact hendrix = new Contact();
      hendrix._name = "Jimi Hendrix";
      hendrix._phone = "503-826-9371";
      hendrix._address = "208 SW 5th St. Portland, OR 97204";

      Contact elvis = new Contact();
      elvis._name = "Elvis Presley";
      elvis._phone = "617-356-3571";
      elvis._address = "Graceland, TN";

      Contact einstein = new Contact();
      einstein._name = "Albert Einstein";
      einstein._phone = "415-738-4935";
      einstein._address = "3718 MLK Blvd. Oakland, CA 94609";

      List<Contact> Contacts = new List<Contact>() { hendrix, elvis, einstein };
    }
}
}
