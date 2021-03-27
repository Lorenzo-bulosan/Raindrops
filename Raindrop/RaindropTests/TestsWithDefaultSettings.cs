using NUnit.Framework;
using RaindropApp;

namespace RaindropTests
{
    // Testing with default settings (not user defined) i.e factors 3,5,7
    public partial class RaindropsByDefaultShould
    {
        private Raindrops _sut;

        [Test]
        [Category("Default Settings")]
        [TestCase(15, "PlingPlang")]
        [TestCase(21, "PlingPlong")]
        [TestCase(35, "PlangPlong")]
        public void ReturnCorrectString_WhenContainingMultipleFactors(int num, string expectedResult)
        {
            _sut = new Raindrops();
            string result = _sut.Solve(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        [Category("Default Settings")]
        [TestCase(1)]
        [TestCase(16)]
        [TestCase(22)]
        public void ReturnCorrectString_WhenDoesNotContainDefaultFactors(int num)
        {
            _sut = new Raindrops();
            string result = _sut.Solve(num);
            Assert.That(result, Is.EqualTo(num.ToString()));
        }
        [Test]
        [Category("Default Settings")]
        [TestCase(3, "Pling")]
        [TestCase(6, "Pling")]
        [TestCase(9, "Pling")]
        public void ReturnPling_WhenIsFactorOfThree_AndOnlyThree(int num, string expectedResult)
        {
            _sut = new Raindrops();
            string result =  _sut.Solve(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        [Category("Default Settings")]
        [TestCase(5, "Plang")]
        [TestCase(10, "Plang")]
        [TestCase(20, "Plang")]
        public void ReturnPling_WhenIsFactorOfFive_AndOnlyFive(int num, string expectedResult)
        {
            _sut = new Raindrops();
            string result = _sut.Solve(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        [Category("Default Settings")]
        [TestCase(7, "Plong")]
        [TestCase(14, "Plong")]
        [TestCase(28, "Plong")]
        public void ReturnPling_WhenIsFactorOfSeven_AndOnlySeven(int num, string expectedResult)
        {
            _sut = new Raindrops();
            string result = _sut.Solve(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        } 
    }
}