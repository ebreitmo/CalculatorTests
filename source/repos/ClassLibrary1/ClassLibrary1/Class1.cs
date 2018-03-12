using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            ICalculator sut = new Calculator.Calculator();
            int expectedRes = sut.Add(6,7);
            Assert.That(expectedRes, Is.EqualTo(13));
        }

    }
}
