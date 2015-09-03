using System;
using System.Linq;
using System.Diagnostics;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = (new int[100]).Select((m, n) => { n++; Console.WriteLine(n % 15 == 0 ? "FizzBuzz" : (n % 3 == 0 ? "Fizz" : (n % 5 == 0 ? "Buzz" : "" + n))); return n; });
        }
    }
}
