using System;

namespace Calcu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int ops;
            do
            {
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Ingrese una opcion: ");
                ops = Convert.ToInt32(Console.ReadLine());

                int x = 0, y = 0, r = 0;
                switch (ops)
                {
                    case 1:
                        Console.WriteLine("¡¡¡suma!!!");
                        Console.WriteLine("Ingrese el primer numero: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        r = x + y;
                        Console.WriteLine("El resuldado de la suma es: " +r );
                        break;
                        
                    case 2:
                        Console.WriteLine("¡¡¡RESTA!!!");
                        Console.WriteLine("Ingrese el primer valor: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        r = x - y;
                        Console.WriteLine("El resultado de la resta es: " +r);
                        break;
                    case 3: 
                        Console.WriteLine("¡¡MULTIPLICACION!!!");
                        Console.WriteLine("Ingrese el primer valor: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        r = x * y;
                        Console.WriteLine("El resultado de la multiplicacion es: " +r);
                        break;
                    case 4:
                        Console.WriteLine("¡¡¡DIVISION!!!");
                        Console.WriteLine("Ingrese el primer valor: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingrese el segundo valor: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        r = x / y;
                        Console.WriteLine("El resultado de la division es: " +r);
                        break;
                    case 5:
                        Console.WriteLine("Fin del programa");
                        break;
                    default: 
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            } while (ops!=5);
        }
    }
}