using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.HubulovaVI.Sprint5.Task4.V21.Lib;
using System.IO;

namespace Tyuiu.HubulovaVI.Sprint5.Task4.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Хубулова В. И. | АСОИУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Оператор цикла continue/break                                     *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Хубулова Валерия Игоревна | АСОИУб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле . Вычислить *");
            Console.WriteLine("* значение по формуле (Полученное значение округлить до трёх знаков после *");
            Console.WriteLine("* запятой) и вернуть полученный результат на консоль.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V21.txt";
            Console.WriteLine("Данные в файле:" + path);
            Console.WriteLine("x= " + File.ReadAllText(path).Replace('.', ','));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(service1.LoadFromDataFile(path));

            Console.ReadKey();
        }
    }
}