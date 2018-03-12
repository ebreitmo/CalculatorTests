 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator sut = new Calculator();
            int resultAdd = sut.Add(4, 5);

            Console.WriteLine("Result: " + resultAdd.ToString());
        }
    }
}
