using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swipefit
{
    public class ViewModel
    {
        public ObservableCollection<Vare> VarerListe { get; set; }
        = new ObservableCollection<Vare>();

        public ViewModel()
        {
            VarerListe = new ObservableCollection<Vare>();
            //Testdata

        }




    }
}
