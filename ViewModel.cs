using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace Swipefit
{
    public class ViewModel
    {
        //instance fields
        private string billede;
        private double pris;
        private string størrelse;
        private string farve;
        private string navn;
        private string beskrivelse;
       
        /// <summary>
        /// Den laver en ObservableCollection, som hedder VareListe
        /// </summary>
        public ObservableCollection<Vare> VarerListe { get; set; }
        = new ObservableCollection<Vare>();

        // properties
        public string Billede
        { get => billede;
            set => billede = value;
        }
        public double Pris 
        { get => pris;
            set => pris = value;
        }
        public string Strorrelse 
        { get => størrelse;
            set => størrelse = value;
        }
        public string Farve 
        {
            get => farve;
            set => farve = value;
        }
        public string Navn
        {
            get => navn;
            set => navn = value;
        }
        public string Beskrivelse 
        {
            get => beskrivelse;
            set => beskrivelse = value;
        }
        public string Billedesti
        {
            get;
            set;
        }
        
        public Vare SelectedItem { get; set; }

        public Vare NæsteVare { get; set; }

        public RelayCommand TilfojTojCommand { get; set; }
        public RelayCommand FjernBestemtTojCommand { get; set; }
        public RelayCommand VisNaesteVareCommand { get; set; }

        public int taeller { get; set; }
        
        //constructor
        public ViewModel()
        {
            VarerListe = new ObservableCollection<Vare>();
            //Testdata
            Billedesti = "/Assets/navyblazer.jpg";
            VarerListe.Add(new Vare(Billedesti, 179, "XL", "Marineblå ", "Jack & Jones Intelligence - Marineblå chinoshorts med løbesnor", "Blødt stræk-twill Jack & Jones samarbejder med Better Cotton-initiativet for at forbedre bomuldslandbrug på globalt plan Dette gør det bedre for landmændene og for miljøet "));
            Billedesti = "/Assets/nakd_smocked_flounce_top_1014-000939-0529_01a.jpg";
            VarerListe.Add(new Vare(Billedesti, 250, "S", "Beige", "NAKD mini kjole", "elastisk og blød og har et ærmeløst design"));
            //Billedesti = "/Assets/nakd_ribbed_racerback_dress_1100-003105-0005_02k_r.jpg";
            //VarerListe.Add(new Vare(Billedesti, 150, "M", "rød", "boohoo top", "blomstermønstret top med v udsk¨ring"));
            
            TilfojTojCommand = new RelayCommand(TilfojToj);
            FjernBestemtTojCommand = new RelayCommand(FjernBestemtToj);
            taeller = 0;
            VisNaesteVareCommand = new RelayCommand(visvare);
        }

        /// <summary>
        /// metoden giver brugen lov, til at tilføj ny nyt tøj til programmet
        /// </summary>
        public void TilfojToj()
        {
            Vare vare = new Vare(Billede, Pris, Strorrelse, Farve, Navn, Beskrivelse);
            VarerListe.Add(vare);
            Billedesti = Billede;
        }

        /// <summary>
        /// metoden giver brugen lov, til at fjern bestemt tøj fra programmet
        /// </summary>
        public void FjernBestemtToj()
        {
            VarerListe.Remove(SelectedItem);
        }
       
        public void visvare()
        {
            
           
            if (VarerListe.Count() < 10)
            {
                taeller = taeller + 1;
                Billedesti = VarerListe[taeller].Billede;
            }
        }
    }    
}