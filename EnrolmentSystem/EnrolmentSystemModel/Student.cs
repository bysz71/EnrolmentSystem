using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystemModel
{
    public class Student
    {
        private int _id;
        private string _name;
        private BirthDay _birthDay;
        private string _address;
        private Dictionary<string,Paper> _paperDictionary;

        public Student(int id , string name , BirthDay BirthDay , string address){
            _id = id;
            _name = name;
            _birthDay = BirthDay;
            _address = address;
            _paperDictionary = new Dictionary<string, Paper>();
        }


        public int Id
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
    }
}
