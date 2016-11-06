using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattran.Terran
{
    public class TerranBuildOrderFacade
    {
        List<ITerranUnit> unitList = new List<ITerranUnit>();
        List<ITerranUnit> buildUnitList = new List<ITerranUnit>();
        List<ITerranUnit> attackUnitList = new List<ITerranUnit>();
        SCV scv = new SCV();
        Barracks barracks;
        Factory factory;
        SupplyDepot supplyDepot;
        List<CommandCenter> commandCenterList = new List<CommandCenter>();

        public TerranBuildOrderFacade()
        {
            commandCenterList.Add(new CommandCenter());
        }

        public void CheeseRush(object obj)
        {
            supplyDepot = scv.buildSupplyDepot();
            barracks = scv.buildBarrack();
            commandCenterList[0].makeScv(5, ref unitList);
            barracks.makeUnit("marine", 5, ref unitList);
            foreach (ITerranUnit unit in unitList)
            {
                unit.move();
                unit.attack();
            }
        }

        public void FakeDoubleTerran(object obj)
        {
            commandCenterList[0].makeScv(3, ref buildUnitList);
            supplyDepot = scv.buildSupplyDepot();
            commandCenterList[0].makeScv(4, ref buildUnitList);
            barracks = scv.buildBarrack();
            barracks.makeUnit("marine", 5, ref attackUnitList);
            barracks.makeUnit("medic", 1, ref attackUnitList);
            factory = scv.buildFactory();
            factory.makeUnit("tank", 2, ref attackUnitList);
            foreach (ITerranUnit unit in attackUnitList)
            {
                unit.move();
                unit.attack();
            }

            commandCenterList.Add(scv.buildCommandCenter());
            factory.makeUnit("vulture", 1, ref attackUnitList);
        }

    }
}
