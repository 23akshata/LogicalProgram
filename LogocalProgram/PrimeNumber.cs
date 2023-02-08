using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogocalProgram
{
    public class PrimeNumber
    {
        public void Prime()
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i=2; i<num/2; i++)
            {
                if(num % i==0)
                {
                    count++;
                }
            }
            if (count >= 1)
                Console.WriteLine("It is a prime number");
            else
                Console.WriteLine("It is not a prime number");
        }
    }
}
