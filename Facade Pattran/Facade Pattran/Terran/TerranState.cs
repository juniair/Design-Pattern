using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattran.Terran
{
    public class TerranState
    {
        #region SigleTon
        private static TerranState state = new TerranState();
        private TerranState()
        {

        }

        public static TerranState INSTANCE
        {
            get
            {
                return state;
            }
        }

        #endregion

        #region Command Center Feild
        private int commandCenterCount = 0;
        private bool isCommandCenter = false;

        public bool COMMAND_CENTER
        {
            get
            {
                return isCommandCenter;
            }
        }

        public void increaseCommandCenter()
        {
            commandCenterCount++;
            isCommandCenter = true;
        }
        

        public void decreaseCommandCenter()
        {
            if (commandCenterCount > 0)
            {
                commandCenterCount--;
            }

            if (commandCenterCount == 0)
            {
                isCommandCenter = false;
            }
        }
        #endregion

        #region Supply Depot Feild
        private int supplyCount = 0;
        private bool isSupply = false;
        public bool SUPPLY
        {
            get
            {
                return isSupply;
            }
        }

        public void increaseSupply()
        {
            this.supplyCount++;
            isSupply = true;
        }

        public void decreaseSupply()
        {
            if (supplyCount > 0)
            {
                supplyCount--;
            }

            if (supplyCount == 0)
            {
                isSupply = false;
            }
        }
        #endregion

        #region Barracks Feild

        private int barracksCount = 0;
        private bool isBarracks = false;

        public bool BARRACKS
        {
            get
            {
                return isBarracks;
            }
        }

        public void increaseBarracks()
        {
            barracksCount++;
            this.isBarracks = true;
        }

        public void decreaseBarracks()
        {
            if (barracksCount > 0)
            {
                barracksCount--;
            }

            // 스타2에서 병영은 보급고가 있어야 건설 가능하다.
            if (supplyCount == 0)
            {
                this.isBarracks = false;
            }
        }


        #endregion

        #region Unit Feild
        private int currentPopulation = 0;
        private const int limitPopulation = 200;

        public int TOTALPOPULATION
        {
            get
            {
                return currentPopulation;
            }

            set
            {

                if (limitPopulation <= value)
                {
                    throw new NotSupportedException("인구수가 초과 되었습니다.");
                }
                else
                {
                    currentPopulation = value;
                }
            }
        }

        #endregion

    }
}
