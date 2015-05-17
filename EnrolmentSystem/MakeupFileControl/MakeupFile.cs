using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupFileControl
{
    public class MakeupFile
    {
        static Random random = new Random();
        public static void MakeFile()
        {
            string names = "Tom Jerry Frank Newton Dannel Tessa Thor Tony Stark Wong Wang Sheldon Cooper Lenerd Howard Raj";
            string[] nameLib = names.Split(' ');

        }

        public static string GetRandomWord()
        {
            string words = "Alpha And ASCII Apple Alter Bit Byte By Be Compute Computer Compress C# C++ Digital Dot Deep Echo Epic File Final Future Good Gap Google High Hint Int In Illustrate Inner Java Low Long Left Lisp Logo Menu Make Made Match Main Not No New Nest Neat";
            string[] wordLib = words.Split(' ');
            return wordLib[random.Next(wordLib.Length - 1)];
        }

        public static string GetRandomName()
        {
            string names = "Tom Jerry Frank Newton Dannel Tessa Thor Tony Stark Wong Wang Sheldon Cooper Lenerd Howard Raj";
            string[] nameLib = names.Split(' ');
            return nameLib[random.Next(nameLib.Length - 1)];
        }

        
    }
}
