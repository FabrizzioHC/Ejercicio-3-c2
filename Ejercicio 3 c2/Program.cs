using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_c2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingresa la edad del ganador: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("ingresa la cantidad de adivinanzas que adivino: ");
            int adivinanzasadivinadas = int.Parse(Console.ReadLine());

            int montoinicial = 0;

            if (edad >= 18)
            {
                if (adivinanzasadivinadas < 3)
                    montoinicial = 30;
                else
                    montoinicial = 50;
            }
            else
            {
                if (adivinanzasadivinadas < 3)
                    montoinicial = 50;
                else
                    montoinicial = 80;
            }
            int montoadicional = (edad * 5) + (adivinanzasadivinadas * 2);
            int montofinal = montoinicial + montoadicional;
            Console.WriteLine(" el monto final que el ganador gano es: " + montofinal);
            Console.ReadKey();

        }
    }
}