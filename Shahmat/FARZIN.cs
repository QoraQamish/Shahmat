using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shahmat
{
    public class FARZIN: Taxta
    {
        public void Uradi(int x,int y)
        {
            TaxtDrw();
            for (int i = 0; i < 8; i++)
            {
                taxta[x, i] = 'X';
                taxta[i, y] = 'X';
            }
            diagonal(x, y);
            taxta[x, y] = 'X';
            this.Print();
        }
        private void diagonal(int ii, int jj)
        {
            diagonalLL(ii, jj);
            diagonalLR(ii, jj);
            diagonalRL(ii, jj);
            diagonalRR(ii, jj);

        }
        private void diagonalLR(int ii, int jj)
        {
            while (ii > 0 && jj < 7)
            {
                ii = ii - 1;
                jj = jj + 1;
                taxta[ii, jj] = 'X';
            }
        }
        private void diagonalLL(int ii, int jj)
        {
            while (ii > 0 && jj > 0)
            {
                ii = ii - 1;
                jj = jj - 1;
                taxta[ii, jj] = 'X';
            }
        }
        private void diagonalRR(int ii, int jj)
        {
            while (ii < 7 && jj < 7)
            {
                ii = ii + 1;
                jj = jj + 1;
                taxta[ii, jj] = 'X';
            }
        }
        private void diagonalRL(int ii, int jj)
        {
            while (ii < 7 && jj > 0)
            {
                ii = ii + 1;
                jj = jj - 1;
                taxta[ii, jj] = 'X';
            }
        }
        public override void TaxtDrw()
        {
            base.TaxtDrw(); 
        }
    }
}
