using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.HubulovaVI.Sprint5.Task3.V28.Lib;
using System.IO;

namespace Tyuiu.HubulovaVI.Sprint5.Task3.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Хубулова В. И. | АСОИУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнила: Хубулова Валерия Игоревна | АСОИУб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение, вычислить его значение при x = 3                        *");
            Console.WriteLine("* результат сохранить в бинарный файл OutPutFileTask3.bin                 *");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}