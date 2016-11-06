using Facade_Pattran.Terran;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Facade_Pattran
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private TerranBuildOrderFacade buildOrder;

        private string[] buildOrderNames = { "Cheese Rush", "FDTerran"};

        #region property
        public string[] BuildOrderNames
        {
            get
            {
                return buildOrderNames;
            }

            set
            {
                buildOrderNames = value;
                var handler = this.PropertyChanged;

                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("BuildOrderNames"));
                }
            }
        }
        #endregion 

        public ICommand CheeseRushCommand { get; set; }
        public ICommand FakeDoubleTerranCommand { get; set; }

        public ViewModel()
        {
            buildOrder = new TerranBuildOrderFacade();

            CheeseRushCommand = new RelayCommand<object>(buildOrder.CheeseRush);
            FakeDoubleTerranCommand = new RelayCommand<object>(buildOrder.FakeDoubleTerran);
        }


    }
}
