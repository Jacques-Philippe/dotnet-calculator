using System;
using Xunit;
using CalculatorLib;

namespace CalculatorLib.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void CalculatorAddition_Should_BehaveAsExpected()
        {
            Calculator c = new Calculator();
            Assert.NotNull(c);

            float a = 2.0f;
            float b = 1.0f;
            Assert.True(a + b == c.Add(a, b));
            Assert.True(0 == c.Add(a, -a));
            Assert.True(-a == c.Add(0, -a));
        }

        [Fact]
        public void CalculatorSubtraction_Should_BehaveAsExpected()
        {
            Calculator c = new Calculator();
            Assert.NotNull(c);

            float a = 2.0f;
            float b = 1.0f;
            Assert.True(a - b == c.Subtract(a, b));
            Assert.True(0 == c.Subtract(a, a));
            Assert.True(-a == c.Subtract(0, a));
        }
    }
}
