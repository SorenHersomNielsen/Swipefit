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

        public Vare Billede { get; set; }

        /// <summary>
        /// linje ned under henter et billede fra din computer
        /// Den laver det navnet image1 i dette tilfæld
        /// det bliver til objcet, som du kan bruger i senere i programmet
        /// </summary>
        Image image1 = Image.FromFile("c:\\navyblazer.jpg");
        Image Image2 = Image.FromFile("C:\\nakd_ribbed_racerback_dress_1100-003105-0005_02k_r");
        Image Image3 = Image.FromFile("c:\\nakd_smocked_flounce_top_1014-000939-0529_01a");
        
        public ViewModel()
        {
            VarerListe = new ObservableCollection<Vare>();
            //Testdata
            VarerListe.Add(new Vare(image1, 179, "XL", "Marineblå ", "Jack & Jones Intelligence - Marineblå chinoshorts med løbesnor", "Blødt stræk-twill Jack & Jones samarbejder med Better Cotton-initiativet for at forbedre bomuldslandbrug på globalt plan Dette gør det bedre for landmændene og for miljøet "));
            VarerListe.Add(new Vare(Image2, 250, "S", "Beige", "NAKD mini kjole", "elastisk og blød og har et ærmeløst design"));
            VarerListe.Add(new Vare(Image3, 150, "M", "rød", "boohoo top", "blomstermønstret top med v udsk¨ring"));

        }

    }
}
