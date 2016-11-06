using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattran.Terran
{
    public class CommandCenter
    {

        private const string name = "Terran Command Center";
        private const int suppotPopulation = 10;


        public CommandCenter()
        {
            TerranState.INSTANCE.increaseCommandCenter();
        }

        public List<SCV> makeScv(int count)
        {
            List<SCV> scvList = new List<SCV>();
            try
            {
                if (count > 5)
                {
                    throw new NotSupportedException("대기열이 가득 찼습니다.");
                }
                else
                {
                    for (int i = 0; i < count; i++)
                        scvList.Add(new SCV());
                }
            }
            catch(NotSupportedException e)
            {
                for (int i = 0; i < 5; i++)
                    scvList.Add(new SCV());
            }

            return scvList;
        }

        public void makeScv(int count, ref List<ITerranUnit> unitList)
        {
           
            try
            {
                if (count > 5)
                {
                    throw new NotSupportedException("대기열이 가득 찼습니다.");
                }
                else
                {
                    for (int i = 0; i < count; i++)
                        unitList.Add(new SCV());
                }
            }
            catch (NotSupportedException e)
            {
                for (int i = 0; i < 5; i++)
                    unitList.Add(new SCV());
            }

           
        }


    }
}
