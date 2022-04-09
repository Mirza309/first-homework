using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0704
{
     class Wild : Animal
    {
       public  int Teeth;

        public Wild(int teeth, int weight, int age):base( weight,age)
        {
            Teeth = teeth;
        }

    }
}
