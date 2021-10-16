using System;
using System.Collections.Generic;

namespace UC9AbilitytoCiySatate
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

            Console.WriteLine("---------------------------------------------");

            if (Contact1.ContainsKey("City"))
            {
                Console.WriteLine("Search the City is Present or Not : City is Persent");
            }
            else
            {
                Console.WriteLine("Search the City is Present or Not : City is not Persent");
            }

            if (Contact1.ContainsKey("State"))
            {
                Console.WriteLine("Search the State is Present or Not : State is Persent");
            }
            else
            {
                Console.WriteLine("Search the State is Present or Not : State is not Persent");
            }

        }
    }
}
