using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystemModel
{
    public class University
    {
        private string _name;
        private string _dataSet;
        private Dictionary<string, Paper> _paperDictionary;
        private Dictionary<int, Student> _studentDictionary;

        public University()
        {
            _name = "";
            _dataSet = "";
            _paperDictionary = new Dictionary<string,Paper>();
            _studentDictionary = new Dictionary<int,Student>();
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

        public string DataSet
        {
            get
            {
                return _dataSet;
            }
            set
            {
                _dataSet = value;
            }
        }

        /// <summary>
        /// Add a paper to this university dataset if it's not existed
        /// </summary>
        /// <param name="paper"></param>
        /// <returns></returns>
        public bool AddPaper(Paper paper)
        {
            if (_paperDictionary.ContainsKey(paper.Code))
                return false;
            else
            {
                _paperDictionary.Add(paper.Code, paper);
                return true;
            }
        }

        /// <summary>
        /// Remove a paper from this university data set if it is existed.
        /// </summary>
        /// <param name="code">code of the paper you want to delete.</param>
        /// <returns></returns>
        public bool RemovePaper(string code)
        {
            if (_paperDictionary.ContainsKey(code))
            {
                _paperDictionary.Remove(code);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Add a student to this university data set if it is not existed.
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool AddStudent(Student student)
        {
            if (_studentDictionary.ContainsKey(student.Id))
                return false;
            else
            {
                _studentDictionary.Add(student.Id, student);
                return true;
            }
        }

        /// <summary>
        /// Remove a student from this university data set if it is existed.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool RemoveStudent(int id)
        {
            if (_studentDictionary.ContainsKey(id))
            {
                _studentDictionary.Remove(id);
                return true;
            }
            else
                return false;
        }
    }
}
