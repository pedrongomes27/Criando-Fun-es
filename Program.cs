using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criando_Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            int raio;
            void get_raio()
            {
                raio = Convert.ToInt32(Console.ReadLine());
                double pi = 3.14159;
                double area = pi * Math.Pow(raio, 2);
                Console.WriteLine(Math.Round(area, 4));

            }

            get_raio();
            Console.ReadKey();
        }
    }
}
