using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introdução
{
    class Looping
    {
        static void Main(string[] arg)
        {
            int i = 0;

            while( i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("\nEx2 - For");
            for(int j = 0; j <= 10; j++)
            {
                Console.WriteLine(j);
            }

            Console.ReadKey();
        }
    }
}
