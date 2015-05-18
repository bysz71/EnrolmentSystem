using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnrolmentSystemModel;
using System.Collections.Generic;
using System.IO;

namespace EnrolmentSystemUnitTest
{
    [TestClass]
    public class UnitTestModel
    {
        [TestMethod]
        public void TestGetBirthDay()
        {
            var bDay = new BirthDay(1, 7, 1987);
            Assert.AreEqual("1987-07-01", bDay.GetBirthDay());
            var bDay2 = new BirthDay(10, 10, 1990);
            Assert.AreEqual("1990-10-10", bDay2.GetBirthDay());
        }
        
        [TestMethod]
        public void TestBirthDayProperty()
        {
            var bDay = new BirthDay(1, 7, 1987);
            bDay.Day = 11;
            bDay.Mon = 11;
            bDay.Year = 1911;
            Assert.AreEqual(11, bDay.Day);
            Assert.AreEqual(11, bDay.Mon);
            Assert.AreEqual(1911, bDay.Year);
        }

        [TestMethod]
        public void TestPaperAddStudent()
        {
            var paper = new Paper("158.212", "Application Software Development", "Dr Teo Susnjak");
            paper.AddStudent("12345678");
            
            bool addSuccess;
            if (addSuccess = paper.AddStudent("12345678"))
                Console.WriteLine("12345678 Added");
            else
                Console.WriteLine("12345678 Existed");

            if (addSuccess = paper.AddStudent("12345677"))
                Console.WriteLine("12345677 Added");
            else
                Console.WriteLine("12345677 Existed");

            Console.Write("Student List:\n" + paper.StudentList());
        }

        [TestMethod]
        public void TestPaperRemoveStudent()
        {
            var paper = new Paper("158.212", "Application Software Development", "Dr Teo Susnjak");
            paper.AddStudent("12345678");

            bool removeSuccess;
            if (removeSuccess = paper.RemoveStudent("11111111"))
                Console.WriteLine("11111111 successfully removed");
            else
                Console.WriteLine("11111111 is not existed");

            if (removeSuccess = paper.RemoveStudent("12345678"))
                Console.WriteLine("11111111 successfully removed");
            else
                Console.WriteLine("11111111 is not existed");

            Console.Write("Student List:\n" + paper.StudentList());
        }

        [TestMethod]
        public void TestUniversityAddPaper()
        {
            var massey = new University();
            var paper = new Paper("158.212", "Application Software Development", "Dr Teo Susnjak");

            bool addSuccess = massey.AddPaper(paper);
            if (addSuccess)
                Console.WriteLine(paper.Code + " added");
            else
                Console.WriteLine(paper.Code + " Existed");

            if (addSuccess = massey.AddPaper(paper))
                Console.WriteLine(paper.Code + " added");
            else
                Console.WriteLine(paper.Code + " Existed");
        }

        [TestMethod]
        public void TestUniversityRemovePaper()
        {
            var massey = new University();
            var paper = new Paper("158.212", "Application Software Development", "Dr Teo Susnjak");
            bool addSuccess = massey.AddPaper(paper);
            bool removeSuccess;

            if (removeSuccess = massey.RemovePaper("158.212"))
                Console.WriteLine("158.212 added");
            else
                Console.WriteLine("158.212 not existed");

            if (removeSuccess = massey.RemovePaper("158.212"))
                Console.WriteLine("158.212 removed");
            else
                Console.WriteLine("158.212 not existed");
        }

        [TestMethod]
        public void TestUniversityAddStudent()
        {
            var massey = new University();
            var student = new Student("12345678", "Big Mac", "01-07-1987", "33 Blah ave., Albany, North Shore");

            bool addSuccess;
            if (addSuccess = massey.AddStudent(student))
                Console.WriteLine(student.Id + " added");
            else
                Console.WriteLine(student.Id + " existed");

            if (addSuccess = massey.AddStudent(student))
                Console.WriteLine(student.Id + " added");
            else
                Console.WriteLine(student.Id + " existed");
        }

        [TestMethod]
        public void TestUniversityRemoveStudent(){
            var massey = new University();
            var student = new Student("12345678", "Big Mac", "12-12-1222", "33 Blah ave., Albany, North Shore");
            bool addSuccess = massey.AddStudent(student);

            bool removeSuccess;
            if (removeSuccess = massey.RemoveStudent("12345678"))
                Console.WriteLine("12345678 removed");
            else
                Console.WriteLine("12345678 not existed");

            if (removeSuccess = massey.RemoveStudent("12345678"))
                Console.WriteLine("12345678 removed");
            else
                Console.WriteLine("12345678 not existed");
        }

        [TestMethod]
        public void TestSplitByBar()
        {
            StreamReader reader = new StreamReader("C:\\Github\\EnrolmentSystem\\EnrolmentSystem\\Data\\MainDataBase.txt");
            while (reader.Peek() > 0)
            {
                string[] temp = reader.ReadLine().Split('_');
                foreach (string tp in temp)
                {
                    Console.Write(tp+"-");
                }
                Console.Write("\n");
            }
        }

        


    }
}
