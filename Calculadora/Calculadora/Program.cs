using System;

namespace Calculadora
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            int opc;

            do
            {
                Console.WriteLine("EJERCICIO CALCULADORA BASICA");
                Console.WriteLine("OPCION 0: Salir");
                Console.WriteLine("OPCION 1: Sumar");
                Console.WriteLine("OPCION 2: Restar");
                Console.WriteLine("OPCION 3: Multiplicar");
                Console.WriteLine("OPCION 4: Dividir");
                Console.WriteLine("Digite la opcion que desea: ");
                opc = Convert.ToInt32(Console.ReadLine());
                
            int num1 = 0, num2 = 0, resultado = 0;

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("SUMAR");
                        Console.WriteLine("Digite el primer numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 2:
                        Console.WriteLine("RESTAR");
                        Console.WriteLine("Digite el primer numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 3:
                        Console.WriteLine("MULTIPLICAR");
                        Console.WriteLine("Digite el primer numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 4:
                        Console.WriteLine("DIVIDIR");
                        Console.WriteLine("Digite el primer numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado = num1 / num2;
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (opc != 0);
        }
    }
}