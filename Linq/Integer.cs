using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linq
{
    class Integer
    {

        static int[] integers = {20, 1, 5, 10, 12, 6, 4, 21, 19, 35, 3, 2 };

        /*
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Retreive information From Array - All Two Digit numbers");
            Console.WriteLine("-------------------------");
      

            IEnumerable<int> digits_2 = from num in integers
                                        where num >= 10                                     
                                        select num;

            // IEnumerable<int> first4_digit2 = digits_2.Take(4);

            foreach (var item in digits_2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Get First 4 Values From Collections Using LINQ");
            Console.WriteLine("-------------------------");

            IEnumerable<int> first4 = integers.Take(4);

            foreach (var item in first4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Skip First 4 Values From Collections Using LINQ");
            Console.WriteLine("-------------------------");
            IEnumerable<int> skip_4 = integers.Skip(4);

            foreach (var item in skip_4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Skip the Value 35 From Collections Using LINQ");
            Console.WriteLine("-------------------------");
            IEnumerable<int> skipCetainValue = integers.TakeWhile(num => num.CompareTo(35) != 0);

            foreach (var item in skipCetainValue)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("-------------------------");
            Console.WriteLine("Skip While Value Equals 35 From Collections Using LINQ");
            Console.WriteLine("-------------------------");
            IEnumerable<int> skipWhileNumber = integers.SkipWhile(num => num.CompareTo(35) != 0);

            foreach (var item in skipWhileNumber)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        } 
        */
    }
}
