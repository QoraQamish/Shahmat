using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shahmat
{
    public class Taxta
    {
        public char[,] taxta = new char[8, 8];
        public char[] harf = new char[] { 'a', 'b', 'c', 'd', 'f', 'e', 'j', 'k' };
        public virtual void  TaxtDrw()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    taxta[i, j] = '0';
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i>=1 && i<=8 && j>=1 && j<=8)
                    {
                        Console.Write(" " + taxta[i - 1, j - 1]);
                    }
                    else if(j==0 || j==9)
                    {
                        Console.Write(" " + i);
                    }
                    else if(i == 0 && j >= 1 && j <= 8)
                    {
                        Console.Write(" " + harf[j-1]);
                    }
                    else if (i == 9 && j >= 1 && j <= 8)
                    {
                        Console.Write(" " + harf[j - 1]);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
