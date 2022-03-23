using NUnit.Framework;
using FluentAssertions;

namespace LeapYearKata.Test {
    public class LeapYearShould {
       
        #region Los años no divisibles por 4 NO son bisiestos  
        [Test]
        [TestCase(4)]
        [TestCase(8)]
        [TestCase(12)]
        [TestCase(16)]      
        public void be_divisible_by_4(int year) {       
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

        #region Los años divisibles por 100 pero no por 400 NO son bisiestos
        [Test]
        [TestCase(1800)]
        public void not_leapYear_if_is_divisible_by_100_and_not_by_400(int year) {
            var leapYear = new LeapYear(year);

            leapYear.IsDivisibleBy100().Should().BeTrue();
            leapYear.IsDivisibleBy400().Should().BeFalse();
        }
        #endregion 
        
        #region Los años divisibles por 400 son bisiestos
        [Test]
        [TestCase(400)]
        public void be_divisible_by_400(int year) {
            var leapYear = new LeapYear(year);

            leapYear.IsDivisibleBy400().Should().BeTrue();
        }
        #endregion

        #region Decir si el año es bisiesto
        [Test]
        [TestCase(1712)]
        [TestCase(1716)]
        [TestCase(1720)]
        [TestCase(1828)]
        [TestCase(1832)]
        [TestCase(1836)]
        [TestCase(1840)]
        public void has_property_islapyear_true_if_it_is_lapyear(int year) {
            var leapYear = new LeapYear(year);

            leapYear.IsLeapYear.Should().BeTrue();
        }
        #endregion

    }
}