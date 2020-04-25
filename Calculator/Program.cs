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
            string FirstName, LastName;
            //char valueConverter = 'a';
            //string FirstName = "rani", LastName = "mahaveer";
            //Console.WriteLine((int)valueConverter);
            //Console.WriteLine("My full name is {0} {1}", FirstName, LastName);
            //Console.ReadLine(); 
            //FirstName=Console.ReadLine();
            //LastName= Console.ReadLine();
            //Program ps = new Program();
            //Console.ReadLine();
            //ps.addName(FirstName, LastName);
            FullName();
            Console.ReadLine();

        }
        //void addName(string firstname, string lastname)
        //{
        //    Console.ReadLine("Enter the value for the first name", firstname);
        //    Console.ReadLine("Enter the value for the first name", lastname);
        //    Console.WriteLine("My full name is {0} {1}", firstname, lastname);
        //}       

        static void FullName( )
        {
            //Console.ReadLine("Enter the value for the first name", firstname);
            //Console.ReadLine("Enter the value for the first name", lastname);
             string firstname = Console.ReadLine();
             string lastname = Console.ReadLine();
            Console.WriteLine("My full name is {0} {1}", firstname, lastname);
            Console.ReadLine();
        }
    }
}
