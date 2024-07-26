using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    internal class SuperHeroe
    {
        public string nombre { get; set; }
        public string identidadSecreta { get; set; }
        public string ciudad { get; set; }
        public bool volar { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Identidad Secreta: {identidadSecreta}");
            Console.WriteLine($"Ciudad: {ciudad}");
            Console.WriteLine($"Puede Volar?: {volar}");

        }
    }
}