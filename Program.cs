using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06ExerciciosSerasa
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um numero de 1 a 10:");
            numero = int.Parse(Console.ReadLine());
            if ( numero <= 10)
            {
                Console.WriteLine("--FIM DO PROGRAMA");
                return;
            }
            else
            {
                Console.WriteLine("Opa! Digite um numero valido...");
                Main(null);
            }

            Console.WriteLine("--FIM DO PROGRAMA");

            Console.ReadKey();


            string usuario = "bianca";
            string senha = "lua345";

            Console.WriteLine("Bem-vindo so Conradito's Banks");
            Console.WriteLine("Opções:");
            Console.WriteLine("1-Cadastrar");
            Console.WriteLine("2-Login");






            Console.ReadKey();
        }
    }
}
