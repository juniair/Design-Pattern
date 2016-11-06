using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Facade_Pattran.Terran
{
    public class SupplyDepot
    {

        private const int suppotPopulation = 8;

        public SupplyDepot()
        {
            TerranState.INSTANCE.increaseSupply();
            MessageBox.Show("SupplyDepot :: 건설이 완료되었습니다.");
        }
    }
}
