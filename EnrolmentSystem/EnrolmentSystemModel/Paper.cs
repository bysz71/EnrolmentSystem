using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystemModel
{
    public class Paper
    {
        private readonly string _code;
        private readonly string _name;
        private readonly string _coordinator;
        private Dictionary<int, Student> _studentDictionary;

        public Paper(string code, string name, string coordinator)
        {
            _code = code;
            _name = name;
            _coordinator = coordinator;
            _studentDictionary = new Dictionary<int, Student>();
        }

        public string Code
        {
            get
            {
                return _code;
            }
        }

        /// <summary>
        /// Add a Student to this paper if he is not already existed
        /// </summary>
        /// <param name="student">a Student object</param>
        /// <returns>Return true if student added, return false if student already existed.</returns>
        public bool AddStudent(Student student)
        {
            if (_studentDictionary.ContainsKey(student.Id))
            {
                return false;
            }
            else
            {
                _studentDictionary.Add(student.Id, student);
                return true;
            }
        }

        /// <summary>
        /// Remove a Student from this paper if he is already existed
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool RemoveStudent(int id)
        {
            if (_studentDictionary.ContainsKey(id))
            {
                _studentDictionary.Remove(id);
                return true;
            }
            else
            {
                return false;
            }
        }
            
        /// <summary>
        /// Returns a string represents the list of all students enrolled in this paper.
        /// </summary>
        /// <returns></returns>
        public string StudentList()
        {
            string studentList = "";
            foreach (KeyValuePair<int, Student> entry in _studentDictionary)
            {
                studentList = studentList + entry.Value.Id + " " + entry.Value.Name + "\n";
            }
            return studentList;
        }
    }
}
