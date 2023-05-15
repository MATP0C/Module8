using System;
using System.IO;
using System.Threading;
using System.Timers;
using static System.Net.WebRequestMethods;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo("C:\\Users\\bogda\\OneDrive\\Рабочий стол\\C#\\000");
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
        private void DeleteFile(string path) 
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo("C:\\Users\\bogda\\OneDrive\\Рабочий стол\\C#\\000");
                foreach (FileInfo fi in dirInfo.GetFiles())
                {
                    var creationTime = fi.CreationTime;

                    if (creationTime < (DateTime.Now - new TimeSpan(0, 0, 30, 0)))
                    {
                        fi.Delete();
                    }
                }
            }
            catch (Exception ex)
            {
                    Console.WriteLine(ex.Message);
            }
        }
    }
}