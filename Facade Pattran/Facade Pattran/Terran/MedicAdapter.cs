using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattran.Terran
{
    public class MedicAdapter : ITerranUnit
    {
        ITerranMedicUnit medic;

        public MedicAdapter(ITerranMedicUnit medic)
        {
            this.medic = medic;
        }
        public void attack()
        {
            medic.heal();
        }

        public void move()
        {
            medic.move();
        }
    }
}
