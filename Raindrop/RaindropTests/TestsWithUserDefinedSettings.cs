using NUnit.Framework;
using RaindropApp;
using System.Collections;
using System.Collections.Generic;

namespace RaindropTests
{
    // Testing with user defined settings i.e user specifies factor and string 
    public class RaindropsWithUserSettingsShould
    {
        private Raindrops _sut;
        private Dictionary<int, string> _userSettings = new Dictionary<int, string>();

        // Testing ability for user to select own factors and sounds
        public RaindropsWithUserSettingsShould()
        {
            _userSettings.Add(2, "Zing");
            _userSettings.Add(7, "Zang");
        }
        [Test]
        [Category("User Settings")]
        [TestCase(2, "Zing")]
        [TestCase(4, "Zing")]
        [TestCase(10, "Zing")]
        public void ReturnZing_WhenIsFactorOfTwo_AndOnlyTwo(int num, string expectedResult)
        {
            _sut = new Raindrops(_userSettings);
            string result = _sut.Solve(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        [Category("User Settings")]
        [TestCase(7, "Zang")]
        [TestCase(21, "Zang")]
        public void ReturnZang_WhenIsFactorOfSeven_AndOnlySeven(int num, string expectedResult)
        {
            _sut = new Raindrops(_userSettings);
            string result = _sut.Solve(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        [Category("User Settings")]
        [TestCase(1)]
        [TestCase(9)]
        public void ReturnNumberAsString_WhenDoesNotContainFactors(int num)
        {
            _sut = new Raindrops(_userSettings);
            string result = _sut.Solve(num);
            Assert.That(result, Is.EqualTo(num.ToString()));
        }
        [Test]
        [Category("User Settings")]
        [TestCase(14, "ZingZang")]
        [TestCase(-14, "ZingZang")]
        [TestCase(28, "ZingZang")]        
        [TestCase(-28, "ZingZang")]
        public void ReturnCorrectString_WhenContainsCombinedFactors(int num, string expectedResult)
        {
            _sut = new Raindrops(_userSettings);
            string result = _sut.Solve(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        [Category("User Settings")]
        public void ReturnZero_WhenInputIsZero()
        {
            _sut = new Raindrops(_userSettings);
            string result = _sut.Solve(0);
            Assert.That(result, Is.EqualTo("0"));
        }

    }
}