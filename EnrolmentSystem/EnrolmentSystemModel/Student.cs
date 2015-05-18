using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystemModel
{
    public class Student
    {
        private string _id;
        private string _name;
        private string _birthDay;
        private string _address;

        public Student(string id , string name , string BirthDay , string address){
            _id = id;
            _name = name;
            _birthDay = BirthDay;
            _address = address;
        }


        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string BirthDay
        {
            get
            {
                return _birthDay;
            }
            set
            {
                _birthDay = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
    }
}
