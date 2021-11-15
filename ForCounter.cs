using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class ForCounter
    {
        static void Main(string[] args) 
        {
            for (int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine("{0}",counter);
                Console.WriteLine();
            }
        }

    }
}
