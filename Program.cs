using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number: ");

            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer % 3 == 0 && answer % 5 == 0)
            {

                Console.WriteLine("FizzBuzz");

            }

            else if (answer % 3 == 0)
            {

                Console.WriteLine("Fizz");

            }

            else if (answer % 5 == 0)
            {

                Console.WriteLine("Buzz");

            }

            

            Console.Read();


        }
    }
}
