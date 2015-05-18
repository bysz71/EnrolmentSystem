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
        private HashSet<string> _studentSet;

        public Paper(string code, string name, string coordinator)
        {
            _code = code;
            _name = name;
            _coordinator = coordinator;
            _studentSet = new HashSet<string>();
        }

        public string Code
        {
            get
            {
                return _code;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Coordinator
        {
            get
            {
                return _coordinator;
            }
        }

        public HashSet<string> StudentSet
        {
            get
            {
                return _studentSet;
            }
        }

        /// <summary>
        /// Add a Student to this paper if he is not already existed
        /// </summary>
        /// <param name="student">a Student object</param>
        /// <returns>Return true if student added, return false if student already existed.</returns>
        public bool AddStudent(string id)
        {
            if (_studentSet.Contains(id))
            {
                return false;
            }
            else
            {
                _studentSet.Add(id);
                return true;
            }
        }

        /// <summary>
        /// Remove a Student from this paper if he is already existed
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool RemoveStudent(string id)
        {
            if (_studentSet.Contains(id))
            {
                _studentSet.Remove(id);
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
            foreach (string id in _studentSet)
            {
                studentList = studentList + id + "\n";
            }
            return studentList;
        }
    }
}
