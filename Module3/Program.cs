using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string MyName = "Jane";
            //int MyAge = 31;
            //bool HaveIPet = true;
            //double MyShoeSize = 37.5;

            //Console.WriteLine("Hello, world! This information from exercise 3.2.");
            //Console.WriteLine("My name is " + MyName);
            //Console.WriteLine("My age is " + MyAge);
            //Console.WriteLine("Do I have a pet? " + HaveIPet);
            //Console.WriteLine("My shoe size is " + MyShoeSize);

            //Console.WriteLine("This information about real me.");
            //Console.WriteLine("My name is Pavel");
            //Console.WriteLine("My age is 31");
            //Console.WriteLine("I don't have a pet");
            //Console.WriteLine("My shoe size is 42");

            Console.WriteLine("EXERCISE 3.7.\n");
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            if (age == 31)
            {
                Console.WriteLine("That's a greate age!");
            }
            Console.WriteLine("Your name is {0} and age is {1}", name, age);
            //Console.WriteLine("What is your favorite day of week?");
            //DayOfWeek favDay = (DayOfWeek)int.Parse(Console.ReadLine());
            //Console.WriteLine("Your favorite day is " + favDay);
            Console.WriteLine("Enter your birthdate: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Your birthdate is " + birthdate);
            Console.ReadKey();
        }
    }
}
