using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp0704
{
    class Shark:Wild
    {
        public string Type;
        public Shark(string type, int teeth,int weight,int age):base(teeth, weight, age)
        {
            Type = type;
        }

        public string Fullinfo()
        {
            return $"Type: {Type} ,Teeth: {Teeth}, Weight:{Weight}, Age:{ Age}";
        }
    }
}
