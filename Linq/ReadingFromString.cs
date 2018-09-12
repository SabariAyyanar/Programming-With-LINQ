using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linq
{
    class ReadingFromString
    {
        static string someString = "Programming With LINQ";
        static void Main(string[] args)
        {
            // Find the Number of Upper Case Characters in the String

            IEnumerable<char> stringQuery = from ch in someString
                                            where Char.IsUpper(ch)
                                            select ch;

            Console.WriteLine(" ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("LINQ and Lamda Expression");
            Console.WriteLine("-------------------------");
            Console.WriteLine(" ");
            foreach (var item in stringQuery)
            {
                Console.Write(item);
            }

            Console.ReadKey();

        }


    }
}
