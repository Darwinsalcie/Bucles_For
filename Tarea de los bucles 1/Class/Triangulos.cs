

namespace Triangulos.Class
{
    class CalcularAreaTriangulos
    {
         public void calcularareatriangulos()
        {
            // Declaración de variables
            int n=0, contadorTriangulosMayor12 = 0;
            bool exit = false;

            // Solicitar al usuario la cantidad de pares de datos a ingresar
            

            while (exit == false)
            {
                try
                {
                    Console.Write("\n\nIngrese la cantidad de pares de datos (base y altura de triángulos): ");
                    n = int.Parse(Console.ReadLine());
                    exit = true;
                }

                catch (Exception)
                {

                    Console.WriteLine("Solo puede ingresar números");
                }
            }

            // Crear arreglos para almacenar las medidas de base y altura
            int[] bases = new int[n];
            int[] alturas = new int[n];

            // Ingresar las medidas de base y altura
            for (int i = 0; i < n; i++)
            {
                
                try
                {
                    Console.Write($"\nIngrese la base del triángulo {i + 1}: ");
                    bases[i] = int.Parse(Console.ReadLine());
                }


                catch (Exception) {

                    Console.WriteLine("Solo puede ingresar números");

                    i--;    
                }

                try
                {
                    Console.Write($"Ingrese la altura del triángulo {i + 1}: ");
                    alturas[i] = int.Parse(Console.ReadLine());
                }

                catch (Exception) {

                    Console.WriteLine("Solo puede ingresar números");

                    i--;
                }



            }

            // Calcular y mostrar el área de cada triángulo, y contar triángulos con área mayor a 12
            for (int i = 0; i < n; i++)
            {
                double area = (bases[i] * alturas[i]) / 2;

                Console.WriteLine($"\nTriángulo {i + 1}:");
                Console.WriteLine($"\nBase: {bases[i]}");
                Console.WriteLine($"\nAltura: {alturas[i]}");
                Console.WriteLine($"\nÁrea: {area}");

                if (area > 12)
                {
                    contadorTriangulosMayor12++;
                }
            }

            // Mostrar la cantidad de triángulos con área mayor a 12
            Console.WriteLine($"\nCantidad de triángulos con área mayor a 12: {contadorTriangulosMayor12}");
        }
    }
}