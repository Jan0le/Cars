using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClasses
{

        public abstract class AReifen
        {
            public virtual void Rollen() { }
            public virtual double Außendurchmesser { get; set; }

        }
        public class Vollgummireifen : AReifen
        {
            public override double Außendurchmesser
            {
                get { return Außendurchmesser; }
                set
                {
                    if (value <= 0)
                        Außendurchmesser = 0;
                }
            }
        }

        public class Eisenreifen : AReifen
        {
            public override void Rollen()
            {
                Console.WriteLine("Das Auto fährt!");
            }
            public override double Außendurchmesser
            {
                get { return Außendurchmesser; }
                set
                {
                    if (value <= 0)
                        Außendurchmesser = 0;
                }
            }
        }

        public abstract class ALuftreifen : AReifen
        {
            private double druck;
            private string felge;
            private bool innen;

            public virtual double innendurchmesser { get; set; }
            public virtual bool reifenist { get; set; }
            public virtual void Lufteinfuellen() { }
        }

        public class Fahrradreifen : ALuftreifen
        {
            public override double innendurchmesser { get; set; }
            public override bool reifenist { get; set; }
            public override double Außendurchmesser
            {
                get { return Außendurchmesser; }
                set
                {
                    if (value <= 0)
                        Außendurchmesser = 0;
                }
            }
            public override void Rollen()
            {
                Console.WriteLine("Das Auto fährt!");
            }
            public override void Lufteinfuellen()
            {
                Console.WriteLine("Luft wird eingefüllt!");
            }
        }
        public class Autoreifen : ALuftreifen
        {
            public override double innendurchmesser { get; set; }
            public override bool reifenist { get; set; }
            public override double Außendurchmesser
            {
                get { return Außendurchmesser; }
                set
                {
                    if (value <= 0)
                        Außendurchmesser = 0;
                }
            }
            public override void Rollen()
            {
                Console.WriteLine("Das Auto fährt!");
            }
            public override void Lufteinfuellen()
            {
                Console.WriteLine("Luft wird eingefüllt!");
            }
        }

        public class LKWReifen : ALuftreifen
        {
            public override double innendurchmesser { get; set; }
            public override bool reifenist { get; set; }
            public override double Außendurchmesser
            {
                get { return Außendurchmesser; }
                set
                {
                    if (value <= 0)
                        Außendurchmesser = 0;
                }
            }
            public override void Rollen()
            {
                Console.WriteLine("Das Auto fährt!");
            }
            public override void Lufteinfuellen()
            {
                Console.WriteLine("Luft wird eingefüllt!");
            }
        }
    }

