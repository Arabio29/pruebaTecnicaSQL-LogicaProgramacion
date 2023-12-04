/*a. Elabore un algoritmo de un factorial de 1 a 10 (diagrama de flujo y
    prueba de escritorio)*/


    /*
    Para ejecutar el algoritmo escribe los siguientes comandos en la terminal de tu IDE preferido :)

        1. cd pruebaTecnicaEliasibCantor\PruebaTecnicaParteII\Algoritmos
        2. dotnet run
    */

using System;

class Program //creamos clase llamada program
{
    static void Main()
    {   
        // Método principal donde comienza la ejecución del programa
        // Calcula y muestra el factorial de los números del 1 al 10

        // Bucle for que itera desde 1 hasta 10 (inclusive)
        for (int i = 1; i <= 10; i++)
        {
            // Imprime en la consola el mensaje con el resultado del factorial
            Console.WriteLine($"Factorial de {i}: {Factorial(i)}");
        }
    }

    // Función Factorial que calcula el factorial de un número
    static int Factorial(int num)
    {

        // Verifica si el número es 0 o 1, ya que el factorial de 0 y 1 es siempre 1
        if (num == 0 || num == 1)
        {
            // Si es 0 o 1, devuelve 1 ya que su factorial es 1
            return 1;
        }
        else
        {
            // Si el número es mayor que 1, calcula su factorial
            int result = 1; // Inicializa el resultado del factorial en 1

            // Bucle for que itera desde 1 hasta el número actual
            for (int j = 1; j <= num; j++)
            {
                result *= j; // Multiplica el resultado por cada número desde 1 hasta num
            }
            return result; // Devuelve el resultado del factorial
        }
    }
}
