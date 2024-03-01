using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SafronovSV.Sprint3.Task6.V30.Lib
{
    public class DataService : ISprint3Task6V30
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int i,j;
            int count = 0;
            for (i =startValue;i<=stopValue; i++)
            {
                
                for(j=1;j<=i;j++)
                {
                    if(i%j==0)
                    {
                        count++;
                    }    
                }

            }
            return count;
        }
    }
}
