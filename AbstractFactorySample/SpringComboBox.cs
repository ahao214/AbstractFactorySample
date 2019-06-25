using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    /// <summary>
    /// Spring组合框类，充当具体产品
    /// </summary>
    class SpringComboBox:ComboBox
    {
        public void Display()
        {
            Console.WriteLine("显示绿色边框的组合框");
        }
    }
}
