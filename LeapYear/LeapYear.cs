using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearKata {
    public class LeapYear {
        private readonly int year;
        public LeapYear(int year) {
            this.year = year;
        }
        public bool IsDivisibleBy4() {
            return year % 4 == 0;
        }
    }
}
