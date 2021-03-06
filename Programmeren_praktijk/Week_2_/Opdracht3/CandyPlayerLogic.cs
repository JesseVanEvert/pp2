﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class CandyPlayerLogic
    {
        public void InitCandies(Regularcandies[,] matrix)
        {
            Random rnd = new Random();
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[r, k] = (Regularcandies)rnd.Next(0, 5);
                }
            }
        }
        public void PrintMatrix(Regularcandies[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    switch (matrix[r, k])
                    {
                        case (Regularcandies)0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(" # ");
                            break;
                        case (Regularcandies)1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" # ");
                            break;
                        case (Regularcandies)2:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(" # ");
                            break;
                        case (Regularcandies)3:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" # ");
                            break;
                        case (Regularcandies)4:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(" # ");
                            break;
                        case (Regularcandies)5:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(" # ");
                            break;

                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(Environment.NewLine);
            }
        }
        public bool ScoreRijAanwezig(Regularcandies[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int teller = 1;
                Regularcandies candy = matrix[r, 0];

                for (int k = 1; k < matrix.GetLength(1); k++)
                {
                    if (matrix[r, k] == candy)
                    {
                        teller++;
                    }
                    else
                    {
                        candy = matrix[r, k];
                        teller = 1;
                    }
                    if (teller >= 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool ScoreKolomAanwezig(Regularcandies[,] matrix)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                int teller = 1;
                Regularcandies candy = matrix[0, k];

                for (int r = 1; r < matrix.GetLength(0); r++)
                {
                    if (matrix[r, k] == candy)
                    {
                        teller++;
                    }
                    else
                    {
                        candy = matrix[r, k];
                        teller = 1;
                    }

                    if (teller >= 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
