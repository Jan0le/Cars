using System;


namespace CarClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Autos[] Auto = new Autos[3];
            Auto[0] = new Autos("orange", -298392 /*<- Preis*/, 120, true);
            Auto[1] = new Autos("lila", 49800, 230, false, 50, 5, 450 /*<- Geschwindigkeit*/, 20);
            Auto[2] = new Autos("blau", 73999, 310, true, 60, 6, 260, -16 /*<- MaxTank*/);


            Console.WriteLine(Auto[0].Preis);
            Console.WriteLine(Auto[1].Maxgeschw);
            Console.WriteLine(Auto[2].maxtank);


            //    AReifen b = new Eisenreifen(5);

            //    Eisenreifen aReifen = new Eisenreifen();
            //    Console.WriteLine( aReifen.Rollen );

            //    AReifen[] arrrefifen = new AReifen[]
            //{
            //    new Vollgummireifen(),
            //    new Eisenreifen(),
            //    new Autoreifen()
            //};
            //    Auto[0] = new Autos("orange", -298392 /*<- Preis*/, 120, true);
            //    Auto[0].AReifen = arrrefifen;
            //    Auto[0].AReifen[0];
            //    auto.AReifen[1];
            //    auto.AReifen[2];
            //    auto.AReifen[3];
            //}
        }
    }
}

