using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZairovAR.Sprint3.Task1.V12.Lib
{
    public class DataService : ISprint3Task1V12
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double multSeries = 0 ;
            while (startValue <= stopValue)
            {
                multSeries = multSeries + (Math.Pow((1 / (Math.Pow(startValue, value))), 2));
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
