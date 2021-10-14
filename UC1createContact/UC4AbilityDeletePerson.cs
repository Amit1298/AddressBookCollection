using System;
using System.Collections.Generic;

namespace UC4AbilityDeletePerson
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
            Contact.Clear();
            foreach (var element in Contact)
            {
                Console.WriteLine("{0}:  {1}", element.Key, element.Value);
            }


            Console.WriteLine("-------------------------------------------");

            Dictionary<string, string> Contact1 = new Dictionary<string, string>();
            Contact1.Add("FirstName", "Sumit");
            Contact1.Add("LastName", "Kumar");
            Contact1.Add("Address", "KalndiVihar");
            Contact1.Add("City", "Mathura");
            Contact1.Add("State", "Uttar Pradesh");
            Contact1.Add("PhoneNumber", "7017362779");
            Contact1.Add("Email", "Sumitkr1612@gmail.com");

            foreach (var element in Contact1)
            {
                Console.WriteLine("{0}:  {1}", element.Key, element.Value);
            }
        }

    }
}
