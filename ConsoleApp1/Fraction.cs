using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Fraction
    {
            private int suret;
            private int mexrec;

            public int Suret
            {
                get { return suret; }
                set { suret = value; }
            }

            public int Mexrec
            {
                get { return mexrec; }
            set {
                if (value != 0) mexrec = value;
                else throw new Exception("mexrecde sifir ola bilmez...");
            } 
            }


            public Fraction()
            {
                suret = 1;
                mexrec = 1;
            }

            public Fraction(int x, int y)
            {
                Suret = x;
                Mexrec = y;
            }

        public Fraction Toplama(Fraction other)
        {
            this.Suret = this.Suret * other.Mexrec + this.Mexrec * other.Suret;
            this.Mexrec = this.Mexrec * other.Mexrec;
            return this;
        }


        public Fraction Cixma(Fraction other)
        {
            this.Suret = this.Suret * other.Mexrec - this.Mexrec * other.Suret;
            this.Mexrec = this.Mexrec * other.Mexrec;
            return this;
        }

        public Fraction Vurma(Fraction other)
        {
            this.Suret = this.Suret * other.Suret;
            this.Mexrec = this.Mexrec * other.Mexrec;
            return this;
        }

        public Fraction Bolme(Fraction other)
        {
            this.Suret = this.Suret * other.Mexrec;
            this.Mexrec = this.Mexrec * other.Suret;
            return this;
        }










        public void Show()
        {
            Console.WriteLine(@$"{this.Suret} / {this.Mexrec}
");
           
        }






    }
}
