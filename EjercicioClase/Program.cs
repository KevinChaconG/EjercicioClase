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
            IronMan.poder = "Armadura";
            IronMan.descripcion = "Armadura que da super fuerza, permite volar y atacar con armas";
            IronMan.nivel = "7";
            IronMan.Imprimir();

            Console.WriteLine();

            SuperHeroe Thor = new SuperHeroe();
            Thor.nombre = "Thor";
            Thor.identidadSecreta = "Thor Odinson";
            Thor.ciudad = "Asgard";
            Thor.volar = true;
            Thor.poder = "Mjolnir";
            Thor.descripcion = "Martillo magico que permite volar, lanzar rayos y que solo puede ser usado por Thor";
            Thor.nivel = "8";
            Thor.Imprimir();

            Console.WriteLine();

            SuperHeroe CapitanAmerica = new SuperHeroe();
            CapitanAmerica.nombre = "Capitan America";
            CapitanAmerica.identidadSecreta = "Steve Rogers";
            CapitanAmerica.ciudad = "Nueva York";
            CapitanAmerica.volar = false;
            CapitanAmerica.poder = "Super Soldado y Escudo";
            CapitanAmerica.descripcion = "Super fuerza y escudo que es practicamente indestructible";
            CapitanAmerica.nivel = "6";
            CapitanAmerica.Imprimir();

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
