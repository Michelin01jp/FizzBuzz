using System;
using System.Linq;

namespace Fizzbuzz
{
    class Program
    {
        // 多分これが一番速いと思います。
        // I think maybe this is earliest.
        static void Main(string[] args)
        {
            Enumerable.Range(1, 100).Select(m => { Console.WriteLine((m % 3 < 1 ? "Fizz" : "") + (m % 5 < 1 ? "Buzz" : m % 3 > 0 ? "" + m : "")); return m; }).ToArray();
        }
    }
}