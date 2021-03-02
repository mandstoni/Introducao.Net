using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introdução
{
    class Requeriment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 18)
            {
                Console.WriteLine("Maior de idade");
                Console.WriteLine("A idade digitade é:" + idade);

            }
            else
            {
                Console.WriteLine("Menor de idade");
                Console.WriteLine("A idade digitade é:" + idade);
            }

            switch(idade)
            {
                case 10:
                    Console.WriteLine("10");
                        break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            Console.ReadKey();
        }
    }
}
