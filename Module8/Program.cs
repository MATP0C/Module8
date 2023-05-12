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
                DirectoryInfo newDirectory = new DirectoryInfo(@"newDirectory");
                if (!newDirectory.Exists)
                {
                    newDirectory.Create();
                }
                Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"newDirectory");
                dirInfo.Delete(true);
                Console.WriteLine("Каталог удалён");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
