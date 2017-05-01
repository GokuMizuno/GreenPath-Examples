/*Gordon Stangler
  C# FizzBuzz
  FizzBuzz - output 1 to 100, but when a number is divisible by 3, output Fizz, when it is divisible by 5, output Buzz,
  and if it is divisible by 15, ouput FizzBuzz; instead of the number.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //FizzBuzz!
            for(int i=1;i<101;i++)
            {
                /*
                While I could just use mod 3,5, and using fancy formatting, I am just using mod 3,5,15,
                so the test cases can be easily seperated.  Using Write to add the '\n' at the end
                not WriteLine, as writeline has a default '\n' built in.
                */
                if(0 == i%15)
                    Console.Write("FizzBuzz");
                else if(0 == i%5)
                    Console.Write("Buzz");
                else if(0 == i%3)
                    Console.Write("Fizz");
                else
                    Console.Write("{0}",i);
                Console.Write("\n");
            }
        }
    }
}