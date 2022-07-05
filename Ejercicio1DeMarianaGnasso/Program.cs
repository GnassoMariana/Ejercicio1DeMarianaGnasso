using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1DeMarianaGnasso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int velocidad, tiempo, distancia, tiempoEnSeg;
            double distanciaEnKM;

            Console.WriteLine("Ingresar la velocidad en m/s:");
            velocidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar el tiempo en minutos;");
            tiempo = Convert.ToInt32(Console.ReadLine());

            tiempoEnSeg = tiempo * 60;
            distancia = velocidad * tiempoEnSeg;
            distanciaEnKM = distancia * 0.001;

            Console.WriteLine($" La distancia recorrida es de {distanciaEnKM} kilometros")
;
            Console.ReadLine();
        }
    }
}
