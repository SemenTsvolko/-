using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Numbers
    {
        private int x;
        private int y;
        public Numbers(int x, int y)
        {
            this.x = x;
            this.y = y;
            
        }
        public void BZ()
        {
            double r1 = Math.Pow(x, 3);
            double r2 = Math.Pow(y, 3);
            Console.WriteLine("Результат конечного X:"+ r1);
            Console.WriteLine("Результат конечного Y:"+ r2);
            double r3 = Math.Max(r1, r2);
            Console.WriteLine("Куб большего из чисел:"+ r3);
        }
    }
}
