using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    /// <summary>
    /// Summer组合框类，充当具体产品
    /// </summary>
    class SummerComboBox : ComboBox
    {
        public void Display()
        {
            Console.WriteLine("显示蓝色边框的组合框");
        }
    }
}
