using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Facade_Pattran.Terran
{
    public class Marine : ITerranUnit
    {
        public Marine()
        {
            MessageBox.Show("한 판 붙어볼까, 애송이?", "마린");
        }

        public void attack()
        {
            MessageBox.Show("명령 받았습니다.", "마린");
        }
        

        public void move()
        {
            MessageBox.Show("돌격 앞으로!", "마린");
        }
    }
}
