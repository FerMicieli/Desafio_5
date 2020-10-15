using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio5
{
    class Contrato : TipoDocumento, Imprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un documento de Word");
        }
    }
}
