using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SafronovSV.Sprint3.Task3.V6.Lib
{
    public class DataService : ISprint3Task3V6
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            
            foreach(char chr in value )
            {
                if (Char.IsDigit(chr))
                {
                    value = value.Replace(chr, 't');
                }    
            }
            return value;
        }
    }
}
