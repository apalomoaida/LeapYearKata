using NUnit.Framework;
using FluentAssertions;

namespace LeapYearKata.Test {
    public class LeapYearShould {
       
        [SetUp]
        public void Setup() {
            
        }

        #region Los años no divisibles por 4 NO son bisiestos  
        [Test]
        [TestCase(4)]
        [TestCase(8)]
        [TestCase(12)]
        [TestCase(16)]      
        public void return_true_if_is_divisible_by_4(int year) {       
            var leapYear = new LeapYear(year);
            leapYear.IsDivisibleBy4().Should().BeTrue();
        }  

        [Test]
        [TestCase(5)]
        [TestCase(9)]
        [TestCase(13)]
        [TestCase(17)]
        public void return_false_if_is_not_divisible_by_4(int year) {       
            var leapYear = new LeapYear(year);

            leapYear.IsDivisibleBy4().Should().BeFalse();
          
        }
        #endregion
        #region Los años divisibles por 4 pero no por 100 son bisiestos 
        [Test]
        [TestCase(44)]
        [TestCase(88)]
        public void be_divisible_by_4_and_not_by_100(int year) {
            var leapYear = new LeapYear(year);

            leapYear.IsDivisibleBy4().Should().BeTrue();
            leapYear.IsDivisibleBy100().Should().BeFalse();            
        }  
        [Test]
        [TestCase(400)]        
        public void four_hundred_is_divisible_by_4_and_divisible_by_100(int year) {
            var leapYear = new LeapYear(year);

            leapYear.IsDivisibleBy4().Should().BeTrue();
            leapYear.IsDivisibleBy100().Should().BeTrue();            
        }
        #endregion
    }
}