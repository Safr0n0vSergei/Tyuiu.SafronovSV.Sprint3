using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SafronovSV.Sprint3.Task7.V26.Lib
{
    public class DataService : ISprint3Task7V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;//объявляем пустой массив
            int len = (stopValue - startValue) + 1;//вычисляем длинну массива
            valueArray = new double[len];//Создаем массив с указанной длинной
            double y;
            int count = 0;
            for(int x=startValue;x<=stopValue;x++)
            {
                y = Math.Round(5 -( 3 * x) + (1 + Math.Sin(x)) /( 2 * x - 0.5), 2);//Округляем значение до двух знаков после запятой 
                valueArray[count] = y;//Присваиваем значение в массив с индексом count
                count++;
            }
            return valueArray;
        }
    }
}
