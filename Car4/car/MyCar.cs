
using System;
using System.Security.Cryptography.X509Certificates;

namespace CarClasses
{
    public class Autos
    {
        private string farbe;
        private double benötigKraft;

        private double preis;
        public double Preis
        {
            get
            {
                return preis;
            }
            set
            {
                if (value > 0)
                {
                    this.preis = value;
                }
                else
                {
                    this.preis = 0;
                }
            }
        }

        public int leistung;
        public bool allrad;
        private double kraftstoffstand;

        private int maxgeschw;
        public int Maxgeschw
        {
            get
            {
                return maxgeschw;
            }
            set
            {
                if ((value > 0) && (value < 260))
                {
                    this.maxgeschw = value;
                }
                else
                {
                    this.maxgeschw = 0;
                }
            }
        }

        private double Maxtank;
        public double maxtank
        {
            get
            {
                return maxtank;
            }
            set
            {
                if ((value > 20) && (value < 100))
                {
                    this.maxtank = value;
                }
                else
                {
                    this.maxtank = 0;
                }
            }
        }

        public Autos()
        {
            farbe = "unbekannt";
            preis = 0;
            leistung = 0;
            allrad = false;
        }

        public Autos(string farbe, double preis, int leistung, bool allrad) : this()
        {
            this.farbe = farbe;
            this.preis = preis;
            this.leistung = leistung;
            this.allrad = allrad;
        }

        public Autos(string farbe, double preis, int leistung, bool allrad, double benötigKraft, double kraftstoffstand, int maxgeschw, int maxtank) : this(farbe, preis, leistung, allrad)
        {
            this.farbe = farbe;
            this.Preis = preis;
            this.leistung = leistung;
            this.allrad = allrad;
            this.benötigKraft = benötigKraft;
            this.kraftstoffstand = kraftstoffstand;
            this.maxgeschw = maxgeschw;
            this.Maxtank = maxtank;
        }

        public double ladekapazität { get; set; }
        public double masse { get; set; }

    }

    class Transportfahrzeug : Autos
    {
        public double ladekapazität;
        private double beladen;
        private double entladen;
        public Transportfahrzeug(double ladekapazität, double beladen, double entladen)
        {
            this.beladen = beladen;
            this.entladen = entladen;
            this.ladekapazität = ladekapazität;
        }
        public virtual void Beladen(double beladen)
        {
            if (beladen <= ladekapazität && ladekapazität + beladen <= 18000)
            {
                ladekapazität += beladen;
                Console.WriteLine("Wird beladen... Kapazität:" + ladekapazität);
            }
            else
            {
                Console.WriteLine("Die Ladekapazität ist zu gering");
            }
        }
        public virtual void Enladen(double enladen)
        {
            if (entladen <= ladekapazität && ladekapazität - entladen >= 0)
            {
                ladekapazität -= entladen;
                Console.WriteLine("Wird entladen... Kapazität" + ladekapazität);
            }
            else
            {
                Console.WriteLine("Soviel Ladekapazität ist nicht vorhanden");
            }
        }
    }
    class LKW : Transportfahrzeug
    {
        public double kranbel;
        public double kranent;
        public double krankap;

        public LKW(double krankap, double kranbel, double kranent ,double ladekapazität, double beladen, double entladen) : base(ladekapazität, beladen, entladen)
        {
            this.kranbel = kranbel;
            this.kranent = kranent;
            this.krankap = krankap; 
        }

        public  void KranBeladen()
        {
                krankap += kranbel;
                Console.WriteLine("Wird beladen... Kapazität:" + krankap);
        }
        public void KranEntladen()
        {
                krankap -= kranent;
                Console.WriteLine("Wird entladen... Kapazität:" + krankap);
        }
    }
    class Kleintransporter : Transportfahrzeug
    {
        public Kleintransporter (double ladekapazität, double beladen, double entladen) : base(ladekapazität, beladen, entladen)
        {
            
        }
    }
    class Personenkraftwagen : Autos
    {
        protected int perAnzahl;
        public Personenkraftwagen(int perAnzahl)
        {
            this.perAnzahl = perAnzahl;
        }           
    }
    class Autobus : Autos
    {

        //public Autobus( int perAnzahl) : base(perAnzahl) 
        //{
        //    this.perAnzahl=perAnzahl;
        //}

        public void öffTür()
        {
            Console.WriteLine("Tür offen");
        }

        public void zuTür()
        {
            Console.WriteLine("Tür zu");
        }
    }

 
}
