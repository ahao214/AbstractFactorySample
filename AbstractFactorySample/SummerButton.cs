﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    /// <summary>
    /// Summer按钮类，充当具体产品
    /// </summary>
    class SummerButton : Button
    {
        public void Display()
        {
            Console.WriteLine("显示浅蓝色的按钮");
        }
    }
}
