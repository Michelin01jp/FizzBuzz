using System;
using System.Linq;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            (new int[100]).Select((m, n)=>{n++;Console.WriteLine(n%15==0?"FizzBuzz":(n%3==0?"Fizz":(n%5==0?"Buzz":n.ToString())));return n;}).ToArray();
        }
    }
}
