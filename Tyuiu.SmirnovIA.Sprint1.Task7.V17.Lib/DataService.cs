﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SmirnovIA.Sprint1.Task7.V17.Lib
{
    public class DataService : ISprint1Task7V17
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round((1 + Math.Sin(Math.Sqrt(x * x + 1))) / (Math.Cos(12 * y - 4)), 3);
            return res;
        }
    }
}
