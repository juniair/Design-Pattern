using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pacade_Pattern
{
    public class MedicAdapter : ITerranUintControl
    {

        private IMedicUnitControl unit;

        public MedicAdapter(IMedicUnitControl unit)
        {
            this.unit = unit;
        }

        public void attack()
        {
            unit.heal();
        }

        public void clickAction()
        {
            unit.clickAction();
        }
    }
}
