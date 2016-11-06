using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Adapter_Pacade_Pattern
{
    public class Marine : ITerranUintControl
    {
        public void attack()
        {
            MessageBox.Show("공격");
        }

        public void clickAction()
        {
            MessageBox.Show("이동");
        }
    }
}
