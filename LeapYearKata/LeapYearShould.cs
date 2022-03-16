using NUnit.Framework;

namespace LeapYearKata.Test {
    public class LeapYearShould {
        [SetUp]
        public void Setup() {
        }

        [Test]
        [TestCase(4)]
        [TestCase(8)]
        [TestCase(12)]
        [TestCase(16)]
        //Los años divisibles por 4 son bisiestos    
        public void be_divisible_by_4(int year) {       
            var leapYear = new LeapYear();
            Assert.AreEqual(false, leapYear.IsDivisibleBy4(year));
        }
    }
}