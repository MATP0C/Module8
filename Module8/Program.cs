using System;
using System.IO;

namespace Module8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo("C:\\");
                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
