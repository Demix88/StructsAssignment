using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAssignment
{
    class Program
    {
        struct Number
        {
            public decimal Amount;
        }
        static void Main(string[] args)
        {
            Number num1;
            num1.Amount = 1.47535m;
            Console.WriteLine("The Decimal Number is:" + "\n" + num1.Amount);
            Console.ReadLine();
        }
    }
}
