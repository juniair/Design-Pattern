using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Adapter_Pacade_Pattern
{
    public class Medic : IMedicUnitControl
    {
        public void clickAction()
        {
            MessageBox.Show("치료 대상 찾는 중");
        }

        public void heal()
        {
            MessageBox.Show("치료");
        }
    }
}
