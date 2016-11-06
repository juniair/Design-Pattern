using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Facade_Pattran.Terran
{
    public class Vulture : ITerranUnit
    {
        public void attack()
        {
            MessageBox.Show("한 번 붙어 볼까", "벌처");
        }

        public void move()
        {
            MessageBox.Show("자, 갑니다.", "벌처");
        }

    }
}
