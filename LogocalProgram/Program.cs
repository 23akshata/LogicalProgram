using LogocalProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : FibonacciSeries\n 2:PerfectNumber \n 3:PrimeNumber \n 4:ReverseNumber \n 5:GenerateCoupon");
            Console.WriteLine("Enter a Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    FibonacciSeries Num = new FibonacciSeries();
                    Num.Series();
                    break;

                case 2:
                    PerfectNumber perfect = new PerfectNumber();
                    perfect.Perfect();
                    break;

                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.Prime();
                    break;

                case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.Reverse();
                    break;

                case 5:
                    GenerateCoupon couponNumber = new GenerateCoupon();
                    couponNumber.CouponNumber();
                    break;
            }
            Console.ReadLine();
        }
    }
}