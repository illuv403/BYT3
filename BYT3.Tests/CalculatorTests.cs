using BYT3_Calculator;

namespace BYT3_Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private ICalculator _add = new Calculator(1000, 5000, "+");
        private ICalculator _sub = new Calculator(1000, 5000, "-");
        private ICalculator _mul = new Calculator(100, 500, "*");
        private ICalculator _div = new Calculator(100, 500, "/");
        private ICalculator _divByZero = new Calculator(100, 0, "/");
        private ICalculator _invalidArgument = new Calculator(100, 123, "123");
        private ICalculator _boundaries = new Calculator(1e200, 1e200, "*");

        [Test]
        public void AdditionTest()
        {
            Assert.That(_add.Calculate(), Is.EqualTo(6000));
        }

        [Test]
        public void SubtractionTest()
        {
            Assert.That(_sub.Calculate(), Is.EqualTo(-4000));
        }

        [Test]
        public void MultiplicationTest()
        {
            Assert.That(_mul.Calculate(), Is.EqualTo(50000));
        }

        [Test]
        public void DivisionTest()
        {
            Assert.That(_div.Calculate(), Is.EqualTo(0.2).Within(0.001));
        }

        [Test]
        public void DivisionByZeroTest()
        {
            var ex = Assert.Throws<Exception>(() => _divByZero.Calculate());
            Assert.That(ex.Message, Is.EqualTo("Division by zero is not allowed"));
        }

        [Test]
        public void InvalidArgumentTest()
        {
            var ex = Assert.Throws<Exception>(() => _invalidArgument.Calculate());
            Assert.That(ex.Message, Is.EqualTo("Operation is not supported or is incorrect"));
        }

        [Test]
        public void BoundariesTest()
        {
            var ex = Assert.Throws<Exception>(() => _boundaries.Calculate());
            Assert.That(ex.Message, Is.EqualTo("The double boundaries have been violated"));
        }
    }
}