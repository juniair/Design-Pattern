using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Facade_Pattran.Terran
{
    public class Medic : ITerranMedicUnit
    {

        public Medic()
        {
            MessageBox.Show("의사가 왔습니다.", "메딕");
        }

        public void heal()
        {
            MessageBox.Show("이 환자는... 죽겠는데요?", "메딕");
        }

        public void move()
        {
            MessageBox.Show("제가 봐 드리죠.", "메딕");
        }
    }
}
