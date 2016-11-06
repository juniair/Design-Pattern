using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Adapter_Pacade_Pattern
{
    public class SiegeTank : ITerranUintControl
    {
        public void attack()
        {
            MessageBox.Show("퉁퉁");

        }

        public void clickAction()
        {
            MessageBox.Show("딴 따라 따~ 딴 따라 라우");
        }


    }
}
