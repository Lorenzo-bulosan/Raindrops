using NUnit.Framework;
using RaindropApp;
using System.Collections;
using System.Collections.Generic;

namespace RaindropTests
{
    public class RaindropsWithUserSettingsShould
    {
        private Raindrops _sut;
        private Dictionary<int, string> _userSettings = new Dictionary<int, string>();

        // Testing with user defined settings
        public RaindropsWithUserSettingsShould()
        {
            _userSettings.Add(2,"Zing");
            _userSettings.Add(4, "Zang");
            _userSettings.Add(7, "Zong");
            _sut = new Raindrops(_userSettings);
        }
        [Test]
        [Category("Default Settings")]
        [TestCase(15, "PlingPlang")]
        [TestCase(21, "PlingPlong")]
        [TestCase(35, "PlangPlong")]
        public void ReturnCorrectString_WhenContainingMultipleFactor(int num, string expectedResult)
        {
            string result = _sut.Solve(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        
    }
}