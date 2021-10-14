using System;
using System.Collections.Generic;

namespace UC2AddPersonDetailsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Contact = new Dictionary<string, string>();
            Contact.Add("FirstName", "Amit");
            Contact.Add("LastName", "Kumar");
            Contact.Add("Address", "DefenceColony");
            Contact.Add("City", "Agra");
            Contact.Add("State", "Uttar Pradesh");
            Contact.Add("PhoneNumber", "9897139203");
            Contact.Add("Email", "Amitkr2403@gmail.com");

            foreach (var element in Contact)
            {
                Console.WriteLine("{0}:  {1}", element.Key, element.Value);
            }
        }
    }
}
