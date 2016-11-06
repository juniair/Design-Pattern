using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattran.Terran
{
    public class SpiderMine
    {
        bool isUpgrade = false;

        public bool UPGRADE
        {
            get
            {
                return isUpgrade;
            }

            set
            {
                isUpgrade = value;
            }
        }
    }
}
