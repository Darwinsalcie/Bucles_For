

namespace TablaMult.Class
{
    using System;

    class TablaMultiplicar
    {
        public void tablas_multplicar()
        {
            int numtabla = 5;
            int sumacumulador = 0;

            Console.WriteLine($"\n\nTabla de multiplicar del {numtabla} (del {numtabla} al 50)");
           
            // Mostrar la tabla de multiplicar del 5 (del 5 al 50)
            for (int i = 1; i <= 50; i ++)
            {
                sumacumulador += numtabla;

                Console.WriteLine($"{numtabla} X {i} = {sumacumulador}");


            }
        }
    }

}
