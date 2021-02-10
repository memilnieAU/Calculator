using NUnit.Framework;
using Calculator;

namespace MyCalculator.Unit.Test
{
    public class Tests
    {

        Calculator.MyCalculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator.MyCalculator();
        }



        [TestCase(3.3, 12, 15.3)]
        [TestCase(-3.3, 12, 8.7)]
        public void Add_TestCase(double a, double b, double expResult)
        {
            double result = uut.Add(a, b);

            Assert.That(result, Is.EqualTo(expResult).Within(0.1));
        }


        [TestCase(3.3, 12, -8.7)]
        [TestCase(-3.3, 12, -15.3)]
        public void Sub_TestCase(double a, double b, double expResult)
        {
            double result = uut.Sub(a, b);

            Assert.That(result, Is.EqualTo(expResult).Within(0.1));
        }


        [TestCase(4, 3,12)]
        [TestCase(-4, 3,-12)]
        public void Multiply_TestCase(double a, double b, double expResult)
        {
            double result = uut.Multiply(a, b);
            Assert.That(result, Is.EqualTo(expResult).Within(0.1));
        }

        [TestCase(4, 2, 16)]
        [TestCase(-4, 2, 16)]
        [TestCase(-2, 2, 16)]
        public void Power_TestCase(double a, double b, double expResult)
        {
            double result = uut.Power(a, b);
            Assert.That(result, Is.EqualTo(expResult).Within(0.1));
        }



    }
}