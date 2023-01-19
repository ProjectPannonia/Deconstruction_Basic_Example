using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deconstruction_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pat = new Person()
            {
                Name = "Patrick",
                BirthYear = 1990
            };

            var (name, birthYear) = pat;
            Console.WriteLine($"Name: {name}, year of birth: {birthYear}");
            Console.ReadKey();  
        }
    }
}
