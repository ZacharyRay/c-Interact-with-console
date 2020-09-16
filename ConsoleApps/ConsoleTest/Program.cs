using System;
using ConsoleTest.Models;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hejsa whats your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hvor kommer du fra?");
            string by = Console.ReadLine();

            Console.WriteLine("Hvor gammel er du?");
            int age = CalculateAge(Console.ReadLine());

            User myUser = new User();
            myUser.Name = name;
            myUser.City = by;
            myUser.Age = age;

            Console.WriteLine($"Du hedder {myUser.Name}, Du kommer fra {myUser.City} og næste år bliver du {myUser.Age + 1} år gammel");
        }

        protected static int CalculateAge(string age)
        {
            int result = 0;
            // vi forsøger at parse brugerens input til int
            try
            {
                result = int.Parse(age);
            }
            catch
            {

            }
            return result;
        }
    }
}