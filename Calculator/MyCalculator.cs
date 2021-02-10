using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class MyCalculator
    {
    
        public double Add(double a, double b)
        {
            double c = a + b;
            return c;
        }

        public double Sub(double a, double b)
        {
            double c = a - b;
            return c;
        }

        public double Multiply(double a, double b)
        {
            double c = a * b;
            return c;
        }

        public double Power(double a, double power)
        {
            double c = Math.Pow(a, power);
            return c;
        }
    }
}
