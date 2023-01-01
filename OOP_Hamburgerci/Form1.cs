using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Siparisler> tumSiparisler = new List<Siparisler>();

        public static List<Siparisler> mevcutSiparis = new List<Siparisler>();

        

        public static List<Menu> menuler = new List<Menu>()
        
        {
            new Menu{MenuAdi="Big King", Fiyati=30.25M},
            new Menu{MenuAdi="Double King Chicken", Fiyati=28.25M},
            new Menu{MenuAdi="Steak House", Fiyati=40.50M},
            new Menu{MenuAdi="Whooper", Fiyati=32.00M},
            new Menu{MenuAdi="Whooper Jr. ", Fiyati=20.25M},
            new Menu{MenuAdi="Chicken Royal", Fiyati=20.25M},
        };
        public static List<Ekstra> ekstralar = new List<Ekstra>()
        {
        new Ekstra{EkstraAdi="Ketçap", EkstraFiyat=0.75M},
        new Ekstra{EkstraAdi="Mayonez", EkstraFiyat=1.25M},
        new Ekstra{EkstraAdi="Barbekü", EkstraFiyat=2.75M},
        new Ekstra{EkstraAdi="Soğan Halkası", EkstraFiyat=5.75M},
        new Ekstra{EkstraAdi="Patates", EkstraFiyat=7.75M},
        new Ekstra{EkstraAdi="Range Sos", EkstraFiyat=1.75M},
        };

        List<Menu> ornek = new List<Menu>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (Menu item in menuler)
            {
                cbMenuler.Items.Add(item);
            }
            foreach (Ekstra item in ekstralar)
            {
                flpEkstraMalzeme.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag=item });    //Tag propertysi object tutar , itemı bunun içinde tutuyoruz
            }

            foreach (Siparisler item in mevcutSiparis)
            {
                lbSiparisler.Items.Add(item);
            }
            rbKucuk.Checked = true;
            cbMenuler.SelectedIndex = 0;
        }

        public decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbSiparisler.Items.Count; i++)
            {
                Siparisler gelenSiparis =(Siparisler) lbSiparisler.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparisler yeniSiparis = new Siparisler();
            yeniSiparis.SeciliMenu = (Menu)cbMenuler.SelectedItem;
            if (rbKucuk.Checked)
            {
                yeniSiparis.Boyut = Boyut.Kucuk;
            }
            else if (rbOrta.Checked)
            {
                yeniSiparis.Boyut = Boyut.Orta;
            }
            else
            {
                yeniSiparis.Boyut = Boyut.Buyuk;
            }
            yeniSiparis.EkstraMalzeme = new List<Ekstra>();
            foreach (CheckBox item in flpEkstraMalzeme.Controls)
            {
                if (item.Checked)
                {
                    yeniSiparis.EkstraMalzeme.Add((Ekstra)item.Tag);
                    //FlowLayoutPaneldeki controllerden seçilenlerin herbirinin tag propertysinde tutulan ekstra malzemenin kopyasını verir.
                }
            }

            yeniSiparis.Adet = Convert.ToInt32(nmrAdet.Value);

            yeniSiparis.Hesapla();    //Sipariş clasındaki hesapla metodu oluşan yeni siparişin  toplam fiyatını hesaplar

            tumSiparisler.Add(yeniSiparis);
            mevcutSiparis.Add(yeniSiparis);
            lbSiparisler.Items.Add(yeniSiparis);
            TutarHesapla();

            Fonksiyon.Temizle(this.Controls);
        }

        private void btnSiparişTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı: " + TutarHesapla().ToString("C2") + "\nSiparişi tamamlamak ister misiniz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr==DialogResult.Yes)
            {
                lbSiparisler.Items.Clear();
                mevcutSiparis.Clear();
                TutarHesapla();
                MessageBox.Show("Siparişiniz Tamamlandı");
            }
            else
            {
                MessageBox.Show("İptal Edildi");
            }
            
        }

        
    }
}
