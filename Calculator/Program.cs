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
            Calculator.sum();
            Calculator.sum(55,354);
            Calculator.sum(55, 354.524f);
            Calculator.sum(9.13f, 18.6f);
            Calculator.sum("Hello Everyone");
            Console.Read();
            Console.ReadLine();
        }          

        static void FullName()
        {
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            Console.WriteLine("My full name is {0} {1}", firstname, lastname);
            Console.ReadLine();
        }
        static class Calculator
        {
            public static void sum()
            {
                Console.WriteLine("No Value Provided");
            }
            public static void sum(int x, int y)
            {
                Console.WriteLine("Sum of " +x.ToString() + " +   " + y.ToString() + " = "+ (x + y).ToString());
            }
            public static void sum(float x, float y)
            {
                Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
            }
            public static void sum(int x, float y)
            {
                Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
            }
            public static void sum(string s)
            {
                Console.WriteLine("{0} - is not a numeric value", s);
            }
        }
    }
}
