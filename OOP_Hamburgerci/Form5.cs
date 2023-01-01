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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdedi = 0;
            foreach (Siparisler siparis in Form1.tumSiparisler)
            {
                ciro += siparis.ToplamTutar;
                foreach (Ekstra ekstraMalzeme in siparis.EkstraMalzeme)
                {
                    ekstraMalzemeGeliri += ekstraMalzeme.EkstraFiyat;
                }
                satisAdedi += siparis.Adet;
                lbxTumSiparisler.Items.Add(siparis);
            }

            lblToplamSiparis.Text = lbxTumSiparisler.Items.Count.ToString();
            lblCiro.Text = ciro.ToString("C2");
            lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString("C2");
            lblSatilanUrunAdedi.Text = satisAdedi.ToString();


        }
    }
}
