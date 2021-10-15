using System;

namespace Ejercicio2_Clase14
{
    class Program
    {
        static void Main(string[] args)
        {
            TorreDeControl torre = new TorreDeControl();
            int experiencia = 0;
            int energia = 100;
            int horas = 0;
            int salir;
            do
            {
                torre.agregarVolador();
                torre.vuelenTodos();
                horas = horas + 13;
                Console.WriteLine("Horas de vuelo: " + horas);
                energia = energia - 5;
                Console.WriteLine("Energia del pato: " + energia);
                experiencia = experiencia + 3;
                Console.WriteLine("Experiencia: " + experiencia);
                Console.WriteLine("Salir[3]");
                salir = Console.Read();

            } while (salir != 3);
            
           





        }
    }
}
