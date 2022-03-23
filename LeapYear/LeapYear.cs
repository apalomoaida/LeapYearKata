﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearKata {
    public class LeapYear {
        private readonly int year;
        public bool IsLeapYear {
            get {
                return  !(!IsDivisibleBy4()) &&
                        (IsDivisibleBy4() && !IsDivisibleBy100()) && 
                        !(IsDivisibleBy100() && !IsDivisibleBy400()) && 
                        IsDivisibleBy400();                        
            }
        }
        public LeapYear(int year) {
            this.year = year;
        }
        public bool IsDivisibleBy4() {
            return year % 4 == 0;
        }
        public bool IsDivisibleBy100() {
            return year % 100 == 0;
        }
        public bool IsDivisibleBy400() {
            return year % 400 == 0;
        }
    }
}
