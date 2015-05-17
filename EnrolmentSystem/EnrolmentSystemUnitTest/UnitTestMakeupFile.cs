using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnrolmentSystemUnitTest
{
    [TestClass]
    public class UnitTestMakeupFile
    {
        [TestMethod]
        public void TestGetRandomWord()
        {
            string word = "";
            for (int i = 0; i < 10; i++)
            {
                word = MakeupFileControl.MakeupFile.GetRandomWord();
                Console.WriteLine(word);
            }
        }
    }
}
