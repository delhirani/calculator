using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {            
            FullName();
            Console.ReadLine();

        }
        //void addName(string firstname, string lastname)
        //{
        //    Console.ReadLine("Enter the value for the first name", firstname);
        //    Console.ReadLine("Enter the value for the first name", lastname);
        //    Console.WriteLine("My full name is {0} {1}", firstname, lastname);
        //}
        //static void FullName(string firstname, string lastname)
        //{
        //    Console.ReadLine("Enter the value for the first name", firstname);
        //    Console.ReadLine("Enter the value for the first name", lastname);
        //    Console.WriteLine("My full name is {0} {1}", firstname, lastname);
        //}

        static void FullName( )
        {           
             string firstname = Console.ReadLine();
             string lastname = Console.ReadLine();
            Console.WriteLine("My full name is {0} {1}", firstname, lastname);
            Console.ReadLine();
        }
    }
}
