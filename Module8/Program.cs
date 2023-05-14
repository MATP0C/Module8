using System;
using System.IO;
namespace ReadMyFile
{
    class Program
    {
        public static void Main()
        {
            string filePath = "C:\\Users\\bogda\\OneDrive\\Рабочий стол\\BinaryFile.bin";

            if (File.Exists(filePath))
            {
                string stringValue;
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    stringValue = reader.ReadString();
                }
                Console.WriteLine("Из файла считано:");
                Console.WriteLine(stringValue);
            }
        }
    }
}