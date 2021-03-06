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
        public void ReturnZero_WhenInputIsZero()
        {
            _sut = new Raindrops();
            string result = _sut.Solve(0);
            Assert.That(result, Is.EqualTo("0"));
        }

        [Test]
        [Category("Default Settings")]
        [TestCase(1)]
        [TestCase(16)]
        [TestCase(-10151)]
        [TestCase(156322)]
        public void ReturnCorrectString_WhenContaining_NoFactors(int num)
        {
            _sut = new Raindrops();
            string result = _sut.Solve(num);
            Assert.That(result, Is.EqualTo(num.ToString()));
        }

        [Test]
        [Category("Default Settings")]
        [TestCase(15, "PlingPlang")]
        [TestCase(-15, "PlingPlang")]
        [TestCase(21, "PlingPlong")]
        [TestCase(-21, "PlingPlong")]
        [TestCase(35, "PlangPlong")]
        [TestCase(-35, "PlangPlong")]
        public void ReturnCompoundString_WhenContaining_MultipleFactors(int num, string expectedResult)
        {
            _sut = new Raindrops();
            string result = _sut.Solve(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [Category("Default Settings")]
        [TestCase(3, "Pling")]
        [TestCase(-6, "Pling")]
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
        [TestCase(-10, "Plang")]
        [TestCase(-20, "Plang")]
        public void ReturnPling_WhenIsFactorOfFive_AndOnlyFive(int num, string expectedResult)
        {
            _sut = new Raindrops();
            string result = _sut.Solve(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [Category("Default Settings")]
        [TestCase(-7, "Plong")]
        [TestCase(-14, "Plong")]
        [TestCase(28, "Plong")]
        public void ReturnPling_WhenIsFactorOfSeven_AndOnlySeven(int num, string expectedResult)
        {
            _sut = new Raindrops();
            string result = _sut.Solve(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}