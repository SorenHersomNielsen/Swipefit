using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.ObjectModel;

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
        public string Image 
        { get => billede;
            set => billede = value;
        }
        public double Pris 
        { get => pris;
            set => pris = value;
        }
        public string Strørrelse 
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

        public RelayCommand TilføjTøjCommand { get; set; }
        public RelayCommand FjernBestemtTøjCommand { get; set; }

        public Vare Billede { get; set; }
       
        //constructor
        public ViewModel()
        {
            VarerListe = new ObservableCollection<Vare>();
            //Testdata
            Billedesti = "/Assets/StoreLogo.png";
            VarerListe.Add(new Vare(Billedesti, 179, "XL", "Marineblå ", "Jack & Jones Intelligence - Marineblå chinoshorts med løbesnor", "Blødt stræk-twill Jack & Jones samarbejder med Better Cotton-initiativet for at forbedre bomuldslandbrug på globalt plan Dette gør det bedre for landmændene og for miljøet "));
            Billedesti = "/Assets/LockScreenLogo.scale-200.png";
            VarerListe.Add(new Vare(Billedesti, 250, "S", "Beige", "NAKD mini kjole", "elastisk og blød og har et ærmeløst design"));
            
            //VarerListe.Add(new Vare(Image3, 150, "M", "rød", "boohoo top", "blomstermønstret top med v udsk¨ring"));
            TilføjTøjCommand = new RelayCommand(TilføjTøj);
            FjernBestemtTøjCommand = new RelayCommand(FjernBestemtTøj);           
        }

        /// <summary>
        /// metoden giver brugen lov, til at tilføj ny nyt tøj til programmet
        /// </summary>
        public void TilføjTøj()
        {
            Vare vare = new Vare(Image, Pris, Strørrelse, Farve, Navn, Beskrivelse);
            VarerListe.Add(vare);
        }

        /// <summary>
        /// metoden giver brugen lov, til at fjern bestemt tøj fra programmet
        /// </summary>
        public void FjernBestemtTøj()
        {
            VarerListe.Remove(Billede);
        }

    }    
}