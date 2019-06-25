using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    /// <summary>
    /// Summer文本框类，充当具体产品
    /// </summary>
    class SummerTextField : TextField
    {
        public void Display()
        {
            Console.WriteLine("显示蓝色边框的文本框");
        }
    }
}
