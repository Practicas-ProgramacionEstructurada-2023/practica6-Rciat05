using System;
using System.Diagnostics;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable booleana para poder hacer el ciclo de las opciones
            bool salir = false;

            do
            {
                Console.WriteLine("\n*****************************************");
                Console.WriteLine("Menú de opciones: ");
                Console.WriteLine("1. Opción 1: Suma de Números Pares e Impares en un Rango ");
                Console.WriteLine("2. Opción 2: Adivina el número secreto (entre 1 y 10)");
                Console.WriteLine("3. Opción 3: Tablas de multiplicar ");
                Console.WriteLine("4. Salir ");
                Console.WriteLine("*****************************************");


                Console.Write("Selecciones un Opción:");
                string? opcion = Convert.ToString(Console.ReadLine());

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\n****************Suma de numeros pares e impares de Rango****************");
                        Console.Write("Ingrese un numero entero positivo: ");

                        if (int.TryParse(Console.ReadLine(), out int n) && n > 0) //<>  
                        {
                            int sumaPares = 0;
                            int sumaImpares = 0;

                            for (int i = 1; i <= n; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    sumaPares += i; //Si es par, suma el calculador de pares
                                }
                                else
                                {
                                    sumaImpares += i; //Si es impar, suma el calculador de impares.
                                }//<>  
                            }

                            Console.WriteLine("\nLa suma de los números pares en el rango es: " + sumaPares);
                            Console.WriteLine("La suma de los numeros impares es: " + sumaImpares);

                        }
                        else
                        {
                            Console.WriteLine("Debe ingresa un numero entero valido");
                        }
                        break;

                    case "2":
                        //Se llama la función random para que pueda usar los numeros aleatoriamente.
                        Random random = new();
                        //La variable numeroSecreto es igual a un rango del 1 al 11 porque en C# cuenta tambien el 0
                        int numeroSecreto = random.Next(1, 11);
                        int intentos = 0;
                        int intentoUsuario;

                        Console.WriteLine("\n**************Adivina el número secreto (entre 1 y 10)**************");

                        while (true)
                        {
                            intentos++;

                            Console.Write("\nIngresa tu intento: ");
                            if (int.TryParse(Console.ReadLine(), out intentoUsuario))
                            {
                                if (intentoUsuario == numeroSecreto)
                                {
                                    Console.WriteLine("¡FELICITACIONES! Adivinaste el número secreto del cual es: " + numeroSecreto + " y fue adivinado en " + intentos + " intentos :D");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Intenta de nuevo.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingresa un numero valido");
                            }
                        }
                        break;


                    case "3":
                        Console.WriteLine("\n*********************Tablas de multiplicar*********************");
                        Console.Write("Ingresa un número para ver su tabla de multiplicar: ");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nTabla de multiplicar del " + numero + ": ");

                        //Utilizamos un bucle for para imprimir la tabla de multiplicar del número ingresado 
                        for (int i = 1; i <=10; i++)
                        {
                            int resultado = numero * i;
                            Console.WriteLine(numero + " X " + i + " = " + resultado);
                        }
                        break;
                    
                    case "4":
                        Console.WriteLine("Saliendo del programa.........");
                        salir = true;
                        break; 
                    default:  
                        Console.WriteLine("Opcion no valida, intente de nuevo");
                        break;
                }
                Console.WriteLine(); //Salto de línea para separar las íteraciones del menú.

            } while(!salir);

            Console.ReadKey();
        }
    }
}