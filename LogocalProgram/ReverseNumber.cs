using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogocalProgram
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter A Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int remainder;
            while (number > 0)
            {
                remainder = number % 10;
                result = result * 10 + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reverse number Is = " + result);
        }
    }
}
