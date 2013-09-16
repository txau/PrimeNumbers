using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace PrimeNumbers
{
    [TestFixture]
    class TestPrimeNumbers
    {
        [Test]
        public void Generate_On2_Returns2()
        {
            List<int> result = PrimeNumbers.generate(2);

            var expected = new List<int> { 2 };

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Genereate_On3_Returns3()
        {
            List<int> result = PrimeNumbers.generate(3);

            var expected = new List<int> { 3 };

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Genereate_On4_Returns2_2()
        {
            List<int> result = PrimeNumbers.generate(4);

            var expected = new List<int> { 2, 2 };

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Genereate_On8_Returns2_2_2()
        {
            List<int> result = PrimeNumbers.generate(8);

            var expected = new List<int> { 2, 2, 2 };

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Genereate_On121_Returns11_11()
        {
            List<int> result = PrimeNumbers.generate(121);

            var expected = new List<int> { 11, 11};

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Genereate_On122_Returns2_61()
        {
            List<int> result = PrimeNumbers.generate(122);

            var expected = new List<int> { 2, 61 };

            Assert.AreEqual(expected, result);
        }
    }
}