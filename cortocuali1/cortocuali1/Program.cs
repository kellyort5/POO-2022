using System;

namespace ClasePractica1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("CONTAR DEL 1 AL 10");

            // Versión iterativa:
            contarIter();

            // Versión recursiva:
            contarRec(1);
        }
        public static void contarRec(int i)
        {
            if (i <= 10)
            {
                Console.WriteLine(i);
                i = i + 1;
                contarRec(i);
            }
        }
        public static void contarIter()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
        }
    }
}