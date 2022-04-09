using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0704
{
    class Domestic:Animal
    {
        public string Name;
       
        public Domestic(String name, int weight, int age):base(weight,age)
        {
            Name = name;
           
        }
    }
}
