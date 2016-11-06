using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Facade_Pattran.Terran
{
    public class SCV : ITerranUnit
    {
        private const int usingPopulation = 1;

        public SCV()
        {
            TerranState.INSTANCE.TOTALPOPULATION++;
            MessageBox.Show("건설로봇 준비 완료!", "SCV");
        }

        public Barracks buildBarrack()
        {
            
            if (TerranState.INSTANCE.SUPPLY)
            {
                this.move();
                return new Barracks();
            } 
            else
            {
                throw new NotSupportedException("보급고를 지어야 합니다.");
            }
                
        }

        public CommandCenter buildCommandCenter()
        {
            this.move();
            return new CommandCenter();
        }

        public SupplyDepot buildSupplyDepot()
        {
            this.move();
            return new SupplyDepot();
        }

        public Factory buildFactory()
        {
            
            if(TerranState.INSTANCE.BARRACKS)
            {
                this.move();
                return new Factory();
            }
            else
            {
                throw new NotSupportedException("병영을 건설 해야 합니다.");
            }
        }

        public void move()
        {
            MessageBox.Show("이야, 야근이다.", "SCV");
        }

        public void attack()
        {
            MessageBox.Show("뭐 이딴 작전이 다 있어?", "SCV");
        }
    }
}
