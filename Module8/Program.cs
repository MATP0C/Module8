using System;
using System.IO;

class Task2
{
    public static void Main()
    {
        var fileInfo = new FileInfo("C:\\Users\\bogda\\OneDrive\\Рабочий стол\\C#\\sr.txt");

        using (StreamWriter sw = fileInfo.AppendText())
        {
            sw.WriteLine($"// Время запуска: {DateTime.Now}");
        }

        using (StreamReader sr = fileInfo.OpenText())
        {
            string str = "";
            while ((str = sr.ReadLine()) != null)
                Console.WriteLine(str);

        }
    }
}