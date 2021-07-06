using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shahmat
{
    public class OT: Taxta
    {
        public void Uradi(int x,int y)
        {
            TaxtDrw();
            
            diagonal(x, y);
            taxta[x, y] = 'P';
            this.Print();
        }
        private void diagonal(int ii, int jj)
        {
            if (ii - 2 >= 0 && jj - 1 >= 0) taxta[ii-2, jj-1] = 'X';
            if (ii - 2 >= 0 && jj + 1 <=7) taxta[ii-2, jj+1] = 'X';
            if (ii + 2 <=7 && jj - 1 >= 0) taxta[ii+2, jj-1] = 'X';
            if (ii + 2 <=7 && jj + 1 <=7) taxta[ii+2, jj+1] = 'X';
            if (jj - 2 >=0 && ii + 1 <=7) taxta[ii+1, jj-2] = 'X';
            if (jj - 2 >= 0 && ii - 1 >= 0) taxta[ii-1, jj-2] = 'X';
            if (jj + 2 <=7 && ii - 1 >= 0) taxta[ii-1, jj+2] = 'X';
            if (jj + 2 <=7 && ii + 1 <= 7) taxta[ii+1, jj+2] = 'X';

        }
       
        
        public override void TaxtDrw()
        {
            base.TaxtDrw(); 
        }
    }
}
