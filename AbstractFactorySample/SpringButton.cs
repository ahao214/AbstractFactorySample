using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    /// <summary>
    /// Spring按钮类，充当具体产品
    /// </summary>
    class SpringButton : Button
    {
        public void Display()
        {
            Console.WriteLine("显示浅绿色的按钮");
        }
    }
}
