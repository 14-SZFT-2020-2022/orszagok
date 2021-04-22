using System;

namespace orszagokAdatbazis
{
    class Orszag
    {
        public string OrszagNeve { get; set; }
        public string Fovaros { get; set; }
        public string FoldrajziHely { get; set; }
        public double Terulet { get; set; }
        public string Allamforma { get; set; }
        public int Nepesseg { get; set; }
        public int FovarosNepesseg { get; set; }
        public string Autojel { get; set; }
        public string Country { get; set; }
        public string Capital { get; set; }
        public string Penznem { get; set; }
        public string Penzjel { get; set; }
        public string Valtopenz { get; set; }
        public int Telefon { get; set; }
        public int GDP { get; set; }
        public int Kategoria { get; set; }

        public Orszag(string on, string fv, string fh, string ter, string af, string nep, string fn, string aj, string cou, string cap, string pn, string pj, string vp, string tel, string gdp, string kat)
        {
            this.OrszagNeve = on;
            this.Fovaros = fv;
            this.FoldrajziHely = fh;
            this.Terulet = Double.Parse(ter);
            this.Allamforma = af;
            this.Nepesseg = Int32.Parse(nep);
            this.FovarosNepesseg = Int32.Parse(fn);
            this.Autojel = aj;
            this.Country = cou;
            this.Capital = cap;
            this.Penznem = pn;
            this.Penzjel = pj;
            this.Valtopenz = vp;
            this.Telefon = Int32.Parse(tel);
            this.GDP = Int32.Parse(gdp);
            this.Kategoria = Int32.Parse(kat);
        }
    }
}
