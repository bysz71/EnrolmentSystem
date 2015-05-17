using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnrolmentSystemModel;
using System.Collections.Generic;

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
            var student = new Student(12345678,"Big Mac",new BirthDay(1,7,1955),"33 Blah ave., Albany, North Shore");
            var paper = new Paper("158.212", "Application Software Development", "Dr Teo Susnjak");
            paper.AddStudent(student);
            var student2 = new Student(11111111, "Small Mac", new BirthDay(1, 1, 2011), "22 aaa rd., Albany, North Shore");
            
            bool addSuccess;
            if (addSuccess = paper.AddStudent(student))
                Console.WriteLine(student.Id + " Added");
            else
                Console.WriteLine(student.Id + " Existed");

            if (addSuccess = paper.AddStudent(student2))
                Console.WriteLine(student2.Id + " Added");
            else
                Console.WriteLine(student2.Id + " Existed");

            Console.Write("Student List:\n" + paper.StudentList());
        }

        [TestMethod]
        public void TestPaperRemoveStudent()
        {
            var student = new Student(12345678, "Big Mac", new BirthDay(1, 7, 1955), "33 Blah ave., Albany, North Shore");
            var paper = new Paper("158.212", "Application Software Development", "Dr Teo Susnjak");
            paper.AddStudent(student);
            var student2 = new Student(11111111, "Small Mac", new BirthDay(1, 1, 2011), "22 aaa rd., Albany, North Shore");
            paper.AddStudent(student2);

            bool removeSuccess;
            if (removeSuccess = paper.RemoveStudent(11111111))
                Console.WriteLine("11111111 successfully removed");
            else
                Console.WriteLine("11111111 is not existed");

            if (removeSuccess = paper.RemoveStudent(11111111))
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
            var student = new Student(12345678, "Big Mac", new BirthDay(1, 7, 1955), "33 Blah ave., Albany, North Shore");

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
            var student = new Student(12345678, "Big Mac", new BirthDay(1, 7, 1955), "33 Blah ave., Albany, North Shore");
            bool addSuccess = massey.AddStudent(student);

            bool removeSuccess;
            if (removeSuccess = massey.RemoveStudent(12345678))
                Console.WriteLine("12345678 removed");
            else
                Console.WriteLine("12345678 not existed");

            if (removeSuccess = massey.RemoveStudent(12345678))
                Console.WriteLine("12345678 removed");
            else
                Console.WriteLine("12345678 not existed");
        }



    }
}
