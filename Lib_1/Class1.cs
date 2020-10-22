using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_1
{
    public class RandomAmount
    {
        public static int Go(int k, TextBox Numbers)
        {
            int X,
            Summa = 0;
            
            Random rnd = new Random();

            for (int i=0;i<k;i++)
            {
                X = rnd.Next(0,k); 
                Numbers.Text =  X.ToString() + " " + Numbers.Text;
                if (X % 2 == 0) Summa += X;
            }
            return Summa;
        }
    }
}
