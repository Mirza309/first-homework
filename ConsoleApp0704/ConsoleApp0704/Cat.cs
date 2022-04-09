using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0704
{
    class Cat : Domestic
    {
        public string Type;

        public Cat(string type, string name, int weight, int age) :base(name, weight, age)
        {
            Type = type;
        }
    }
}
