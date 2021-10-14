using System;
using System.Collections.Generic;

namespace UC3editContactDetails
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

            Console.WriteLine("----------------------------------------------");
            Contact.Remove("City");
            Console.WriteLine(" After Edited City will be Removed");
            foreach (var element in Contact)
            {
                Console.WriteLine("{0}:  {1}", element.Key, element.Value);
            }
        }
    }
}
