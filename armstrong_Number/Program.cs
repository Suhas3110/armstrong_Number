using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,sum=0;
            Console.WriteLine("Enter the any Number");
            n=int.Parse(Console.ReadLine());
            int tmp = n;
            while (n > 0)
            {
                int r = n % 10;
                sum = sum + r * r * r;
                n = n / 10;
            }
            if(sum==tmp)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }
            Console.ReadKey();
        }
    }
}
