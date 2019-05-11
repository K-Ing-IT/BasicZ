using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 27;
            x += 6;
            Console.WriteLine(x);

            x -= 12;
            Console.WriteLine(x);
            Console.Write("Press any key to close");
            Console.ReadKey(true);
        }
    }
    
}
