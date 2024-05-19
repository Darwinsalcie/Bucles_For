
namespace NCantidadDeNumeros.Class
{

class ContarValoresMayores1000
    {
        public void Contarnumeros()
        {
            // Declaración de variables
            int n=0, contador = 0;
            long[] numeros;
            bool exit =  false;

            // Solicitar al usuario la cantidad de números a ingresar

  
           
            while(exit == false)
            {
                try
                {
                    Console.Write("\nIngrese la cantidad de números: ");
                    n = int.Parse(Console.ReadLine());
                    exit = true;
                }

                catch (Exception)
                {
                    Console.WriteLine("Tipo de dato erroneo");
                }


            }

            // Crear un arreglo para almacenar los números ingresados
            numeros = new long[n];

            // Ingresar los números
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");


                try
                {
                    numeros[i] = long.Parse(Console.ReadLine());
                }


                catch(Exception) {

                    Console.WriteLine("Tipo de dato erroneo");
                    i--;

                }
            }

            // Contar la cantidad de valores mayores o iguales a 1000
            for (int i = 0; i < n; i++)
            {
                if (numeros[i] >= 1000)
                {
                    contador++;
                }
            }

            // Mostrar la cantidad de valores mayores o iguales a 1000
            Console.WriteLine($"Cantidad de valores mayores o iguales a 1000: {contador}");
        }
    }

}
