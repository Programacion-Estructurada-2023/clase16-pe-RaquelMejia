using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar una variable int para opciones

            int opciones;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Programa que muestre los numeros de n al 1 de manera descendente");
                Console.WriteLine("2. Programa que muestre los numeros de 1 a 5 con while");
                Console.WriteLine("3. Programa que muestre el numero minimo de una lista");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Seleccione una opcion (1-4): ");


                if (int.TryParse(Console.ReadLine(), out opciones))
                {
                    switch (opciones)
                    {
                        case 1:

                            numerosDescendente();
                            break;
                        case 2:

                            numerosWhile();

                            break;

                        case 3:
                            minimoLista();

                            break;

                        case 4:


                            break;
                        default:
                            Console.WriteLine("Opcion no valida, por favor, selecciona una opcion valida (1-4");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Entrada no valida. Ingresa un numero de (1-4).");

                }
            } while (opciones != 4);

        }//Fin de while

        static void numerosDescendente()
        {
            Console.Write("\nIngrese un numero (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 1)
            {
                for (int i = n; i >= 1; i--)
                {
                    Console.WriteLine($"Numero > {i}");
                }
            }
            else
            {
                Console.WriteLine("Ingresar un numero mayor a 1 ");

            }


        }//Fin de numeroDescendentes

        static void numerosWhile()
        {

            int contador = 1;

            while (contador <= 5)
            {
                Console.WriteLine($"Numero >>{contador}");
                contador++;
            }

        }//Fin de numerosWhile

        static void minimoLista()
        {

            List<int> numeros = new List<int> { 24, 15, 45, 35, 14, 10 };

            int minimo = numeros[0]; //Inicializar con valor del indice 0

            foreach (int numero1 in numeros)
            {
                if (numero1 < minimo)
                {
                    minimo = numero1; //Actualizar el valor minimo
                }
            }

            Console.WriteLine("El numero mas pequeño en la lista es >  " + minimo);
        }//Fin de minimoLista
    }
}
