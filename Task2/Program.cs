using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I'm Matrix!");
            Console.WriteLine(" ");
            Console.WriteLine("Enter the row dimension of the matrix:");
            var row = CheckInputs(Console.ReadLine());
            Console.WriteLine("Enter the column dimension of the matrix:");
            var column = CheckInputs(Console.ReadLine());
            Console.WriteLine("\n");

            if (row != 0 && column != 0)
            {
               Matrix _matrix = new Matrix(row, column);

               _matrix.PrintMatrixToConsole();
                Console.WriteLine(" \n");
                Console.Write("Sum:" + _matrix.GetMatrixDiagonalSum() + "   ");
                Console.WriteLine("\n");
                Console.Write("Spiral::");
              _matrix.SpiralPrint();
               Console.ReadKey();
            }
        }

        private static int CheckInputs(string a)
        {
            if (!(string.IsNullOrEmpty(a)))
            {
                int b;
                if (int.TryParse(a, out b) && b > 0)
                {
                    return b;
                }
                Console.WriteLine("The value is NULL or NOT A NUMBER! ");
                return default;
            }
            Console.WriteLine("The value is EMPTY! ");
            return default;
        }
    }
}

