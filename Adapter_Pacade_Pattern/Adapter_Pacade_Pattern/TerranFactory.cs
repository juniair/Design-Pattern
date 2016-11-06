using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pacade_Pattern
{
    public class TerranFactory
    {
        #region SingleTon
        private static TerranFactory instance = new TerranFactory();
        
        public enum UNIT_TYPE { MARINE, SIEGE_TANK, MEDIC }

        private TerranFactory()
        {

        }

        public static TerranFactory INSTANCE
        {
            get
            {
                return instance;
            }
        }
        #endregion

        public ITerranUintControl MakeUnit(UNIT_TYPE ut)
        {
            ITerranUintControl unit = null;

            switch (ut)
            {
                case UNIT_TYPE.MARINE:
                    unit = new Marine();
                    break;
                case UNIT_TYPE.SIEGE_TANK:
                    unit = new SiegeTank();
                    break;
                case UNIT_TYPE.MEDIC:
                    unit = new MedicAdapter(new Medic());
                    break;
            }
            return unit;
        }
    }
}
