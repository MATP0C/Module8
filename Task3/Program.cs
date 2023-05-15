using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToDirectory = "C:\\Users\\bogda\\OneDrive\\Рабочий стол\\C#\\000";
            DirectoryInfo del = new DirectoryInfo("C:\\Users\\bogda\\OneDrive\\Рабочий стол\\C#\\000");
            double catalogSize = 0;
            catalogSize = sizeOfFolder(pathToDirectory, ref catalogSize);
            if (catalogSize != 0)
            {
                Console.WriteLine("Размер католога {0}", pathToDirectory);
                Console.WriteLine("Исходный размер составляет: {0} байт", catalogSize);
                try
                {
                    foreach (FileInfo fi in del.GetFiles())
                    {
                        fi.Delete();
                        Directory.CreateDirectory(pathToDirectory);
                        Console.WriteLine("Освобождено:{0}", catalogSize);
                        Console.WriteLine("Текущий размер составляет: 0 байт");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Освобождено: 0 байт");
                    Console.WriteLine("Текущий размер составляет: {0} байт", catalogSize);
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Каталог {0} пуст.", pathToDirectory);
            }
            Console.ReadLine();
        }

        static double sizeOfFolder(string folder, ref double catalogSize)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(folder);
                DirectoryInfo[] diA = di.GetDirectories();
                FileInfo[] fi = di.GetFiles();
                foreach (FileInfo f in fi)
                {
                    catalogSize = catalogSize + f.Length;
                }
                foreach (DirectoryInfo df in diA)
                {
                    sizeOfFolder(df.FullName, ref catalogSize);
                }
                return catalogSize;
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Директория не найдена. Ошибка: " + ex.Message);
                return 0;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Отсутствует доступ. Ошибка: " + ex.Message);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка. Обратитесь к администратору. Ошибка: " + ex.Message);
                return 0;
            }
        }

    }
}