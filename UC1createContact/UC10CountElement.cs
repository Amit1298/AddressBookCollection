using System;
using System.Collections.Generic;
using System.Linq;

namespace UC10CountElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Contact1 = new Dictionary<string, string>();
            Contact1.Add("FirstName", "Sumit");
            Contact1.Add("LastName", "Kumar");
            Contact1.Add("Address", "KalndiVihar");
            Contact1.Add("City", "Mathura");
            Contact1.Add("City1", "Agra");
            Contact1.Add("State", "Uttar Pradesh");
            Contact1.Add("PhoneNumber", "7017362779");
            Contact1.Add("Email", "Sumitkr1612@gmail.com");
            Contact1.Add("State1", "Punjab");
            Contact1.Add("State2", "Bihar");



            foreach (var element in Contact1)
            {
                Console.WriteLine("{0}:  {1}", element.Key, element.Value);
            }
            Console.WriteLine("-----------------------------------------------");
            var countState = Contact1.Where(p => p.Key.Contains("State")).Count();
            Console.WriteLine("Count the State: " + countState);
            var countCity = Contact1.Where(p => p.Key.Contains("City")).Count();
            Console.WriteLine("Count the City: " + countCity);
        }
    }
}
