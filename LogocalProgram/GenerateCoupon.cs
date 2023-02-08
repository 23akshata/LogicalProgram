using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogocalProgram
{
    public class GenerateCoupon
    {
        int distinct = 0;
        int newCoupon = 0;
        int count = 0;
        public void CouponNumber()
        {
            Console.WriteLine("Enter Number for Coupon:");
            int number = Convert.ToInt32(Console.ReadLine());

            bool[] coupon = new bool[number];
            while (distinct < number)
            {
                Random random = new Random();
                newCoupon = (int)(random.NextDouble() * number);
                count++;
                if (!coupon[newCoupon])
                {
                    distinct++;
                    coupon[newCoupon] = true;
                }
            }
            Console.WriteLine(count);
        }
    }
}
