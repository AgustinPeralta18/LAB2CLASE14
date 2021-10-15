using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Clase14
{
    class Impresora
    {

        List<Imprimible> imprimir = new List<Imprimible>();
        public void imprimirTodo()
        {
            foreach (Imprimible mostrar in imprimir)
            {
                mostrar.imprimir();
            }


        }

        public void agregarImprimible()
        {
            Contrato contrato = new Contrato();
            imprimir.Add(contrato);

            Foto foto = new Foto();
            imprimir.Add(foto);

            Documento documento = new Documento();
            imprimir.Add(documento);
        }




    }
}
