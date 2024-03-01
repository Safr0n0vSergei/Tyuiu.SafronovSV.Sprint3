using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SafronovSV.Sprint3.Task3.V6.Lib;

namespace Tyuiu.SafronovSV.Sprint3.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "12able 1o s4gh";
            char item = 't';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Исходный символ = " + item);
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат после замены = " + ds.ReplaceNumOnChar(value, item));
            Console.ReadKey();
        }
    }
}
