using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattran.Terran
{
    public class Factory : ITerranUnitFactory
    {

        private const string name = "Terran Barracks";

        public Factory()
        {
            

        }

        public void makeUnit(string name, int count, ref List<ITerranUnit> unitList)
        {

            try
            {
                if(count > 5)
                {
                    throw new NotSupportedException("대기열이 가득 찼습니다.");
                }
                for (int i = 0; i < count; i++)
                {
                    unitList.Add(selectUnit(name));
                }
            }
            catch (NotSupportedException e)
            {
                
                for (int i = 0; i < 5; i++)
                {
                    unitList.Add(selectUnit(name));
                }
            }

        }

        public ITerranUnit selectUnit(string name)
        {
            TerranState.INSTANCE.TOTALPOPULATION++;
            switch (name)
            {
                case "tank":
                    return new SiegeTank();
                case "vulture":
                    return new Vulture();
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
