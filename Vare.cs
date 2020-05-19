using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;
using Windows.UI.Xaml.Controls;
using System.Drawing;

namespace Swipefit
{
    public class Vare
    {
        //instance fields
        private System.Drawing.Image billede;
        private double pris;
        private string størrelse;
        private string farve;
        private string navn;
        private string beskrivelse;
        
        // properties
        public System.Drawing.Image Billede
        {
            get { return billede; }
            set { billede = value; }
        }
        public double Pris
        {
            get { return pris; }
            set { pris = value; }
        }

       public string Størrelse
        {
            get { return størrelse; }
            set { størrelse = value; }
        }
        public string Farve 
        {
            get { return farve; }
            set { farve = value; }
        }
        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }
        public string Beskrivelse
        { get { return beskrivelse; }
          set { beskrivelse = value; }
        }
        //constructor
        public Vare(System.Drawing.Image Billede, double Pris, string Størrelse, string Farve, string Navn, string Beskrivelse)
        {
            this.billede = Billede;
            this.pris = Pris;
            this.størrelse = Størrelse;
            this.farve = Farve;
            this.navn = Navn;
            this.beskrivelse = Beskrivelse;
        }
        public Vare()
        {

        }

    }
    }

