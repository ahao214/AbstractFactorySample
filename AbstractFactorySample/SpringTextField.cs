using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    /// <summary>
    /// Spring文本框类，充当具体产品
    /// </summary>
    class SpringTextField : TextField
    {
        public void Display()
        {
            Console.WriteLine("显示绿色边框的文本框");
        }
    }
}
