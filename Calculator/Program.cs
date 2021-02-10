using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCalculator calc = new MyCalculator();

            Console.WriteLine(calc.Add(2, 4));
        }
    }
}
