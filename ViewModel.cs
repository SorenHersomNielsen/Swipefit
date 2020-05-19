using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swipefit
{
    public class ViewModel
    {
        /// <summary>
        /// Den laver en ObservableCollection, som hedder VareListe
        /// </summary>
        public ObservableCollection<Vare> VarerListe { get; set; }
        = new ObservableCollection<Vare>();

        /// <summary>
        /// linje ned under henter et billede fra din computer
        /// Den laver det navnet image1 i dette tilfæld
        /// det bliver til objcet, som du kan bruger i senere i programmet
        /// </summary>
        Image image1 = Image.FromFile("c:\\navyblazer.jpg");
        
        public ViewModel()
        {
            VarerListe = new ObservableCollection<Vare>();
            //Testdata
            VarerListe.Add(new Vare(image1, 179, "XL", "Marineblå ", "Jack & Jones Intelligence - Marineblå chinoshorts med løbesnor", "Blødt stræk-twill Jack & Jones samarbejder med Better Cotton-initiativet for at forbedre bomuldslandbrug på globalt plan Dette gør det bedre for landmændene og for miljøet "));

        }

    }
}
