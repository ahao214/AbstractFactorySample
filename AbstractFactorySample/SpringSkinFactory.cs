using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    /// <summary>
    /// Spring皮肤工厂，充当具体工厂
    /// </summary>
    class SpringSkinFactory : SkinFactory
    {
        public Button CreateButton()
        {
            return new SpringButton();
        }

        public ComboBox CreateComboBox()
        {
            return new SpringComboBox();
        }

        public TextField CreateTextField()
        {
            return new SpringTextField();
        }
    }
}
