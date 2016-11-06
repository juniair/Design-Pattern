using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Adapter_Pacade_Pattern
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string[] ActionNames = { "attck", "move", "siege mode" };
        private ITerranUintControl marine, tank, medic;

        #region property
        public string[] UnitActionNames
        {
            get
            {
                return ActionNames;
            }

            set
            {
                ActionNames = value;
                var handler = this.PropertyChanged;

                if(handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("UnitActionNames"));
                }
            }
        }
        #endregion 

        public ICommand AttackCommand { get; set; }
        public ICommand MoveCommand { get; set; }

        public ViewModel()
        {
            marine = TerranFactory.INSTANCE.MakeUnit(TerranFactory.UNIT_TYPE.MARINE);
            tank = TerranFactory.INSTANCE.MakeUnit(TerranFactory.UNIT_TYPE.SIEGE_TANK);
            medic = TerranFactory.INSTANCE.MakeUnit(TerranFactory.UNIT_TYPE.MEDIC);

            AttackCommand = new RelayCommand<object>(attack);
            MoveCommand = new RelayCommand<object>(move);
        }


        private void attack(object obj)
        {
            string type = obj as string;
            switch (type)
            {
                case "0":
                    marine.attack();
                    break;
                case "1":
                    tank.attack();
                    break;
                case "2":
                    medic.attack();
                    break;
                default:
                    break;
            }
        }

        private void move(object obj)
        {
            string type = obj as string;
            switch (type)
            {
                case "0":
                    marine.clickAction();
                    break;
                case "1":
                    tank.clickAction();
                    break;
                case "2":
                    medic.clickAction();
                    break;
                default:
                    break;
            }
        }
    }
}
