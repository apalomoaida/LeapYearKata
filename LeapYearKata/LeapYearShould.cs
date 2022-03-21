using NUnit.Framework;

namespace LeapYearKata.Test {
    public class LeapYearShould {
       
        [SetUp]
        public void Setup() {
            
        }

        #region Los años divisibles por 4 son bisiestos  
        [Test]
        [TestCase(4)]
        [TestCase(8)]
        [TestCase(12)]
        [TestCase(16)]      
        public void return_true_if_is_divisible_by_4(int year) {       
            var leapYear = new LeapYear(year);

            Assert.AreEqual(true, leapYear.IsDivisibleBy4());
        }  
        [Test]
        [TestCase(5)]
        [TestCase(9)]
        [TestCase(13)]
        [TestCase(17)]
        public void return_false_if_is_not_divisible_by_4(int year) {       
            var leapYear = new LeapYear(year);

            Assert.AreEqual(false, leapYear.IsDivisibleBy4());
        }
        #endregion
    }
}