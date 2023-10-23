using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 30;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20) 
            {
                Console.WriteLine("Number is 20");
            }
            else 
            {
                Console.WriteLine("Number is not 10, nor 20");
            }
            Console.ReadLine();
        }
    }
}
