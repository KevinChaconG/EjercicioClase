using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperHeroe IronMan = new SuperHeroe();
            IronMan.nombre = "Iron Man";
            IronMan.identidadSecreta = "Tony Stark";
            IronMan.ciudad = "Malibu";
            IronMan.volar = true;
            IronMan.Imprimir();

            Console.WriteLine();

            SuperHeroe Thor = new SuperHeroe();
            Thor.nombre = "Thor";
            Thor.identidadSecreta = "Thor Odinson";
            Thor.ciudad = "Asgard";
            Thor.volar = true;
            Thor.Imprimir();

            Console.WriteLine();

            SuperHeroe CapitanAmerica = new SuperHeroe();
            CapitanAmerica.nombre = "Capitan America";
            CapitanAmerica.identidadSecreta = "Steve Rogers";
            CapitanAmerica.ciudad = "Nueva York";
            CapitanAmerica.volar = false;
            CapitanAmerica.Imprimir();

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
