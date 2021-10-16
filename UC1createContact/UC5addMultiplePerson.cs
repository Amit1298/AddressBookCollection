using System;
using System.Collections.Generic;

namespace UC5addMultiplePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Sumit Details: \n");
            Sumit();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter the Sumit Details: \n");
            Amit();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter the Sumit Details: \n");
            Satty();
        }
        private static void Sumit()
        {
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

        private static void Amit()
        {
            Dictionary<string, string> Contact2 = new Dictionary<string, string>();
            Contact2.Add("FirstName", "Amit");
            Contact2.Add("LastName", "Kumar");
            Contact2.Add("Address", "DefenceColny");
            Contact2.Add("City", "Agra");
            Contact2.Add("State", "Uttar Pradesh");
            Contact2.Add("PhoneNumber", "9897139203");
            Contact2.Add("Email", "Amitkr2403@gmail.com");

            foreach (var element in Contact2)
            {
                Console.WriteLine("{0}:  {1}", element.Key, element.Value);
            }
        }

        private static void Satty()
        {
            Dictionary<string, string> Contact3 = new Dictionary<string, string>();
            Contact3.Add("FirstName", "Satty");
            Contact3.Add("LastName", "Kumar");
            Contact3.Add("Address", "Vihar");
            Contact3.Add("City", "Noida");
            Contact3.Add("State", "Uttar Pradesh");
            Contact3.Add("PhoneNumber", "73747829339");
            Contact3.Add("Email", "krSatty1612@gmail.com");

            foreach (var element in Contact3)
            {
                Console.WriteLine("{0}:  {1}", element.Key, element.Value);
            }
        }

    }
}
