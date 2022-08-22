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
            string MyName = "Jane";
            int MyAge = 31;
            bool HaveIPet = true;
            double MyShoeSize = 37.5;

            Console.WriteLine("Hello, world! This information from exercise.");
            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("My age is " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIPet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.WriteLine("This information about real me.");
            Console.WriteLine("My name is Pavel");
            Console.WriteLine("My age is 31");
            Console.WriteLine("I don't have a pet");
            Console.WriteLine("My shoe size is 42");

            Console.ReadKey();
        }
    }
}
