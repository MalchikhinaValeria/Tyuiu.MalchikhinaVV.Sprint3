﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MalchikhinaVV.Sprint3.Task1.V22.Lib
{
    public class DataService : ISprint3Task1V22
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;

            while (startValue <= stopValue)
            {
                sumSeries = sumSeries + (Math.Pow(value, startValue) + 0.5) * Math.Cos(startValue);
                startValue++;
            }
            
            return Math.Round(sumSeries, 3);
        }
    }
}
