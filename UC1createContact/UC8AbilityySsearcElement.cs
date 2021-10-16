using System;
using System.Collections.Generic;
using System.Linq;

namespace UC8AbilityySsearcElement
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
            Contact1.Add("State", "Uttar Pradesh");
            Contact1.Add("PhoneNumber", "7017362779");
            Contact1.Add("Email", "Sumitkr1612@gmail.com");



            foreach (var element in Contact1)
            {
                Console.WriteLine("{0}:  {1}", element.Key, element.Value);
            }

            Console.WriteLine("........................................ \n");
            var search = Contact1.Where(p => p.Key.Contains("City"));

            foreach (var result in search)
            {
                Console.WriteLine("Contact Name: {0}, {1}", result.Key, result);
            }
            Console.WriteLine();
            var search1 = Contact1.Where(p => p.Key.Contains("State"));
            foreach (var result1 in search1)
            {
                Console.WriteLine("Contact Name: {0}, {1}", result1.Key, result1);
            }
        }
    }
}
