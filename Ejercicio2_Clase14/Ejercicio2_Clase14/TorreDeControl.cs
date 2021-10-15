using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Clase14
{
    class TorreDeControl
    {
        List<Ivolador> volar = new List<Ivolador>();
        public void vuelenTodos()
        {
            foreach (Ivolador vuelo in volar)
            {
                vuelo.Volador();
            }
        }

        public void agregarVolador()
        {
            Pato pato = new Pato();
            volar.Add(pato);

            Boing747 avion = new Boing747();
            volar.Add(avion);

            Superman super = new Superman();
            volar.Add(super);
        }

    }
}
