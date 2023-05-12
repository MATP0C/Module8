using System;
using System.IO;

namespace Module8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string filePath = @"C:\Users\bogda\OneDrive\Рабочий стол\C#";
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = " ";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
