using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0704
{
    class Program
    {
        static void Main(string[] args)
        {

            Shark shark1 = new Shark("shahin ", 24, 62, 14);
            Dog dog1 = new Dog("Erkey", "Modi",  43, 7);
            Console.WriteLine(shark1.Fullinfo()) ;
            Console.WriteLine(dog1.FullInfo()) ;
            Console.ReadLine();
           

        }
    }
}
