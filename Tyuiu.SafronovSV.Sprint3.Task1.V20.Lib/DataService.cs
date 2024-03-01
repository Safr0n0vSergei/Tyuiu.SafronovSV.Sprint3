using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SafronovSV.Sprint3.Task1.V20.Lib
{
    public class DataService : ISprint3Task1V20
    {
      

        public double GetSumSeries(int startValue, int stopValue)
        {
            double multSeries = 0;
            while (startValue <= stopValue)
            {
                multSeries = multSeries + (Math.Pow(1 / Math.Cos(startValue), 2));
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
