using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders
{
    internal class Derss
    {
        string dersAdi;
        int dersSaati;
        double not1;
        double not2;
        double ortalama;
        string durum;

        public string DersAdi { get => dersAdi; set => dersAdi = value; }
        public int DersSaati { get => dersSaati; set => dersSaati = value; }
        public double Not1 { get => not1; set => not1 = value; }
        public double Not2 { get => not2; set => not2 = value; }
        public double Ortalama { get => ortalama; set => ortalama = value; }
        public string Durum { get => durum; set => durum = value; }

        public Derss(string dersAdi, int dersSaati, double not1, double not2)
        {
            DersAdi = dersAdi;
            DersSaati = dersSaati;
            Not1 = not1;
            Not2 = not2;
            Ortalama = ortalama;
            Durum = durum;

        }



    }
}
