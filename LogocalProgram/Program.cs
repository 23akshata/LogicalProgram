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
            Console.WriteLine("1 : FibonacciSeries\n ");
            Console.WriteLine("Enter a Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    FibonacciSeries Num = new FibonacciSeries();
                    Num.Series();
                    break;
            }
            Console.ReadLine();
        }
    }
}