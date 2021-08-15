using System;

namespace Task2
{
   public  class Matrix
    {
        private int _row;
        private int _column;
        private int[,] _arr;
        private int _matrixDiagonal;

        public Matrix(int row, int column)
        {
           _row = row;
            _column = column;
            var r = new Random();
            int[,] _arr = new int[_row, _column];

            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _column; j++)
                {
                    _arr[i, j] = r.Next(0, 101);    
                }
            }
         this._arr = _arr;
        }

        public Matrix()
        {
        }

        public int[,]  GenerateTestsMatrix(int[,] b)
        {
            _arr = b;
            return _arr;
        }

        public void PrintMatrixToConsole( )
            {
            for (int i = 0; i < _row; i++)
                {
                    for (int j = 0; j < _column; j++)
                    {
                        if (i  == j )
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write((_arr[i, j] + " ").PadLeft(5));
                            Console.ResetColor();
                        }
                        else
                        {
                        Console.Write((_arr[i, j] + " ").PadLeft(5));
                    }
                }
                    Console.WriteLine(" ");
                }
            }

        

        public int GetMatrixDiagonalSum()
            {
            for (int i = 0; i < _row; i++)
                {
                    for (int j = 0; j < _column; j++)
                    {
                        if (i == j)
                        {
                        _matrixDiagonal += _arr[i, j];
                        }
                    }
                }
            return _matrixDiagonal;
            }

        public void SpiralPrint()
        { 
            int i, k = 0, l = 0;
                while (k < _row && l < _column)
                {
                    for (i = l; i < _column; ++i)
                    {
                        Console.Write(_arr[k, i] + " ");
                }
                k++;
                    for (i = k; i < _row; ++i)
                    {
                        Console.Write(_arr[i, _column - 1] + " ");
                }
                _column--;
                    if (k < _row)
                    {
                        for (i = _column - 1; i >= l; --i)
                        {
                            Console.Write(_arr[_row - 1, i] + " ");
                    }
                    _row--;
                    }
                    if (l < _column)
                    {
                        for (i = _row - 1; i >= k; --i)
                        {
                            Console.Write(_arr[i, l] + " ");
                    }
                    l++;
                    }
                }
            Console.WriteLine(" ");
            }
    }
}
