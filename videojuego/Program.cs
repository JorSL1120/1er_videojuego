using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videojuego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            Console.WriteLine("dime tu edad");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tu edad es " + edad);
        }
    }
}
