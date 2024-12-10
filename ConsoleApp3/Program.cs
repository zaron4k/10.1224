using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
            Array.Sort(people);
            foreach (var el in people)
                Console.WriteLine(el);
            Array.Reverse(people);
            foreach (var el in people)
                Console.WriteLine(el);
            Console.ReadLine();
        }
    }
}
