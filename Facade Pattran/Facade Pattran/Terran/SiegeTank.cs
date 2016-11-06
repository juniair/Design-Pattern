using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Facade_Pattran.Terran
{
    public class SiegeTank : ITerranUnit
    {
        public SiegeTank()
        {
            MessageBox.Show("연료 채웼습니다! 준비완료!", "시즈탱크");
        }

        public void attack()
        {
            MessageBox.Show("포격 개시!", "시즈탱크");
        }

        public void move()
        {
            MessageBox.Show("전진 앞으로!", "시즈탱크");
        }
    }
}
