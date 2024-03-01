using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SafronovSV.Sprint3.Task4.V11.Lib;
namespace Tyuiu.SafronovSV.Sprint3.Task4.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stoptValue = 5;

            Console.WriteLine("Старт шага  = " + startValue);
            Console.WriteLine("Конец шага = " + stoptValue );


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.Calculate(startValue,stoptValue));
            Console.ReadKey();
        }
    }
}
