using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora Epson = new Impresora();
            Console.WriteLine("Presione una tecla para agregar un documento, una foto y un contrato a la cola de impresión");
            Console.ReadKey();
            Epson.AgregarImprimible();
            Console.WriteLine("Se han agrega un documento, una foto y un contrato a la cola de impresión");
            Console.WriteLine("Presione una tecla para que se imprima la cola de impresión");
            Console.ReadKey();
            Epson.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
