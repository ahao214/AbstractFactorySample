using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    /// <summary>
    /// Summer皮肤工厂，充当具体工厂
    /// </summary>
    class SummerSkinFactory : SkinFactory
    {
        public Button CreateButton()
        {
            return new SummerButton();
        }

        public ComboBox CreateComboBox()
        {
            return new SummerComboBox();
        }

        public TextField CreateTextField()
        {
            return new SummerTextField();
        }
    }
}
