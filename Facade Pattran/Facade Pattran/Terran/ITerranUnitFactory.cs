using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattran.Terran
{
    public interface ITerranUnitFactory
    {
        void makeUnit(string name, int count, ref List<ITerranUnit> unitList);
        ITerranUnit selectUnit(string name);
    }
}
