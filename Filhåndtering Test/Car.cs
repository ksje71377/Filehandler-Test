using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filhåndtering_Test
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; } 
        public override string ToString()
        {
            return $"{Year} {Make} {Model} ({Color})";
        }
    }
}
