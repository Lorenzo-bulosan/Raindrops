using NUnit.Framework;
using RaindropApp;

namespace RaindropTests
{
    [TestFixture]
    public class RaindropsShould
    {

        private Raindrops _sut;

        // test default settings

        // test for private methods ignored

        [Test]
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