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
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\bogda\OneDrive\Рабочий стол");
                string trashPath = "C:\\$RECYCLE.BIN";
                dirInfo.MoveTo(trashPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
