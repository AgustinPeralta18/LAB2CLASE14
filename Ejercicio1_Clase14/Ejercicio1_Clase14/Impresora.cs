using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Clase14
{
    class Impresora
    {

        List<Imprimible> ColaDeImpresion = new List<Imprimible>();
        public void imprimirTodo()
        {
            foreach (Imprimible mostrar in ColaDeImpresion)
            {
                mostrar.imprimir();
            }


        }

        public void agregarImprimible()
        {
            Contrato contrato = new Contrato();
            ColaDeImpresion.Add(contrato);

            Foto foto = new Foto();
            ColaDeImpresion.Add(foto);

            Documento documento = new Documento();
            ColaDeImpresion.Add(documento);
        }




    }
}
