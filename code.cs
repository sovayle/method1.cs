using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metooods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("garfield", 25);
            Console.ReadLine();

        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("wow " + name + " you are " + age);
        }

    }
}
