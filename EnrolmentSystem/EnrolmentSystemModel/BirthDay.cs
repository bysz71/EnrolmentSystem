using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystemModel
{
    public class BirthDay
    {
        private int _day;
        private int _mon;
        private int _year;

        public BirthDay(int day, int mon, int year)
        {
            _day = day;
            _mon = mon;
            _year = year;
        }

        public int Day
        {
            get
            {
                return _day;
            }
            set
            {
                _day = value;
            }
        }

        public int Mon
        {
            get
            {
                return _mon;
            }
            set
            {
                _mon = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public string GetBirthDay()
        {
            string birthDay = _year.ToString();
            if (_mon < 10)
                birthDay = birthDay + "-0" + _mon.ToString();
            else
                birthDay = birthDay + "-" + _mon.ToString();
            if (_day < 10)
                birthDay = birthDay + "-0" + _day.ToString();
            else
                birthDay = birthDay + "-" + _day.ToString();
            return birthDay;
        }
    }
}
