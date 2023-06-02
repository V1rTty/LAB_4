using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Введіть шлях до каталогу: ");
        string folderPath = Console.ReadLine();

        Console.Write("Введіть рік (4 цифри): ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Введіть місяць (01-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Введіть день (01-31): ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Введіть годину (00-23): ");
        int hour = int.Parse(Console.ReadLine());

        Console.Write("Введіть хвилину (00-59): ");
        int minute = int.Parse(Console.ReadLine());

        Console.Write("Введіть секунду (00-59): ");
        int second = int.Parse(Console.ReadLine());

        try
        {
            string[] files = Directory.GetFiles(folderPath);

            foreach (string filePath in files)
            {
                DateTime newCreationTime = new DateTime(year, month, day, hour, minute, second);
                File.SetCreationTime(filePath, newCreationTime);
            }

            Console.WriteLine("Готово!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Виникла помилка: " + e.Message);
        }
    }
}
