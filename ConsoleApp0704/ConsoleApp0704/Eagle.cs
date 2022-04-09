using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0704
{
    class Eagle:Wild
    {
       
            public string Type;
            public Eagle(string type, int teeth, int weight, int age) : base(teeth, weight, age)
            {
                Type = type;
            }
        
    }
}
