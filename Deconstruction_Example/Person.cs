using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deconstruction_Example
{
    public class Person
    {
        internal string Name { get; set; }
        internal int BirthYear { get; set; }
        internal void Deconstruct(out string name, out int birthYear)
        {
            name = Name;
            birthYear = BirthYear;
        }
    }
}
