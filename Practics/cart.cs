using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics
{
    internal class cart
    {
        public static Random rnd = new Random();
        int[] coloda = {6,6,6,6,7,7,7,7,8,8,8,8,9,9,9,9,10,10,10,10,11,11,11,11,5,5,5,5,4,4,4,4,3,3,3,3};
        int getCart(int[] coloda)
        {
            string nameCart = string.Empty;
            int result = rnd.Next(3, 12);
            if (result == 3) nameCart = "Валет";
            if (result == 4) nameCart = "Дама";
            if (result == 5) nameCart = "Король";
            if (result == 11) nameCart = "Туз";
            return result;
        }
    }
}
