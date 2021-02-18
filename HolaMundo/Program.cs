using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola mundo");
            Console.Write("Digite un numero :");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"el numero que usted digito es : {numero}");
            Console.ReadKey();


        }
    }
}
