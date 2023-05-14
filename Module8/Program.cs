using System;
using System.IO;
using System.Threading;
using System.Timers;

namespace DirectoryManager
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
                var timer = new Timer{ Interval = 30000 };
                timer.Tick += (sender, args) => dirInfo.Delete(true);
                Console.WriteLine("Удалено");
            }
            catch (Exception ex)
            {
                    Console.WriteLine(ex.Message);
            }
        }
    }
}