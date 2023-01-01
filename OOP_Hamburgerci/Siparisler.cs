using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci
{
    public class Siparisler
    {
        public Menu SeciliMenu { get; set; }
        public Boyut Boyut { get; set; }
        public List<Ekstra> EkstraMalzeme { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        //Küçük boy seçerse normal fiyat  , orta boy ise yüzde 10 fazlası, büyük boy ise yüzde 25 fazlası olacak .

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyati;
            switch (Boyut)
            {
                
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10M;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.25M;
                    break;
                
            }
            foreach (Ekstra ekstra in EkstraMalzeme)
            {
                ToplamTutar += ekstra.EkstraFiyat;
            }
            ToplamTutar *= Adet;
        }
        public override string ToString()
        {
            if (EkstraMalzeme.Count<1 )            //Ekstra malzeme yoksa  seçilen siparişin lisboxa nasıl yazılacağının formatını belirliyoruz
            {
                return string.Format("{0} Menü x {1} Adet, {2} Boy, Toplam {3}", SeciliMenu.MenuAdi, Adet, Boyut, ToplamTutar.ToString("c2"));   //C2 parasal değer formatı 
            }
            else
            {
                string ekstraMalzemeler = null;
                foreach (Ekstra ekstra in EkstraMalzeme)
                {
                    ekstraMalzemeler += ekstra.EkstraAdi + ",";
                    ekstraMalzemeler = ekstraMalzemeler.Trim(',');
                    
                }
                return string.Format("{0} Menü x {1} Adet, {2} Boy, {3} Ekstra Malzemeler, Toplam {4}", SeciliMenu.MenuAdi, Adet, Boyut, ekstraMalzemeler, ToplamTutar.ToString("c2"));
            }

        }
    }
}
