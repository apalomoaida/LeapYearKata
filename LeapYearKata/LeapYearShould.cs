using NUnit.Framework;

namespace LeapYearKata.Test {
    public class LeapYearShould {
        [SetUp]
        public void Setup() {
        }

        [Test]
        //Los años no divisibles por 4 no son bisiestos    
        public void return_false_if_is_not_divisible_by_4() {       
            var leapYear = new LeapYear();
            Assert.AreEqual(false, leapYear.IsDivisibleBy4(4));
        }
    }
}