using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio5
{
    class Impresora
    {
        List<Imprimible> ColaDeImpresion = new List<Imprimible>();

        public void AgregarImprimible()
        {
            Documento d = new Documento();
            ColaDeImpresion.Add(d);

            Foto f = new Foto();
            ColaDeImpresion.Add(f);

            Contrato c = new Contrato();
            ColaDeImpresion.Add(c);
        }
        public void ImprimirTodo()
        {
            foreach (Imprimible i in ColaDeImpresion)
            {
                i.Imprimir();
            }

        }

    }
}
